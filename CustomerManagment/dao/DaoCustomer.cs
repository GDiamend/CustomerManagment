using CustomerManagment.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagment.dao
{
    internal class DaoCustomer
    {
        public MySqlConnection Connect()
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

        private void executeQuery(string query)
        {
            //Creo un comando al que le voy a pasar querys
            MySqlCommand cmd = new MySqlCommand(query);
            //Utilizo el comando para conectarme a la BD, ejecuto la query y cierro la conexión
            cmd.Connection = this.Connect();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        //Creo una función para devolver la lista de clientes
        public List<Customer> getList()
        {
            List<Customer> customerList = new List<Customer>();

            //Creo un string que va a encerrar la query deseada
            string query = "SELECT * FROM `customers`";
            //Creo un comando al que le voy a pasar querys
            MySqlCommand cmd = new MySqlCommand(query);
            //Conecto el comando a la base de datos (utilizando la función Connect())
            cmd.Connection = this.Connect();
            //Creo una variable que va a leer el resultado de la query
            MySqlDataReader lecture = cmd.ExecuteReader();

            //Recorro la lista de clientes de la base de datos
            while (lecture.Read())
            {
                //Creo un cliente al que asigno los datos devueltos de la base de datos y lo agrego a la lista
                Customer customer = new Customer(lecture.GetString(0), lecture.GetString(1), lecture.GetString(2),
                    lecture.GetString(3), lecture.GetString(4), lecture.GetString(5));
                customerList.Add(customer);
            }
            //Cierro la conexión para no saturar con varias conexiones
            cmd.Connection.Close();

            return customerList;
        }

        public void delete(Customer customer)
        {
            //Uso un delete para eliminar el cliente
            string query = "DELETE FROM customers WHERE `customers`.`id` = " + customer.id + ";";
            this.executeQuery(query); ;
        }

        public void insert(Customer customer)
        {
            //Uso un insert para agregar el cliente creado
            string query = "INSERT INTO `customers` (`id`, `name`, `surname`, `dni`, `phone`, `credit_card`) VALUES (NULL, '"
                + customer.name + "', '" + customer.surname + "', '" + customer.dni + "', '" + customer.phone + "', '" 
                + customer.creditCard + "');";
            this.executeQuery(query);
        }

        public void update(Customer customer)
        {
            //Uso un update para actualizar los datos del cliente
            string query = "UPDATE `customers` SET `name` = '" 
                + customer.name + "', `surname` = '" + customer.surname + "', `dni` = '" + customer.dni + "', `phone` = '" 
                + customer.phone + "', `credit_card` = '" + customer.creditCard + "' WHERE `customers`.`id` = " + customer.id + ";";
            this.executeQuery(query);
        }
    }
}
