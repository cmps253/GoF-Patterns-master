using System.Data;
namespace CMPS253.GoFPatterns.Behavioral.Template
{
    public abstract class DataAccessObject
    {
        protected string connectionString;
        protected DataSet dataSet;

        public virtual void Connect()
        {
            connectionString = @"provider=Microsoft.JET.OLEDB.4.0;data source=C:\Users\teach\Desktop\253\db1.mdb";
        }
        public abstract void Select();
        public abstract void Process();
        public virtual void Disconnect()
        {
            connectionString = "";
        }

        public void Run() //template method
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
}