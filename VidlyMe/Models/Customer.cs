﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyMe.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public DateTime? Birthday { get; set; }

        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }

    }
}