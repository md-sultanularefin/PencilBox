using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMECommerce.Models.EntityModels
{
    [Table("Products")]

    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime ManufactureDate { get; set; }

        public double Price { get; set; }

        public Category Category { get; set; }

        public int? CategoryId { get; set; }

        public Brand Brand { get; set; }

        public int? BrandId { get; set; }
    }

}
