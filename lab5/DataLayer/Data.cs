using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DataLayer {
    public class Data {

      
      localhost.WebService1 web = new localhost.WebService1();
      // add data to db
      public void InsertData_( string equation ) {
        web.InsertData_(equation);
      }
      // get al recent calculations
      public DataTable GetList() {
        string config = "username=root;password=;database=lab5_220072233_ak;datasource=127.0.0.1;port=3306";
        MySqlConnection myConnection = new MySqlConnection(config);
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        string query = "SELECT * FROM `calculations`";
        DataTable table = new DataTable();
        try
        {
          myConnection.Open();
          adapter.SelectCommand = new MySqlCommand(query, myConnection);
          adapter.Fill(table);
          myConnection.Close();
          return table;
        }
        catch (Exception e)
        {
          myConnection.Close();
          return null;
        }
      //return web.GetList();
      //return null;
    }
  }
}
