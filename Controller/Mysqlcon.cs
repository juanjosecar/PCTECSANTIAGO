using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data; //para poder usar el dataset
using System.Data.SqlClient;

namespace PCTECSANTIAGO
{
    public class Mysqlcon
    {
        public static MySqlConnection conn;
        public static String host;
        public static String database;
        public static String user;
        public static String passwd;

        public static void Open()
        {
            host = "bro1kgwbtikj3xirbkkf-mysql.services.clever-cloud.com";
            database = "bro1kgwbtikj3xirbkkf";
            user = "u8bj93byodckhgcg";
            passwd = "y98cnYB209aQOWALT8V9";
            conn = new MySqlConnection("server=" + host + "; database=" + database + ";Uid=" + user + "; pwd=" + passwd + ";");
            conn.Open();
        }//end

        public static Boolean Execute(String SQL)
        {
            Boolean estado = true;
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SQL;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al ejecutar la consulta " + e.Message);
                estado = false;
            }
            return estado;
        }

        public static MySqlDataReader Query(String sql)
        {
            MySqlDataReader query=null;
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                query = cmd.ExecuteReader();
            }
             
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta "+ex.Message);
            }
            return query;
        }

        public static DataSet EjecutarConDT(string cmd)
        {
            host = "bro1kgwbtikj3xirbkkf-mysql.services.clever-cloud.com";
            database = "bro1kgwbtikj3xirbkkf";
            user = "u8bj93byodckhgcg";
            passwd = "y98cnYB209aQOWALT8V9";
            conn = new MySqlConnection("server=" + host + "; database=" + database + ";Uid=" + user + "; pwd=" + passwd + ";");
            conn.Open();

            DataSet DS = new DataSet(); // Aqui creamos un nuevo dataset para que almacene nuestras consultas

            MySqlDataAdapter DP = new MySqlDataAdapter(cmd, conn);   //AHORAn nesecito adaptar los datos a ese dataset con SqlDataAdapter

            DP.Fill(DS); //esto es para que me rellene el data set que paso por parametro
            conn.Close();
            return DS;
        }

    }
}
