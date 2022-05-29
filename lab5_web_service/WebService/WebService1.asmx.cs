using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.Services;
using MySql.Data.MySqlClient;



namespace WebService {
  /// <summary>
  /// Summary description for WebService1
  /// </summary>
  [WebService(Namespace = "http://tempuri.org/")]
  [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
  [System.ComponentModel.ToolboxItem(false)]
  // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
  // [System.Web.Script.Services.ScriptService]
  public class WebService1 : System.Web.Services.WebService {
    [WebMethod]
    public int Add(int n1, int n2) {
      // add two numbers from users
      return n1+n2;
    }

    [WebMethod]
    public int Divide(int n1, int n2) {
      // divide two numbers from users
      return n1/n2;
    }
    [WebMethod]
    public int Multiply(int n1, int n2) {
      // mulptiply two numbers from users
      return n1*n2;
    }
    [WebMethod]
    public int Substract(int n1, int n2) {
      // substract two numbers from users
      return n1-n2;
    }
    [WebMethod]
    public DataTable GetList() {
      string config= "username=root;password=;database=lab5_220072233_ak;datasource=127.0.0.1;port=3306";
      MySqlConnection myConnection = new MySqlConnection(config);
      MySqlDataAdapter adapter = new MySqlDataAdapter();
      string query = "SELECT * FROM `calculations`";
      DataTable table = new DataTable();
      try {
        myConnection.Open();
        adapter.SelectCommand = new MySqlCommand(query, myConnection);
        adapter.Fill(table);
        myConnection.Close();
        return table;
      }
      catch (Exception e) {
        myConnection.Close();
        return null;
      }
    }

    [WebMethod]
    public string InsertData_(string equation ) {
      // add data to database
      try {
        string config = "username=root;password=;database=lab5_220072233_ak;datasource=127.0.0.1;port=3306";
        MySqlConnection myConnection = new MySqlConnection(config);
        myConnection.Open();
        string query = "INSERT INTO `calculations`(`recentCalculated`) VALUES ('"+equation+"')";
        MySqlCommand myCommand = new MySqlCommand(query, myConnection);
        myCommand.ExecuteNonQuery();
        myConnection.Close();
        return null;
      }
      catch (Exception e) {
        return e.Message;
      }
    }



  }
}
