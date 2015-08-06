using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp.net.digilevich.kontrolnaya
{
    public class TwoDirectionList<T>:IEnumerable<T>
    {
        Node<T> _head;
        Node<T> _tail;

        public TwoDirectionList()
        {
            //_head = new Node<T>();
            //_tail = _head;
            _head =null;
            _tail = null;
        }

        public void Add(T val)
        {
            if (_head == null)
            {
                _tail = new Node<T>();
                _tail.Value = val;
                _head = _tail;
                _tail.Next = null;
                _tail.Prev = null;
            }
            else
            {
                _tail.Next = new Node<T>();
                _tail.Next.Value = val;
                _tail = _tail.Next;
                _tail.Next = null;
            }            
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> ancor = _head;
            while (ancor != null)
            {
                yield return ancor.Value;
                ancor = ancor.Next;
            }
        }

        public T GetLast()
        {
            if(_tail!=null)
            {
                var result = _tail.Value;
                _tail = _tail.Prev;                
                _tail.Next.Dispose();
                _tail.Next = null;
                return result;
            }
            return default(T);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Node<T> ancor = _head;
            while (ancor != null)
            {
                yield return ancor.Value;
                ancor = ancor.Next;
            }
        }
    }
}
