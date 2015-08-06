using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp.net.digilevich.kontrolnaya.binarnoe_derevo_poiska
{
    class TreeNode<T>:IComparable<T>,IEquatable<T>
    {
        public T Value { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(T v)
        {
            Value = v;
            Left = null;
            Right = null;
        }

        public int CompareTo(T other)
        {
            dynamic temp = this;
            return temp.Value > other ? 1 : (temp.Value == other ? 0 : -1);
        }

        public bool Equals(T other)
        {
            return (dynamic) this.Value == other;
        }
    }
}
