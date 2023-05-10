using ToffeeSystemPrototype.AccountComponent;
using ToffeeSystemPrototype.InventoryComponent;
using ToffeeSystemPrototype.OrderComponent;

namespace ToffeeApplication
{
    internal static class Program
    {
        public static AccountComponent AccountComponent;
        public static Inventory Inventory;
        public static OrderComponent OrderComponent;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            AccountComponent = new AccountComponent();
            Inventory = new Inventory();
            OrderComponent = new OrderComponent(AccountComponent, Inventory);

            (new LoginForm()).Show();
            Application.Run();
        }
    }
}