using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTask1.Logic.Interfaces;

namespace WpfTask1.Logic
{
    class CStack<T> : IStack<T>
    {
        private List<T> data;
        public CStack()
        {
            data = new List<T>();
        }
        public bool Empty => !data.Any();

        public T Pop => PPop();

        public T Top => data.Last();

        public void Push(T d)
        {
            data.Add(d);
        }

        private T PPop()
        {
            T d = Top;
            if (data.Remove(d))
            {
                return d;
            }
            throw new NullReferenceException();
        }
    }
}
