namespace CMPS253.GoFPatterns.Behavioral.Template
{
    class MainApp
    {
        static void Main()
        {
            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();

            DataAccessObject daoProducts = new Products();
            daoProducts.Run();
        }
    }
}