using MaskShop.Domain.Contracts;

namespace MaskShop.Domain.Models
{
    public class MaskIdentityModel : IMaskIdentity
    {
        public int Id { get; }

        public MaskIdentityModel (int id)
        {
            this.Id = id;
        }
    }
}
