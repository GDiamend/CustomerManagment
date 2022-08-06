using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagment.dao
{
    internal class Dao
    {
        protected MySqlConnection Connect()
        {
            //Con estos string asigno las variables de la base de datos que voy a utilizar
            string server = "localhost";
            string user = "root";
            string password = "";
            string dataBase = "customers";
            //Asigno todas las variables dentro de un string que luego utilizare al momento de crear la conexión
            string stringConnection = "Database=" + dataBase + "; Data Source=" + server +
                "; User Id=" + user + "; Password=" + password + "";

            //Creo una conexion e importo (using MySql.Data.MySqlClient;) la libreria de Sql
            MySqlConnection DbConnection = new MySqlConnection(stringConnection);
            //Abro la conexión para ser utilizada
            DbConnection.Open();

            return DbConnection;
        }

        protected void executeQuery(string query)
        {
            //Creo un comando al que le voy a pasar querys
            MySqlCommand cmd = new MySqlCommand(query);
            //Utilizo el comando para conectarme a la BD, ejecuto la query y cierro la conexión
            cmd.Connection = this.Connect();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
