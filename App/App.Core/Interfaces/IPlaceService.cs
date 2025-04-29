using App.Core.Models.OpenStreetMap;

namespace App.Core.Interfaces
{
    public interface IPlaceService
    {
        Task<List<RawPlace>> Search(string town);
    }
}
