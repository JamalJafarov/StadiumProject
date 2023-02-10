using Microsoft.EntityFrameworkCore;
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
    public partial class ReservationPage : Form
    {
        public ReservationPage()
        {
            InitializeComponent();
        }


        StadiumDbContext st = new ();
        public int ReservationId;

        private void Reservation_Load(object sender, EventArgs e)
        {
            cmb_stadium.Items.AddRange(st.Stads.Select(x => x.Name).ToArray());
            cmb_Fullname.Items.AddRange(st.Customers.Select(c => c.Name + "|" + c.Surname + "|" + c.PhoneNumber).ToArray());
            cmbRoom.Items.AddRange(st.Rooms.Select(r=>r.RoomNumber).ToArray()); 
            //dtgReservation.DataSource = st.Reservations.ToArray();


        }



        private void cmbStadium_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

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



        public int GetIdForStadium(string name)
        {
            Stad selectedstadium = st.Stads.FirstOrDefault(f => f.Name == name);
            if (selectedstadium != null)
            {
                return selectedstadium.Id;
            }
            else
            {
                Stad std = new();
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
            DateTime gameDate = dtDate.Value;

            string stadium = cmb_stadium.Text;
            string room = cmbRoom.Text;
            int playerCount=(int)nmPlayersCount.Value;




            int numberOfRooms =1;
            if (cmb_Fullname != null && playerCount!=0 &&cmb_stadium!=null)
            {


                int StadiumId = GetIdForStadium(stadium);
                int CustomerId = GetIdForCustomer(name);
                int RoomId = GetIdForRoom(room);



                Reservation reservationDate = st.Reservations.FirstOrDefault(c => c.GameDate == gameDate);
                if (reservationDate!=null || gameDate<DateTime.Now)
                {
                    MessageBox.Show("Select valid date.", "Date Time Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    Reservation reserv = new()
                    {
                        GameDate = gameDate,
                        CustomerId=CustomerId,
                        StadiumId=StadiumId,
                        
                    };



                    st.Reservations.Add(reserv);
                    st.SaveChanges();

                    dtgReservation.Rows.Add(reserv.Id,lblName.Text,cmb_stadium.Text,cmbRoom.Text,lblPrice.Text);

                    //dtgReservation.DataSource = st.Reservations.ToList();

                    AddRoomForReservations(reserv.Id);

                    Success sc = new Success();
                    sc.ShowDialog();
                    panel2.Visible = false;
                }

                
            }
            else
            {
                MessageBox.Show("Fill the blanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerCRUD cstmr= new CustomerCRUD();
            cstmr.WindowState = FormWindowState.Normal;
            cstmr.ShowDialog();
            

            cmb_Fullname.Items.Clear();
            cmb_Fullname.Items.AddRange(st.Customers.Select(c => c.Name + "|" + c.Surname + "|" + c.PhoneNumber).ToArray());
            

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
        
        private void pbExit_Click(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Maximized)
            {
                this.Visible = true;
            }
            
            this.Close();
        }

        private void cmb_stadium_SelectedIndexChanged(object sender, EventArgs e)
        {
            string stadium = cmb_stadium.Text;
            int StadiumId = GetIdForStadium(stadium);
            Stad selectedstadium = st.Stads.FirstOrDefault(c => c.Id == StadiumId);
            lblPrice.Text = selectedstadium.Price+" AZN".ToString();
            lblPrice.Visible = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {

                string name = lblName.Text;
                string surname = lblSurname.Text;
                string phonenumber = lblPhonenumber.Text;
                DateTime gameDate = dtDate.Value;

                string stadium = cmb_stadium.Text;
                string room = cmbRoom.Text;
                int playerCount = (int)nmPlayersCount.Value;

                Reservation rsrv = st.Reservations.Find(ReservationId);


                st.Remove<Reservation>(rsrv);
                st.SaveChanges();
                dtgReservation.DataSource = st.Reservations.ToList();
                Success sc = new Success();
                sc.ShowDialog();



            }
            catch (Exception)
            {

                MessageBox.Show("Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtgReservation_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dtgReservation.CurrentCell.RowIndex != -1)
                {
                    ReservationId = Convert.ToInt32(dtgReservation.Rows[e.RowIndex].Cells[0].Value);
                    Reservation res = st.Reservations.Find(ReservationId);


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string name = lblName.Text;
                string surname = lblSurname.Text;
                string phonenumber = lblPhonenumber.Text;
                DateTime gameDate = dtDate.Value;

                string stadium = cmb_stadium.Text;
                string room = cmbRoom.Text;
                int playerCount = (int)nmPlayersCount.Value;


                if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname) && !string.IsNullOrEmpty(phonenumber) 
                    && gameDate!=null && !string.IsNullOrWhiteSpace(stadium) && !string.IsNullOrWhiteSpace(room) &&playerCount!=0 &&
                    dtgReservation.CurrentCell.RowIndex != -1)
                {


                    Reservation rsrv = st.Reservations.Find(ReservationId);
                    rsrv.GameDate = gameDate;


                    st.Update<Reservation>(rsrv);
                    st.SaveChanges();
                    dtgReservation.DataSource = st.Reservations.ToList();
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
    }
}
