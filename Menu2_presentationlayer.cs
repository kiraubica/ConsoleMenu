using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Menu2_PresentationLayer : IMenu2_PresentationLayer
    {
        public void Menu2_1()
        {
            Console.WriteLine("Menu 2.1");
            Console.ReadKey();
        }
        public void Menu2_2()
        {
            Console.WriteLine("Menu 2.2");
            Console.ReadKey();
        }
    }
}
