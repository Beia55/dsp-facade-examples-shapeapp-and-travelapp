using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    class TravelFacade
    {
        private FlightBooking _flightBooking;
        private TrainBooking _trainBooking;
        private HotelBooking _hotelBooking;
        private Person _person;
        private BookingInfo _bookingInfoDeia;

        public TravelFacade()
        {
            _flightBooking = new FlightBooking();
            _trainBooking = new TrainBooking();
            _hotelBooking = new HotelBooking();
        }

        public void CreatePerson(string firstName, string lastName, int age, int cnp, string address)
        {
            _person = new Person(firstName, lastName, age, cnp, address);
        }

        public void CreateBookingInfo(double price, string source, string destination, DateTime fromDate, DateTime toDate)
        {
            _bookingInfoDeia = new BookingInfo(700, "Oradea", "Viena", new DateTime(), new DateTime());

        }

        public void BookHotel()
        {
            this._hotelBooking = new HotelBooking(this._person, this._bookingInfoDeia);
            Console.WriteLine(this._hotelBooking.ToString());
        }

        public void BookTrain(TrainTicketType personalTicketType)
        {
            this._trainBooking = new TrainBooking(this._person, this._bookingInfoDeia, personalTicketType);
            Console.WriteLine(this._trainBooking.ToString());
        }

        public void BookFlight(bool discountCoupon, int baggageNo, FlyTicketType personalTicketType)
        {
            this._flightBooking = new FlightBooking(this._person, this._bookingInfoDeia, discountCoupon, baggageNo, personalTicketType);
            Console.WriteLine(this._flightBooking.ToString());
        }

    }
}
