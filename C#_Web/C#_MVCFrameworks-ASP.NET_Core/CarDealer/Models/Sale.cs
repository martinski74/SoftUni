﻿namespace CarDealer.Models
{
    public class Sale
    {
        public int Id { get; set; }

        public double Discount { get; set; }

        public int CarId { get; set; }

        public Car Car { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
