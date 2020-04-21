using MaskShop.Domain.Contracts;
using System.Threading.Tasks;

namespace MaskShop.BLL.Contracts
{
    public interface ICategoryGetService
    {
        Task ValidateAsync(ICategoryContainer categoryContainer);
    }
}
