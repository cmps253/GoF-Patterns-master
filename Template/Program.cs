namespace cmps253.patterns.gof.TemplateMethod
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