using System.ComponentModel.DataAnnotations;


namespace MaskShop.Client.Requests.Create
{
   public class MaskCreateDTO
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Short description is required")]
        public string shortDesc { get; set; }

        public int? CategoryId { get; set; }
    }
}
