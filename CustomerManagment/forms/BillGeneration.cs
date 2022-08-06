using CustomerManagment.dao;
using CustomerManagment.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerManagment.forms
{
    public partial class BillGeneration : Form
    {
        public BillGeneration()
        {
            InitializeComponent();
        }

        private Bill createBill()
        {
            Bill bill = new Bill((BillType)cbxBillType.SelectedItem, Int16.Parse(lblBillNumber.Text), (Customer)cbxCustomerList.SelectedItem);
            return bill;
        }

        private DaoBill createDaoBill()
        {
            //Creo un DaoBill que brinda la conexión a la Bd
            DaoBill daoBill = new DaoBill();
            return daoBill;
        }
        private DaoCustomer createDaoCustomer()
        {
            //Creo un DaoCustomer que brinda la conexión a la Bd
            DaoCustomer daoCustomer = new DaoCustomer();
            return daoCustomer;
        }

        private void updateList()
        {
            //Creo una lista que va a traer la info de la BD al form mediante el clienteDao
            List<Customer> dbList = this.createDaoCustomer().getList();

            //Limpio la lista de los datos previos para asegurar que no se repitan cada vez que se actualiza
            cbxCustomerList.Items.Clear();
            //Agrego los clientes de la BD a la lista del form
            for (int i = 0; i < dbList.Count; i++)
            {
                Customer customer = dbList[i];
                cbxCustomerList.Items.Add(customer);
            }
        }

        private void BillGeneration_Load(object sender, EventArgs e)
        {

        }
    }
}
