using System;
using System.Threading.Tasks;

using Windows.Storage;

namespace PyxisControls.Extensions
{
    public static class StorageFolderExtensions
    {
        public static async Task<bool> FileExistsAsync(this StorageFolder obj, string filename)
        {
            var item = await obj.TryGetItemAsync(filename);
            return item != null && item.IsOfType(StorageItemTypes.File);
        }
    }
}