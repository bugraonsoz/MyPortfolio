﻿using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
    public class Testimonial
    {
        [Key]
        public int TestimonialID { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
