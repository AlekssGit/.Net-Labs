using MaskShop.Domain.Contracts;

namespace MaskShop.Domain
{
    public class Mask: ICategoryContainer
    {
        public int id { set; get; }

        public string name { set; get; }

        public string shortDesc { set; get; }

        public string longDesc { set; get; }

        public string image { set; get; }

        public ushort price { set; get; }

        public bool isFavorite { set; get; }

        public bool available { set; get; }
        
        public  Category Category { set; get; }

        int? ICategoryContainer.CategoryId => this.Category.id;
    }
}
