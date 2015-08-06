using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeshTable
{
    public abstract class HashInterfacesRealizator:IChancheableEquability,IChangeableGetHeshCode
    {
        int MyGetHashCode(int val)
        {
            return val % 10;
        }

        public bool IsHashEqual(int first, int second)
        {
            return MyGetHashCode(first) == MyGetHashCode(second);
        }

        bool IChancheableEquability.IsHashEqual(int first, int second)
        {
            return MyGetHashCode(first) == MyGetHashCode(second);
        }

        int IChangeableGetHeshCode.MyGetHashCode(int val)
        {
            return val % 10;
        }
    }
}
