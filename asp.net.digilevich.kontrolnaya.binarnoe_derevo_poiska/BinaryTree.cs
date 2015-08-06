using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp.net.digilevich.kontrolnaya.binarnoe_derevo_poiska
{
    public class BinaryTree<T>//:IEnumerable<T>
    {
        TreeNode<T> _root;

        public BinaryTree()
        {
            _root = null;
        }

        public void Add(T val)
        {
            if (_root==null)
            {
                _root = new TreeNode<T>(val);
                return;
            }
            TreeNode<T> ancor = _root;
            TreeNode<T> preancor=_root;
            bool left=false;
            //TreeNode<T> tempnode = new TreeNode<T>(val);
            while (ancor != null)
            {
                preancor = ancor;
                if (ancor.CompareTo(val) == 1)
                {
                    left = true;
                    ancor = ancor.Left;
                }
                else
                if (ancor.CompareTo(val) == -1)
                {
                    left = false;                    
                    ancor = ancor.Right;
                }
                else
                    throw new Exception("there is sach value already");
            }
            TreeNode<T> nodeforinsert = new TreeNode<T>(val);
            if (left)
                preancor.Left = nodeforinsert;
            else
                preancor.Right = nodeforinsert;                
        }

        //public IEnumerator<T> GetEnumerator()
        //{
        //    TreeNode<T> ancor = _root;
        //    Preorder(ancor);
        //}

        public void Print()
        {
            TreeNode<T> ancor = _root;
            Preorder(ancor);
            ancor = _root;
            Console.WriteLine();
            Inorder(ancor);
            ancor = _root;
            Console.WriteLine();
            Postorder(ancor);
        }

        void Preorder(TreeNode<T> tn)
        {
            if (tn != null)
            {
                Console.Write(tn.Value + " ");
                Preorder(tn.Left);
                Preorder(tn.Right);
            }
        }

        void Inorder(TreeNode<T> tn)
        {
            if (tn != null)
            {
                Inorder(tn.Left);
                Console.Write(tn.Value+" ");
                Inorder(tn.Right);
            }
        }

        void Postorder(TreeNode<T> tn)
        {
            if (tn != null)
            {
                Postorder(tn.Right);
                Console.Write(tn.Value + " ");
                Postorder(tn.Left);
            }
        }

        TreeNode<T> GoLeft(TreeNode<T> tn)
        {
            return tn.Left;
        }

        /// <summary>
        /// возвращает true, если операция прошла успешно.
        /// если елемент не найден, возвращает false;
        /// </summary>
        /// <returns></returns>
        public bool Remove(T val)
        {
            TreeNode<T> ancor = _root;
            TreeNode<T> preancor = _root;
            bool left = false;
            while (ancor != null)
            {
                if (ancor.Equals(val))
                    break;
                preancor = ancor;
                if (ancor.CompareTo(val) == 1)
                {
                    left = true;
                    ancor = ancor.Left;
                }
                    
                else
                {
                    left = false;
                    ancor = ancor.Right;
                }
            }

            if (ancor!=null && ancor.Equals(val))
            {
                if (ancor.Right != null)
                {
                    if (left)
                        preancor.Left = ancor.Right;
                    else
                        preancor.Right = ancor.Left;
                }
                else
                {
                    if (left)
                        preancor.Left = ancor.Right;
                    else
                        preancor.Right = ancor.Left;
                }
                return true;
            }
            else
                return false;
        }

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
