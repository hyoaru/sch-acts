using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabreraMidterm {
    class Reservation {

        // Input fields
        private string bookingType;
        private string roomType;
        private int numberOfNightsToStay;

        // Output fields
        private int reservationFee;
        private int roomRatePerNight;
        private double reservationPrice;
        private double totalPrice;

        // Other properties
        public static Dictionary<string, int> RoomTypeByRatePerNightMap = new Dictionary<string, int>() {
            { "Single", 1000}, {"Double", 2000}, {"Studio", 5000},
            { "Deluxe", 10000}, {"Suite", 15000}
        };

        public static Dictionary<string, int> BookingTypeByReservationFeeMap = new Dictionary<string, int>() {
            {"Direct", 100}, {"Indirect", 300 }
        };


        // Constructor
        public Reservation() { }

        // Methods

        //Compute methods
        private void ComputeReservationFee() {
            reservationFee = BookingTypeByReservationFeeMap[bookingType];
        }

        private void ComputeRoomRatePerNight() {
            roomRatePerNight = RoomTypeByRatePerNightMap[roomType];
        }

        private void ComputeReservationPrice() {
            ComputeRoomRatePerNight();
            reservationPrice = numberOfNightsToStay * roomRatePerNight;
        }

        private void ComputeTotalPrice() {
            ComputeReservationFee();
            ComputeReservationPrice();
            totalPrice = reservationPrice + reservationFee;
        }


        // Setters
        public void SetBookingType(string bookingType) {
            this.bookingType = bookingType;
        }

        public void SetRoomType(string roomType) {
            this.roomType = roomType;
        }

        public void SetNumberOfNightsToStay(int numberOfNightsToStay) {
            this.numberOfNightsToStay = numberOfNightsToStay;
        }

        // Getters
        public int GetReservationFee() {
            ComputeReservationFee();
            return reservationFee;
        }

        public int GetRoomRatePerNight() {
            ComputeRoomRatePerNight();
            return roomRatePerNight;
        }

        public double GetReservationPrice() {
            ComputeReservationPrice();
            return reservationPrice;
        }

        public double GetTotalPrice() {
            ComputeTotalPrice();
            return totalPrice;
        }

    }
}
