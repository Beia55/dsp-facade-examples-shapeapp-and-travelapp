using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    public class HotelBooking
    {
        public Person _Person;
        public BookingInfo _BookingInfo;

        public HotelBooking() { }

        public HotelBooking
            (Person person, BookingInfo bookingInfo)
        {
            this._Person = person;
            this._BookingInfo = bookingInfo;
        }

        public override string ToString()
        {
            return this._Person.ShowInfo() + "\n"
                + "Has a reservation from " + this._BookingInfo.FromDate + " to " + this._BookingInfo.ToDate
                + ". Price - "+ this._BookingInfo.Price;
        }

    }
}