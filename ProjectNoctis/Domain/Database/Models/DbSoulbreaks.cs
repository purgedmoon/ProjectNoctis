﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectNoctis.Domain.Database.Models
{
    public class DbSoulbreaks
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Realm { get; set; }
        public string Character { get; set; }
        public string Tier { get; set; }
        public string Type { get; set; }
        public string Element { get; set; }
        public string Effects { get; set; }
        public string Points { get; set; }
        public string SoulbreakBonus { get; set; }
        public string Multiplier { get; set; }
        public string Formula { get; set; }
        public string Target { get; set; }
        public string Relic { get; set; }
        public string JPName { get; set; }
        public string SoulbreakId { get; set; }
        public string Anima { get; set; }
        
    }
}