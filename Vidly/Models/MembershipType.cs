﻿using System.ComponentModel.DataAnnotations;
namespace Vidly.Models
{
    public class MembershipType
    {
        [Key]
        public int MembershipId { get; set; }

        public string MembershipName { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}