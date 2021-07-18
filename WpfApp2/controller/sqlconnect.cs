using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WpfApp2.controller
{
    class sqlconnect
    {

        public sqlconnect(string datasource, string dbname,string user,string password){
            SqlConnection db = new SqlConnection(new SqlConnectionStringBuilder() {
            
                DataSource = datasource,
                InitialCatalog = dbname,
                UserID=user,
                Password=password

            }.ConnectionString);

          
        }
  public static sqlconnect sqlfactory()
        {
         
            return new sqlconnect("(LocalDB)\\MSSQLLocalDB","basedados","", "");
        }


    }
}
