using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlogSyner
{
    class DecorationNode
    {
        public String decorate;
        public int start;
        public int end;

        public DecorationNode father;
        public List<DecorationNode> sons;
    }


    class DecorationTree
    {
        DecorationNode root;

        //建立根节点
        public DecorationTree()
        {
            root = new DecorationNode();

            root.decorate = "";
            root.father = null;
            root.start = 0;
            root.end = int.MaxValue;

            if(root.sons == null)
                root.sons = new List<DecorationNode>();
        }

        public DecorationNode Root
        {
            get {
                return root;
            }
        }

        public void insertNode(DecorationNode decNode, DecorationNode subTree, int startIdx)
        {
            if ((decNode.start >= subTree.start) && (decNode.end <= subTree.end))
            { 
                if (subTree.sons != null)
                {
                    int i = startIdx;

                    for (i = startIdx; i <= subTree.sons.Count - 1; i++)
                    {
                        if ((decNode.start < subTree.sons[i].end))
                        {
                            //三种关系： 相交  交集为空 包含

                            //交集为空 直接插入
                            if (decNode.end <= subTree.sons[i].start)
                            {

                                subTree.sons.Insert(i, decNode);
                                decNode.father = subTree;

                                break;

                            }

                            //当前的subTree.sons[i]为待插入的decNode的子集
                            else if ((decNode.start <= subTree.sons[i].start) && (decNode.end >= subTree.sons[i].end))
                            {
                                //将当前的decNode插入subTree，将原来的subTree.sons[i]摘下作为子节点
                                DecorationNode decTmp = subTree.sons[i];
                                subTree.sons.Insert(i, decNode);
                                subTree.sons.RemoveAt(i + 1);

                                decNode.sons = new List<DecorationNode>();
                                decNode.sons.Add(decTmp);
                                decTmp.father = decNode;

                                break;

                            }

                            //待插入的decNode为当前的subTree.sons[i]的子集
                            else if ((decNode.start >= subTree.sons[i].start) && (decNode.end <= subTree.sons[i].end))
                            {
                                insertNode(decNode, subTree.sons[i], 0);

                                break;
                            }

                            //待插入的decNode和当前的subTree.sons[i]前半部分相交
                            else if((decNode.start <subTree.sons[i].start) && (decNode.end <= subTree.sons[i].end))
                            {
                                DecorationNode decTmp = subTree.sons[i];
                                DecorationNode decNode1 = new DecorationNode();
                                DecorationNode decNode2 = new DecorationNode();

                                decNode1.start = decNode.start;
                                decNode1.end = decTmp.start;//插入的形式为[)
                                decNode1.decorate = decNode.decorate;
                                decNode1.father = subTree;

                                subTree.sons.Insert(i, decNode1);


                                decNode2.start = decTmp.start;
                                decNode2.end = decNode.end;
                                decNode2.decorate = decNode.decorate;

                                insertNode(decNode2, decTmp, 0);

                                break;
                            }
                            //待插入的decNode和当前的subTree.sons[i]后半部分相交
                            else if((decNode.start >= subTree.sons[i].start) && (decNode.end > subTree.sons[i].end))
                            {
                                DecorationNode decTmp = subTree.sons[i];
                                DecorationNode decNode1 = new DecorationNode();
                                DecorationNode decNode2 = new DecorationNode();

                                decNode1.start = decNode.start;
                                decNode1.end = decTmp.end;
                                decNode1.decorate = decNode.decorate;

                                insertNode(decNode1, subTree.sons[i], 0);


                                decNode2.start = decTmp.end;
                                decNode2.end = decNode.end;
                                decNode2.decorate = decNode.decorate;

                                insertNode(decNode2, subTree, i);
                            }
                            else
                            {
                               
                            }
                        }
                    }

                    //遍历到末尾
                    if (i == subTree.sons.Count)
                    {
                        subTree.sons.Add(decNode);
                        decNode.father = subTree;
                    }
                }
                else
                {
                    subTree.sons = new List<DecorationNode>();

                    decNode.father = subTree;
                    subTree.sons.Add(decNode);
                }
            }
        }

        public void showTree(TextBox textBox, String text)
        {
            showSubTree(root, textBox , text);
        }

        private void showSubTree(DecorationNode subTree, TextBox textBox, String text)
        {
       /*     if ((subTree.sons != null) && (subTree.sons.Count != 0))
            {

                for (int i = 0; i <= subTree.sons.Count - 1; i++)
                {
                    showSubTree(subTree.sons[i], textBox);
                }

            }

            if(subTree != null)
                textBox.AppendText(subTree.decorate + " " + subTree.start + " " + subTree.end);*/


            if ((subTree.sons == null) || (subTree.sons.Count == 0))
            {
                textBox.AppendText(subTree.decorate);

                textBox.AppendText(text.Substring(subTree.start, subTree.end - subTree.start));

                textBox.AppendText("/" + subTree.decorate);

                return;
            }

           
            textBox.AppendText(subTree.decorate);

            int start = subTree.start;

            for (int i = 0; i <= subTree.sons.Count - 1; i++)
            {
                if (start < subTree.sons[i].start)
                    textBox.AppendText(text.Substring(start, subTree.sons[i].start - start));

                showSubTree(subTree.sons[i], textBox, text);

                start = subTree.sons[i].end;
            }

            if (subTree.end!= int.MaxValue && (start < subTree.end))
                textBox.AppendText(text.Substring(start, subTree.end - start));

            textBox.AppendText("/"+subTree.decorate);
        }
    }
}
