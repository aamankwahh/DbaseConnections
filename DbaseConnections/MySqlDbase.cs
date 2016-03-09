/**Description: This a Mysql Dbase crud
 * 
 * 
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;




namespace DbaseConnections
{
    public class MySqlDbase
    {
        private MySqlConnection con;
        private String constr;
        private String USERNAME;
        private string PASSWD;
        private string SERVER;
        private string DBASENAME;



        public MySqlDbase(String username,String password, String servername,String dbasename) {

            this.SERVER = servername;
            this.USERNAME = username;
            this.PASSWD = password;
            this.DBASENAME = dbasename;

           con = new MySqlConnection();

        constr="server="+SERVER+";uid="+USERNAME+";pwd="+PASSWD+";database="+DBASENAME+";";


            con.ConnectionString=constr;
           
        }


      
         public String connect(){

             //private Boolean status= false;
             String status;

             try
             {
                 this.con = new MySqlConnection();
                 con.ConnectionString = constr;
                 con.Open();
                 status = "Connection Success";
                 return status;
             }

             catch(MySqlException ex)
             {
                 status = ex.Message;
                 return status;
                
             }
        

    }



         public String insertData(String sql) {
             String status;
             MySqlCommand cmd = new MySqlCommand(sql,con);

             try
             {
                 cmd.ExecuteNonQuery();
                 status = "Insertion successful";
                 return status;

             }
             catch(MySqlException ex)
             {

                 status= ex.Message;
                 return status;
             
             }
             
         
         
         }


         public DataTable retrieveData(String sql) {
             DataTable tbl = new DataTable();

             MySqlCommand cmd = new MySqlCommand(sql,con);
             MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
             adapt.Fill(tbl);
             return tbl;
         }


        

    }

   
}
