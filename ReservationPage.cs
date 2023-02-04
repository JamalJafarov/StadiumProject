using Microsoft.EntityFrameworkCore;
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

namespace StadiumProject
{
    public partial class ReservationPage : Form
    {
        public ReservationPage()
        {
            InitializeComponent();
        }


        Stad st = new Stad();


        private void Reservation_Load(object sender, EventArgs e)
        {
            cmb_stadium.Items.AddRange(st.Stads.Select(x => x.Name).ToArray());
            cmb_Fullname.Items.AddRange(st.Customers.Select(c => c.Name + "|" + c.Surname + "|" + c.PhoneNumber).ToArray());
            cmbRoom.Items.AddRange(st.Rooms.Select(r=>r.RoomNumber).ToArray()); 
            dtgReservation.DataSource = st.Reservations.ToArray();


        }



        private void cmbStadium_SelectedIndexChanged(object sender, EventArgs e)
        {


        }



        //private void btnCreateCustomer_Click(object sender, EventArgs e)
        //{
        //    CustomerCRUD customer = new();
        //    customer.ShowDialog();
        //    cmb_Fullname.Items.Clear();
        //    cmb_Fullname.Items.AddRange(st.Customers.Select(c => c.Name + "|" + c.Surname + "|" + c.PhoneNumber).ToArray());
        //}

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Fullname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Fullname.Text != "")
            {
                string[] oo = cmb_Fullname.Text.Split("|");

                lblName.Text = oo[0];
                lblSurname.Text = oo[1];
                lblPhonenumber.Text = oo[2];
                panel2.Visible = true;
            }


        }




        public void AddStadiumForReservations(int resId, int cusId)
        {
            ReservationToStadium restostad = new ReservationToStadium() { ReservationId = resId, StadiumId = cusId };
            st.ReservationToStadiums.Add(restostad);
            st.SaveChanges();
        }

        public void AddRoomForReservations(int resId)
        {
            foreach (var rm in ckRoomList.Items)
            {

                Room selectedroom = st.Rooms.FirstOrDefault(c => c.RoomNumber == rm);
                int roomId;
                if (selectedroom == null)
                {
                    Room room = new()
                    {
                        RoomNumber = rm.ToString(),
                        Capacity=nmPlayersCount.Value.ToString()
                    };
                    st.Rooms.Add(room);
                    st.SaveChanges();
                    roomId = room.Id;

                }
                else
                {
                    roomId = selectedroom.Id;
                }

                ReservationToRoom restorm = new ReservationToRoom() { ReservationId = resId, RoomId = roomId };
                st.ReservationToRooms.Add(restorm);
                st.SaveChanges();
            }


        }

        public void AddCustomerForReservations(int resId, int cusId)
        {
            ReservationToCustomer restocus = new ReservationToCustomer() { ReservationId = resId, CustomerId = cusId };
            st.ReservationToCustomers.Add(restocus);
            st.SaveChanges();
        }

        public int GetIdForStadium(string name)
        {
            Stadium selectedstadium = st.Stads.FirstOrDefault(f => f.Name == name);
            if (selectedstadium != null)
            {
                return selectedstadium.Id;
            }
            else
            {
                Stadium std = new();
                st.Stads.Add(std);
                st.SaveChanges();


                return std.Id;

            }
        }

        public int GetIdForCustomer(string name)
        {
            Customer selectedcustomer = st.Customers.FirstOrDefault(f => f.Name == name);
            if (selectedcustomer != null)
            {
                return selectedcustomer.Id;
            }
            else
            {
                Customer cst = new();
                st.Customers.Add(cst);
                st.SaveChanges();


                return cst.Id;

            }
        }

        public int GetIdForRoom(string name)
        {
            Room selectedroom = st.Rooms.FirstOrDefault(f => f.RoomNumber == name);
            if (selectedroom != null)
            {
                return selectedroom.Id;
            }
            else
            {
                Room rm = new();
                st.Rooms.Add(rm);
                st.SaveChanges();

                return rm.Id;

            }
        }


         


        private void btn_Add_Click(object sender, EventArgs e)
        {

            string name = lblName.Text;
            string surname = lblSurname.Text;
            string phonenumber = lblPhonenumber.Text;
            DateTime gametime = dtDate.Value;
            string time = cmbTime.Text;
            string stadium = cmb_stadium.Text;
            string room = cmbRoom.Text;
            int playerCount=(int)nmPlayersCount.Value;
            int StadiumId = GetIdForStadium(stadium);
            int CustomerId = GetIdForCustomer(name);
            int RoomId=GetIdForRoom(room);



            int numberOfRooms =1;
            if (cmb_Fullname != null && cmbTime!=null && cmbTime!=null && playerCount!=0 )
            {

                Reservation reserv = new()
                {
                    GameDate = gametime,
                    Time = time,

                };


                st.Reservations.Add(reserv);
                st.SaveChanges();
                dtgReservation.DataSource = st.Reservations.ToList();
                AddStadiumForReservations(reserv.Id, StadiumId);
                AddCustomerForReservations(reserv.Id, CustomerId);
                AddRoomForReservations(reserv.Id);
                Success sc = new Success();
                sc.ShowDialog();
                panel2.Visible = false;
            }
            else
            {
                MessageBox.Show("Fill the blanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerCRUD cstmr= new CustomerCRUD();
            cstmr.ShowDialog();
        }

        private void cmbRoom_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string roomName = cmbRoom.Text;
                bool isCorrect = false;
                foreach (string rm in ckRoomList.Items)
                {
                    if (rm.ToLower().Equals(roomName.ToLower()))
                    {
                        isCorrect = true;
                    }
                if(!isCorrect){
                        ckRoomList.Items.Add(roomName);
                        cmbRoom.Text = "";
                    }

                }
            }
        }

        private void ckRoomList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;
            int index = clb.SelectedIndex;

            if (index != -1 && clb.GetItemCheckState(index) == CheckState.Checked)
            {
                clb.Items.RemoveAt(index);
            }
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string roomname = cmbRoom.Text;
            if (!ckRoomList.Items.Contains(roomname))
            {
                ckRoomList.Items.Add(roomname, true);
            }
        }

        private void nmPlayersCount_ValueChanged(object sender, EventArgs e)
        {
            if (nmPlayersCount.Value > 12)
            {
                nmPlayersCount.Visible = true;
            }
        }
    }
}
