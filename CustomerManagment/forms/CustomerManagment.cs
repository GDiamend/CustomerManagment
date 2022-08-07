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

namespace CustomerManagment
{
    public partial class CustomerManagment : Form
    {
        public CustomerManagment()
        {
            InitializeComponent();
        }

        private Customer createCustomer()
        {          
            Customer customer = new Customer(lblId.Text, txtName.Text, txtSurname.Text, txtDni.Text, txtPhone.Text, txtCreditCard.Text);

            return customer;
        }

        private DaoCustomer createDaoCustomer()
        {
            //Creo un DaoCustomer que brinda la conexión a la Bd
            DaoCustomer daoCustomer = new DaoCustomer();
            return daoCustomer;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.createDaoCustomer().insert(this.createCustomer());
            this.clearFields();
            this.updateList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Creo un cliente y casteo la seleccion del item para que la fn tome que lo seleccionado es un cliente  
            Customer customer = (Customer) lstCustomer.SelectedItem;
            this.createDaoCustomer().delete(customer);
            this.updateList();
        }

        private void clearFields()
        {
            lblId.Text = " ";
            txtName.Clear();
            txtSurname.Clear();
            txtDni.Clear();
            txtPhone.Clear();
            txtCreditCard.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clearFields();
        }

        private void CustomerManagment_Load(object sender, EventArgs e)
        {
            this.updateList();   
        }
                
        private void updateList()
        {
            //Creo una lista que va a traer la info de la BD al form mediante el clienteDao
            List<Customer> dbList = this.createDaoCustomer().getList();

            //Limpio la lista de los datos previos para asegurar que no se repitan cada vez que se actualiza
            lstCustomer.Items.Clear();
            //Agrego los clientes de la BD a la lista del form con un foreach
            foreach (Customer customer in dbList)
            {
                lstCustomer.Items.Add(customer);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)lstCustomer.SelectedItem;
            lblId.Text = customer.id;
            txtName.Text = customer.name;
            txtSurname.Text = customer.surname;
            txtDni.Text = customer.dni;
            txtPhone.Text = customer.phone;
            txtCreditCard.Text = customer.creditCard;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.createDaoCustomer().update(this.createCustomer());
            this.clearFields();
            this.updateList();
        }
    }
}
