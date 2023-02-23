using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Menu1_PresentationLayer : IMenu1_PresentationLayer
    {
        public void Menu1_1()
        {
            Console.WriteLine("Menu 1.1");
            Console.ReadKey();
        }
        public void Menu1_2()
        {
            Console.WriteLine("Menu 1.2");
            Console.ReadKey();
        }  
    }
}
