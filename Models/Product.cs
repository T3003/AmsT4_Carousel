﻿namespace AmsT4_Carousel.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        
        public string Description { get; set; }
        
        public string ImageUrl { get; set; }

        public decimal Price { get; set; } 

    }
}
