using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        public DateTime BirthDate { get; set; }
        public MembershipType membershipType { get; set; }
        public int MembershipId { get; set; }
    }
}