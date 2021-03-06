﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntertainmentAgency.Models
{
    public class Menu
    {
        public Menu()
        {
            MenuCounts = new List<MenuCount>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required]
        public double Price { get; set; }
        public string About { get; set; }
        public virtual List<MenuCount> MenuCounts { get; set; }
    }
}