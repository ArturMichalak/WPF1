using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTask1.Logic.Interfaces
{
    interface IStack<T>
    {
        bool Empty { get; }
        T Pop { get; }
        T Top { get; }
        void Push(T d);
    }
}
