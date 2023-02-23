using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Menu1 : AbstractMenu
    {
        private IMenu1_PresentationLayer menu1_PresentationLayer;
        private ConsoleColor defaultColor;

        public Menu1(IMenu1_PresentationLayer menu1_PresentationLayer)
        {
            this.menu1_PresentationLayer = menu1_PresentationLayer;
        }
        protected override void Init()
        {
            defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
        }
       

        protected override void Idle()
        {
            Console.Clear();
            Console.WriteLine("1 - Menu1.1");
            Console.WriteLine("2 - Menu1.2");
            Console.WriteLine("3 - Exit");

            int menuNumber = int.Parse(Console.ReadLine());
            switch (menuNumber)
            {
                case 1:
                    menu1_PresentationLayer.Menu1_1();
                    break;
                case 2:
                    menu1_PresentationLayer.Menu1_2();
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
