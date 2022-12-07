using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabreraMidterm {
    public partial class MainForm : Form {

        Reservation reservation = new Reservation();

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            LoadBookingType();
            LoadRoomType();

        }

        private void btnCompute_Click(object sender, EventArgs e) {
            reservation.SetNumberOfNightsToStay(int.Parse(txtNumberOfNightsToStay.Text));
            txtReservationPrice.Text = reservation.GetReservationPrice().ToString();
            txtTotalPrice.Text = reservation.GetTotalPrice().ToString();
        }

        private void cmbBookingType_SelectedIndexChanged(object sender, EventArgs e) {
            reservation.SetBookingType(cmbBookingType.Text);
            txtReservationFee.Text = reservation.GetReservationFee().ToString();
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e) {
            reservation.SetRoomType(cmbRoomType.Text);
            txtRoomRatePerNight.Text = reservation.GetRoomRatePerNight().ToString();
        }



        // Data loading methods
        private void LoadBookingType() {
            foreach (string bookingType in Reservation.BookingTypeByReservationFeeMap.Keys) {
                cmbBookingType.Items.Add(bookingType);
            }
        }

        private void LoadRoomType() {
            foreach (string roomType in Reservation.RoomTypeByRatePerNightMap.Keys) {
                cmbRoomType.Items.Add(roomType);
            }
        }
    }
}
