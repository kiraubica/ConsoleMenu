using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class AbstractMenu
    {
        protected bool flag = true;

        protected abstract void Init();
        protected abstract void Idle();

        protected abstract void CleanUp();

        public void Run()
        {
            Init();
            while (flag)
            {
                Idle();
            }
            CleanUp();
        }
    }
}
