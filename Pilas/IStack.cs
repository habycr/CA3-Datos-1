using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    public interface IStack
    {
        void Push(int element);
        int Pop();
        int Top();
    }
}