using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MainMenu : AbstractMenu
    {
        private Menu1 first_Menu;
        private Menu2 second_Menu;
        private ConsoleColor defaultColor;
        private int activeMenu; // added property to track active menu

        public MainMenu(Menu1 first_Menu, Menu2 second_Menu)
        {
            this.first_Menu = first_Menu;
            this.second_Menu = second_Menu;
        }

        protected override void Init()
        {
            defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        protected override void Idle()
        {
            Console.Clear();
            Console.WriteLine("1 - Menu1");
            Console.WriteLine("2 - Menu2");
            Console.WriteLine("3 - Exit");

            int menuNumber = int.Parse(Console.ReadLine());
            switch (menuNumber)
            {
                case 1:
                    activeMenu = 1; // set active menu to Menu1
                    break;
                case 2:
                    activeMenu = 2; // set active menu to Menu2
                    break;
                case 3:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            // call the Run method of the active menu
            if (activeMenu == 1)
            {
                first_Menu.Run();
            }
            else if (activeMenu == 2)
            {
                second_Menu.Run();
            }
        }

        protected override void CleanUp()
        {
            Console.ForegroundColor = defaultColor;
        }
    }

}
