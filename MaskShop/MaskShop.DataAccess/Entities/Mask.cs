using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MaskShop.DataAccess.Entities
{
    public partial class Mask
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { set; get; }
        public string name { set; get; }
        public string shortDesc { set; get; }
        public string longDesc { set; get; }
        public string image { set; get; }
        public ushort price { set; get; }
        public bool isFavorite { set; get; }
        public bool available { set; get; }
        public int? CategoryId { get; set; }

        public virtual Category Category { set; get; }
    }
}
