using ConsoleApp1;

IMenu1_PresentationLayer menu1_PresentationLayer = new Menu1_PresentationLayer();
IMenu2_PresentationLayer menu2_PresentationLayer = new Menu2_PresentationLayer();
Menu1 first_Menu = new Menu1(menu1_PresentationLayer);
Menu2 second_Menu = new Menu2(menu2_PresentationLayer);
MainMenu mainMenu = new MainMenu(first_Menu, second_Menu);

mainMenu.Run();
