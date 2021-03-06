﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KEKCore.Entities
{
    [Table("memes")]
    public class MemeEntry
    {
        [Key]
        public int ID { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public int VendorAmount { get; set; }
        public string Subreddit { get; set; }

        public IEnumerable<Message> Messages { get; set; }

        public MemeEntry() { }
    }
}