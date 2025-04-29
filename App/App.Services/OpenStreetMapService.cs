using App.Core.Interfaces;
using App.Core.Models.OpenStreetMap;

namespace App.Services
{
    public class OpenStreetMapService(HttpClient client) : ServiceBase, IPlaceService
    {
        public async Task<List<RawPlace>> Search(string town)
            => await Get<List<RawPlace>>(client, $"https://nominatim.openstreetmap.org/search?q={town}&format=json&addressdetails=1");
    }
}
