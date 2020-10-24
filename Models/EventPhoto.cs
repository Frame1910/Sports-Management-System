﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsManagementSystem.Models
{
    public class EventPhoto
    {
        [Key]
        public int PhotoId { get; set; }
        [Required]
        public string Photo { get; set; }
        public string PhotoTags { get; set; }
        // Navigation Properties
        public string EventId { get; set; }
        public Event Event { get; set; }
    }
}