﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyMe.Models
{
    public class Genre
    {
        public int GenreId { get; set; }

        [Required]
        [StringLength(255)]
        public string GenreName { get; set; }
    }
}