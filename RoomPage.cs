using StadiumProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StadiumProject
{
    public partial class RoomPage : Form
    {
        public int RoomId;
        Stad st = new();
        public RoomPage()
        {
            InitializeComponent();
        }

        private void RoomPage_Load(object sender, EventArgs e)
        {
            dtgRoom.DataSource=st.Rooms.ToList();
        }

        void ClearData()
        {
            txtRoomName.Text = string.Empty;
            nmCapacity.Text = string.Empty;
        }

        private void dtgRoom_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dtgRoom.CurrentCell.RowIndex != -1)
                {
                    RoomId = Convert.ToInt32(dtgRoom.Rows[e.RowIndex].Cells[0].Value);
                    Room rm = st.Rooms.Find(RoomId);

                    txtRoomName.Text = rm.RoomNumber.ToString();
                    nmCapacity.Text = rm.Capacity.ToString();


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtRoomName.Text;
            string capacity = nmCapacity.Value.ToString();
            try
            {

                var result = st.Rooms.FirstOrDefault(x => x.RoomNumber == txtRoomName.Text);
                if (result == null)
                {
                    if (!string.IsNullOrWhiteSpace(name) && capacity!= string.Empty)
                    {
                        Room newRoom = new()
                        {
                            RoomNumber = name,
                            Capacity = capacity


                        };
                        st.Rooms.Add(newRoom);
                        st.SaveChanges();
                        dtgRoom.DataSource = st.Rooms.ToList();

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
                    MessageBox.Show("Room Alreay Exist. Try with Different Room Name", "Duplication of Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtRoomName.Text;
            string capacity = nmCapacity.Value.ToString();

            if (!string.IsNullOrWhiteSpace(name) && capacity != string.Empty && dtgRoom.CurrentCell.RowIndex != -1)
            {


                Room room = st.Rooms.Find(RoomId);
                room.RoomNumber = name;
                room.Capacity = capacity;

                st.Update<Room>(room);
                st.SaveChanges();
                dtgRoom.DataSource = st.Rooms.ToList();
                Success sc = new Success();
                sc.ShowDialog();
                ClearData();

            }
            else
            {
                MessageBox.Show("Select a Room to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtRoomName.Text;
            string capacity = nmCapacity.Value.ToString();
            if (!string.IsNullOrWhiteSpace(name) && capacity != string.Empty && dtgRoom.CurrentCell.RowIndex != -1)
            {


                Room room = st.Rooms.Find(RoomId);
                room.RoomNumber = name;
                room.Capacity = capacity;

                st.Remove<Room>(room);
                st.SaveChanges();
                dtgRoom.DataSource = st.Rooms.ToList();
                Success sc = new Success();
                sc.ShowDialog();
                ClearData();

            }
            else
            {
                MessageBox.Show("Select a Room to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != string.Empty)
            {
                var items = st.Rooms.Where(m => m.RoomNumber.Contains(txtSearch.Text));
                dtgRoom.DataSource = items.ToList();
            }
            else
            {
                dtgRoom.DataSource = st.Rooms.ToList();
            }

        }
    }
}
