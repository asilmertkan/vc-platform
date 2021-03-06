using System.Collections.Generic;
using System.Threading.Tasks;

namespace VirtoCommerce.Platform.Core.Assets
{
    public interface IAssetEntryService
    {
        Task<IEnumerable<AssetEntry>> GetByIdsAsync(IEnumerable<string> ids);
        Task SaveChangesAsync (IEnumerable<AssetEntry> items);
        Task DeleteAsync (IEnumerable<string> ids);
    }
}
