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
            Bill bill = new Bill(lblBillId.Text, (BillType)cbxBillType.SelectedItem, Int16.Parse(lblBillNumber.Text), (Customer)cbxCustomerList.SelectedItem);
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
            //Agrego los clientes de la BD a la lista del form con un foreach
            foreach (Customer customer in dbList)
            {
                cbxCustomerList.Items.Add(customer);
            }
        }

        private void showBillType()
        {
            foreach (BillType billType in Enum.GetValues(typeof(BillType)))
            {
                cbxBillType.Items.Add(billType);
            }
        }

        private void clearFields()
        {
            lblBillId.Text = "";
            txtCuantity0.Clear();
            txtCuantity1.Clear();
            txtCuantity2.Clear();
            txtCuantity3.Clear();
            txtCuantity4.Clear();
            txtCuantity5.Clear();
            txtCuantity6.Clear();
            txtCuantity7.Clear();
            txtCuantity8.Clear();
            txtCuantity9.Clear();
            txtDescription0.Clear();
            txtDescription1.Clear();
            txtDescription2.Clear();
            txtDescription3.Clear();
            txtDescription4.Clear();
            txtDescription5.Clear();
            txtDescription6.Clear();
            txtDescription7.Clear();
            txtDescription8.Clear();
            txtDescription9.Clear();
            txtPrice0.Clear();
            txtPrice1.Clear();
            txtPrice2.Clear();
            txtPrice3.Clear();
            txtPrice4.Clear();
            txtPrice5.Clear();
            txtPrice6.Clear();
            txtPrice7.Clear();
            txtPrice8.Clear();
            txtPrice9.Clear();
        }

        private void numberGenerator()
        {
            int index = 0001;
            int number = 000000000;
            number += 1;

            this.createDaoBill();

            lblBillNumber.Text = index.ToString() + number.ToString();
        }
        private void BillGeneration_Load(object sender, EventArgs e)
        {
            this.updateList();
            this.showBillType();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clearFields();
        }
    }
}
