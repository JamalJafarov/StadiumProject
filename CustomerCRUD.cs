using StadiumProject.Models1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StadiumProject
{
    public partial class CustomerCRUD : Form
    {
        StadiumDbContext st=new();
        public int CustomerId;
        public CustomerCRUD()
        {
            InitializeComponent();
        }

        private void CustomerCRUD_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                pbExit.Visible = true;
            }
            dtgCustomer.DataSource = st.Customers.ToList();
        }


        void ClearData()
        {
            txtCustomerName.Text = txtcustomerPhonenumber.Text = txtcustomerSurname.Text =string.Empty;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtCustomerName.Text;
                string surname=txtcustomerSurname.Text;
                string phonenumber = txtcustomerPhonenumber.Text;


                if (!string.IsNullOrWhiteSpace(name) &&  !string.IsNullOrWhiteSpace(surname) && !string.IsNullOrEmpty(phonenumber))
                {
                    Customer newCustomer = new()
                    {
                        
                        Name = name,
                        Surname = surname,
                        PhoneNumber= phonenumber,


                    };
                    st.Customers.Add(newCustomer);
                    st.SaveChanges();
                    dtgCustomer.DataSource = st.Customers.ToList();

                    Success sc = new Success();
                    sc.ShowDialog();
                    
                    
                }
                else
                {
                    MessageBox.Show("Fill the blanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                if (dtgCustomer.CurrentCell.RowIndex != -1)
                {
                    CustomerId = Convert.ToInt32(dtgCustomer.Rows[e.RowIndex].Cells[0].Value);
                    Customer cus = st.Customers.Find(CustomerId);

                    txtCustomerName.Text = cus.Name.ToString();
                    txtcustomerSurname.Text = cus.Surname.ToString();
                    txtcustomerPhonenumber.Text = cus.PhoneNumber.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtCustomerName.Text;
                string surname = txtcustomerSurname.Text;
                string phonenumber = txtcustomerPhonenumber.Text;

                Customer customer = st.Customers.Find(CustomerId);
                customer.Name = name;
                customer.Surname = surname;
                customer.PhoneNumber = phonenumber;

                st.Update<Customer>(customer);
                st.SaveChanges();
                dtgCustomer.DataSource = st.Customers.ToList();
                Success sc = new Success();
                sc.ShowDialog();
                ClearData();

            }
            catch (Exception)
            {

                MessageBox.Show("Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtCustomerName.Text;
                string surname = txtcustomerSurname.Text;
                string phonenumber = txtcustomerPhonenumber.Text;

                Customer customer = st.Customers.Find(CustomerId);
                customer.Name = name;
                customer.Surname = surname;
                customer.PhoneNumber = phonenumber;

                st.Remove<Customer>(customer);

                st.SaveChanges();
                dtgCustomer.DataSource = st.Customers.ToList();
                Success sc = new Success();
                sc.ShowDialog();
                ClearData();



            }
            catch (Exception)
            {

                MessageBox.Show("Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                var items = st.Customers.Where(m => m.Name.Contains(textBox1.Text));
                dtgCustomer.DataSource = items.ToList();
            }
            else
            {
                dtgCustomer.DataSource = st.Customers.ToList();
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
