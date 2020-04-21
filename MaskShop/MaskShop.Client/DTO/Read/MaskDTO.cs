namespace MaskShop.Client.DTO.Read
{
    public class MaskDTO
    {
        public int id { set; get; }

        public string name { set; get; }

        public string shortDesc { set; get; }

        public string longDesc { set; get; }

        public string image { set; get; }

        public ushort price { set; get; }

        public bool isFavorite { set; get; }

        public bool available { set; get; }

        public CategoryDTO Category { set; get; }

    }
}
