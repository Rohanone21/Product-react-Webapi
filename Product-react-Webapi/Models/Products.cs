using System.ComponentModel.DataAnnotations;

namespace Product_react_Webapi.Models
{
    public class Products
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
    }
}
