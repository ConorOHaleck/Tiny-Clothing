using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tiny_Clothing.Models
{
    /// <summary>
    /// Represents a discrete saleable item in the store.
    /// </summary>
    public class Item
    {
        [Key] // Set as PK
        public int ItemID { get; set; }
        /// <summary>
        /// The size of the item, XXS/XS/S/M/L/XL/XXL/3XL/4XL
        /// </summary>
        public string Size { get; set; }
        /// <summary>
        /// What type of animal/what article of clothing it is; e.g: Dog Hat, Cat Cape, etc.
        /// </summary>
        public string Type { get; set; }
        public string Color { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
