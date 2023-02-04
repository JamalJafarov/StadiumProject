using Microsoft.Win32;
using StadiumProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace StadiumProject
{
    public partial class StadiumCRUD : Form
    {
       
        public StadiumCRUD()
        {
            InitializeComponent();
        }

        private void StadiumCRUD_Load(object sender, EventArgs e)
        {
            dtgStadium.DataSource = st.Stads.ToList();
        }

        Stad st = new Stad();



        void ClearData()
        {
            txtStadiumName.Text = string.Empty;
            nmPrice.Text = string.Empty;
        }

        public int StadiumId;
        private void dtgStadium_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dtgStadium.CurrentCell.RowIndex != -1)
                {
                    StadiumId = Convert.ToInt32(dtgStadium.Rows[e.RowIndex].Cells[0].Value);
                    Stadium std = st.Stads.Find(StadiumId);

                    txtStadiumName.Text = std.Name.ToString();
                    nmPrice.Text = std.Price.ToString();


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = txtStadiumName.Text;
                decimal price = (decimal)nmPrice.Value;

                var result = st.Stads.FirstOrDefault(x => x.Name == txtStadiumName.Text);
                if (result == null )
                {
                    if (!string.IsNullOrWhiteSpace(name) && price != 0)
                    {
                        Stadium newStadium = new()
                        {
                            Name = name,
                            Price = price


                        };
                        st.Stads.Add(newStadium);
                        st.SaveChanges();
                        dtgStadium.DataSource = st.Stads.ToList();

                        Success sc = new Success();
                        sc.ShowDialog();
                        ClearData();
                    }
                    else
                    {
                        MessageBox.Show("Fill the blanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("User Alreay Exist. Try with Different Username","Duplication of Data", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                

            }
            catch (Exception)
            {

                MessageBox.Show("Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

            string name = txtStadiumName.Text;
            decimal price = (decimal)nmPrice.Value;


            if (!string.IsNullOrWhiteSpace(name) && price != null && dtgStadium.CurrentCell.RowIndex != -1)
            {


                Stadium stadium = st.Stads.Find(StadiumId);
                stadium.Name = name;
                stadium.Price = price;

                st.Update<Stadium>(stadium);
                st.SaveChanges();
                dtgStadium.DataSource = st.Stads.ToList();
                Success sc = new Success();
                sc.ShowDialog();
                ClearData();

            }
            else
            {
                MessageBox.Show("Select a Stadium to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtStadiumName.Text;
                decimal price = (decimal)nmPrice.Value;


                if (!string.IsNullOrWhiteSpace(name) && price != null && dtgStadium.CurrentCell.RowIndex != -1)
                {


                    Stadium stadium = st.Stads.Find(StadiumId);
                    stadium.Name = name;
                    stadium.Price = price;

                    st.Remove<Stadium>(stadium);
                    st.SaveChanges();
                    dtgStadium.DataSource = st.Stads.ToList();
                    Success sc = new Success();
                    sc.ShowDialog();
                    ClearData();

                }
                else
                {
                    MessageBox.Show("Select a Stadium.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
                var items = st.Stads.Where(m => m.Name.Contains(textBox1.Text));
                dtgStadium.DataSource = items.ToList();
            }
            else
            {
                dtgStadium.DataSource = st.Stads.ToList();
            }
        }

        private void txtStadiumName_TextChanged(object sender, EventArgs e)
        {



        }
    }
}

