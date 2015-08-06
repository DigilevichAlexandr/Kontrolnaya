using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeshTable
{
    public class HeshTableClass:HashInterfacesRealizator,IEnumerable
    {
        List<int>[] _banks = new List<int>[10];
        
        public HeshTableClass(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                _banks[MyGetHashCode(arr[i])].Add(arr[i]);
            }
        }

        public void Add(int val)
        {
            _banks[MyGetHashCode(val)].Add(val);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 10; i++)
                foreach (int element in _banks[i])
                    yield return element;
        }

        //public bool IsEqual(int first,int second)
        //{
        //    return GetHashCode(first)==GetHashCode(second);
        //}

        //int IChangeableGetHeshCode.GetHashCode(int val)
        //{
        //    return val % 10;
        //}

        int MyGetHashCode(int val)
        {
            return val % 10;
        }


    }
}
