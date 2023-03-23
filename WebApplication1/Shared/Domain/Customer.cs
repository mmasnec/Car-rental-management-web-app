using System.Collections.Generic;


namespace WebApplication1.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string TaxId { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAdress { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }
}