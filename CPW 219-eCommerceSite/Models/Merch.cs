using System.ComponentModel.DataAnnotations;

namespace CPW_219_eCommerceSite.Models
{
    /// <summary>
    /// Represents a single merch item avalible for purchase
    /// </summary>
    public class Merch
    {
        [Key]
       
        public int MerchId { get; set; }

        [Required]
        public string Title { get; set; }

        [Range(0, double.MaxValue)]
        public double Price { get; set; }

        //Todo: Add authentications
    }
}
