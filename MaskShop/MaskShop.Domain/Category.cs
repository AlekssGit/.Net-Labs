namespace MaskShop.Domain
{
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string description { set; get; }
        public Category ParentId { get; set; }
    }
}
