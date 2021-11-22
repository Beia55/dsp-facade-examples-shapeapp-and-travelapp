using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    public class FlightBooking
    {
        public Person _Person;
        public BookingInfo _BookingInfo;
        public bool DiscountCoupon { get; set; }
        public int BaggageNo { get; set; }
        public FlyTicketType PersonalTicketType { get; set; }

        public FlightBooking() { }

        public FlightBooking
            (Person person, BookingInfo bookingInfo, bool discountCoupon, int baggageNo, FlyTicketType personalTicketType) 
        {
            this._Person = person;
            this._BookingInfo = bookingInfo;
            this.DiscountCoupon = discountCoupon;
            this.BaggageNo = baggageNo;
            this.PersonalTicketType = personalTicketType;

            this.CalculateCostWithDiscount();
        }

        public override string ToString()
        {
            return this._Person.ShowInfo() + "\n"
                + "Has a reservation to fly from " + this._BookingInfo.Source + " at " + this._BookingInfo.Destination
                + " in " + this._BookingInfo.FromDate + ". \n"
                + this._BookingInfo.Price + " $ ticket type: " + this.PersonalTicketType + ", baggage no. : " + this.BaggageNo
                + ". Discount coupon - "+this.DiscountCoupon;
        }

        public double CalculateCostWithDiscount()
        {
            if (this.DiscountCoupon == true)
            {
                this._BookingInfo.Price = this._BookingInfo.Price - (0.1 * this._BookingInfo.Price);
                return this._BookingInfo.Price;
            }
            return this._BookingInfo.Price;
        }
    }
}
