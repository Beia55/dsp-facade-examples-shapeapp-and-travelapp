using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    public class TrainBooking
    {
        public Person _Person;
        public BookingInfo _BookingInfo;
        public TrainTicketType PersonalTicketType { get; set; }

        public TrainBooking() { }

        public TrainBooking
            (Person person, BookingInfo bookingInfo, TrainTicketType personalTicketType)
        {
            this._Person = person;
            this._BookingInfo = bookingInfo;
            this.PersonalTicketType = personalTicketType;

            this.CalculateCostForPupil();
            this.CalculateCostForStudent();
            this.CalculateCostForTraveler();
            this.CalculateCostForPensioner();
        }

        public override string ToString()
        {
            return this._Person.ShowInfo() + "\n"
                + "Has a reservation from " + this._BookingInfo.Source + " at " + this._BookingInfo.Destination
                + " in " + this._BookingInfo.FromDate + ". "
                + this._BookingInfo.Price + " $ Ticket type: " + this.PersonalTicketType ;
        }

        public double CalculateCostForPupil()
        {
            if(this.PersonalTicketType == TrainTicketType.Pupil)
            {
                this._BookingInfo.Price = 0;
                return this._BookingInfo.Price;
            }

            return this._BookingInfo.Price;
            
        }

        public double CalculateCostForStudent()
        {
            if (this.PersonalTicketType == TrainTicketType.Student)
            {
                this._BookingInfo.Price = this._BookingInfo.Price/2;
                return this._BookingInfo.Price;
            }
            return this._BookingInfo.Price;
        }

        public double CalculateCostForTraveler()
        {
            if (this.PersonalTicketType == TrainTicketType.Traveler)
                return this._BookingInfo.Price;
            return this._BookingInfo.Price;
        }

        public double CalculateCostForPensioner()
        {
            if (this.PersonalTicketType == TrainTicketType.Pensioner)
            {
                this._BookingInfo.Price = this._BookingInfo.Price - (0.3 * this._BookingInfo.Price);
                return this._BookingInfo.Price;
            }
            return this._BookingInfo.Price;

        }
    }
}
