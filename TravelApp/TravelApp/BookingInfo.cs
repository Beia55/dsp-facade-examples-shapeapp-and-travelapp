using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    public class BookingInfo
    {
        public double  Price { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        
        public BookingInfo(double price, string source, string destination, DateTime fromDate, DateTime toDate) 
        {
            this.Price = price;
            this.Source = source;
            this.Destination = destination;
            this.FromDate = fromDate;
            this.ToDate = toDate;
        }
    }
}
