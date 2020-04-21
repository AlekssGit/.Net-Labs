using MaskShop.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MaskShop.DataAccess.Entities
{
    public partial class Category
    {
        public Category()
        {
            
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }
        public int? parentId { get; set; }

        public virtual Category Parent { get; set; }
        public virtual ICollection<Mask> Mask { get; set; }
        public virtual ICollection<Category> InverseParent { get; set; }
    }
}
