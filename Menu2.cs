using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Menu2 : AbstractMenu
    {
        private IMenu2_PresentationLayer menu2_PresentationLayer;
        private ConsoleColor defaultColor;

        public Menu2(IMenu2_PresentationLayer menu2_PresentationLayer)
        {
            this.menu2_PresentationLayer = menu2_PresentationLayer;
        }
        protected override void Init()
        {
            defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
        }


        protected override void Idle()
        {
            Console.Clear();
            Console.WriteLine("1 - Menu2.1");
            Console.WriteLine("2 - Menu2.2");
            Console.WriteLine("3 - Exit");

            int menuNumber = int.Parse(Console.ReadLine());
            switch (menuNumber)
            {
                case 1:
                    menu2_PresentationLayer.Menu2_1();
                    break;
                case 2:
                    menu2_PresentationLayer.Menu2_2();
                    break;
                case 3:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
        protected override void CleanUp()
        {
            Console.ForegroundColor = defaultColor;
        }
    }
}
