using CustomerManagment.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagment.dao
{
    internal class DaoBill : Dao
    {
        //Creo una función para devolver la lista de facturas
        public List<Bill> getList()
        {
            List<Bill> billList = new List<Bill>();

            //Creo un string que va a encerrar la query deseada
            string query = "SELECT * FROM `bills`";
            //Creo un comando al que le voy a pasar querys
            MySqlCommand cmd = new MySqlCommand(query);
            //Conecto el comando a la base de datos (utilizando la función Connect())
            cmd.Connection = Connect();
            //Creo una variable que va a leer el resultado de la query
            MySqlDataReader lecture = cmd.ExecuteReader();

            //Recorro la lista de facturas de la base de datos
            while (lecture.Read())
            {
                //Creo una factura a la que asigno los datos devueltos de la base de datos y lo agrego a la lista
                Bill bill = new Bill(lecture.GetString(0), (BillType)lecture.GetChar(1) , lecture.GetInt32(2), lecture.GetFieldValue<Customer>(3));
                billList.Add(bill);
            }
            //Cierro la conexión para no saturar con varias conexiones
            cmd.Connection.Close();

            return billList;
        }

        public void insert(Bill bill)
        {
            string query = "INSERT INTO `bills` (`id`, `bill_type`, `number`, `customer_id`, `final_price`, `date`) VALUES(NULL, '"
                + bill.billType + "', '" + bill.number + "', '" + bill.getCustomerId() + "', '" + bill.finalPrice + "', '" + bill.date.ToString("yyyy-MM-dd") + "');";
            executeQuery(query);
        }

        public int getLastBillNumber()
        {
            string query = "SELECT MAX(number) FROM `bills`;";
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = Connect();
            MySqlDataReader lecture = cmd.ExecuteReader();
            lecture.Read();
            return lecture.GetInt32(0); 
        }
    }
}
