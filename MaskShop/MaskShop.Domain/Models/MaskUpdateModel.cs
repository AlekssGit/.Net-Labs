using MaskShop.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaskShop.Domain.Models
{
    public class MaskUpdateModel : IMaskIdentity, ICategoryContainer
    {
        public int Id => throw new NotImplementedException();

        public int? CategoryId => throw new NotImplementedException();
    }
}
