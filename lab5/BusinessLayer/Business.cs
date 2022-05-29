using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer {
    public class Business {

      localhost.WebService1 web = new localhost.WebService1();
      Data dataObj = new Data();
      
      public string Equation { get; set; }

      // get all data
      public DataTable Getlist() {
        return dataObj.GetList();
      }

      // extract values from expressions..
      public void Cal( string expre ) {

        for( int index = 0; index < expre.Length; index++ ) {
          if (expre[index] == '/') {
            string n1 = expre.Split('/')[0];
            string n2 = expre.Split('/')[1];
            int ans = web.Divide(int.Parse(n1), int.Parse(n2));
            Equation = $"{n1} / {n2} = {ans}";
            // insert data
            dataObj.InsertData_(Equation);
          }
          else if ( expre[index] == '*') {
            string n1 = expre.Split('*')[0];
            string n2 = expre.Split('*')[1];
            int ans = web.Multiply(int.Parse(n1), int.Parse(n2));
            Equation = $"{n1} * {n2} = {ans}";
            // insert data
            dataObj.InsertData_(Equation);
          }
          else if (expre[index] == '+') {
            string n1 = expre.Split('+')[0];
            string n2 = expre.Split('+')[1];
            int ans = web.Add(int.Parse(n1), int.Parse(n2));
            Equation = $"{n1} + {n2} = {ans}";
            // insert data
            dataObj.InsertData_(Equation);
          }
          else if (expre[index] == '-') {
            string n1 = expre.Split('-')[0];
            string n2 = expre.Split('-')[1];
            int ans = web.Substract(int.Parse(n1), int.Parse(n2));
            Equation = $"{n1} - {n2} = {ans}";
            // insert data
            dataObj.InsertData_(Equation);
          }
        }
      }





  }
}
