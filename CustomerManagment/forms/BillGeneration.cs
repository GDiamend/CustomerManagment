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
            Bill bill = new Bill(lblBillId.Text, (BillType)cbxBillType.SelectedItem, Int32.Parse(lblBillNumber.Text), (Customer)cbxCustomerList.SelectedItem);
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

        public string getCustomerData()
        {
            return (string)cbxCustomerList.SelectedItem;
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
            int number = this.createDaoBill().getLastBillNumber() + 1;

            lblBillNumber.Text = number.ToString();
        }
        private void BillGeneration_Load(object sender, EventArgs e)
        {
            this.updateList();
            this.showBillType();
            this.numberGenerator();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clearFields();
        }

        private List<Article> addingArticles()
        {
            List<Article> articles = new List<Article>();
            if (txtCuantity0.Text != null)
            {
                Article article = new Article(txtDescription0.Text, double.Parse(txtPrice0.Text));
                for (int i = 0; i < Int32.Parse(txtCuantity0.Text); i++)
                {
                    articles.Add(article);
                }
            }
            if (txtCuantity1.Text != "")
            {
                Article article = new Article(txtDescription1.Text, double.Parse(txtPrice1.Text));
                for (int i = 0; i < Int32.Parse(txtCuantity1.Text); i++)
                {
                    articles.Add(article);
                }
            }
            if (txtCuantity2.Text != "")
            {
                Article article = new Article(txtDescription2.Text, double.Parse(txtPrice2.Text));
                for (int i = 0; i < Int32.Parse(txtCuantity2.Text); i++)
                {
                    articles.Add(article);
                }
            }
            if (txtCuantity3.Text != "")
            {
                Article article = new Article(txtDescription3.Text, double.Parse(txtPrice3.Text));
                for (int i = 0; i < Int32.Parse(txtCuantity3.Text); i++)
                {
                    articles.Add(article);
                }
            }
            if (txtCuantity4.Text != "")
            {
                Article article = new Article(txtDescription4.Text, double.Parse(txtPrice4.Text));
                for (int i = 0; i < Int32.Parse(txtCuantity4.Text); i++)
                {
                    articles.Add(article);
                }
            }
            if (txtCuantity5.Text != "")
            {
                Article article = new Article(txtDescription5.Text, double.Parse(txtPrice5.Text));
                for (int i = 0; i < Int32.Parse(txtCuantity5.Text); i++)
                {
                    articles.Add(article);
                }
            }
            if (txtCuantity6.Text != "")
            {
                Article article = new Article(txtDescription6.Text, double.Parse(txtPrice6.Text));
                for (int i = 0; i < Int32.Parse(txtCuantity6.Text); i++)
                {
                    articles.Add(article);
                }
            }
            if (txtCuantity7.Text != "")
            {
                Article article = new Article(txtDescription7.Text, double.Parse(txtPrice7.Text));
                for (int i = 0; i < Int32.Parse(txtCuantity7.Text); i++)
                {
                    articles.Add(article);
                }
            }
            if (txtCuantity8.Text != "")
            {
                Article article = new Article(txtDescription8.Text, double.Parse(txtPrice8.Text));
                for (int i = 0; i < Int32.Parse(txtCuantity8.Text); i++)
                {
                    articles.Add(article);
                }
            }
            if (txtCuantity9.Text != "")
            {
                Article article = new Article(txtDescription9.Text, double.Parse(txtPrice9.Text));
                for (int i = 0; i < Int32.Parse(txtCuantity9.Text); i++)
                {
                    articles.Add(article);
                }
            }
            return articles;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Bill bill = this.createBill();
            bill.addList(this.addingArticles());
            this.createDaoBill().insert(bill);
            this.updateList();
        }
    }
}
