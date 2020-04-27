using System;
using System.Data;
using System.Data.OleDb;

namespace CMPS253.GoFPatterns.Behavioral.Template
{
    public class Products : DataAccessObject
    {
        const string ProductsTable = "Products";
        public override void Select()
        {
            string sql = "select ProductName from Products";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, connectionString);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, ProductsTable);
        }

        public override void Process()
        {
            Console.WriteLine("Products ---- ");
            DataTable dataTable = dataSet.Tables[ProductsTable];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["ProductName"]);
            }
            Console.WriteLine();
        }
    }
}