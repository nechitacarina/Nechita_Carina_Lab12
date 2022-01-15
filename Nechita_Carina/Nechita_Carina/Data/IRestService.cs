using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Nechita_Carina.Models;

namespace Nechita_Carina.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
