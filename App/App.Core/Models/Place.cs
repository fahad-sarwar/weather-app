using App.Core.Models.OpenStreetMap;

namespace App.Core.Models
{
    public class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Location Location { get; set; }

        public static Place From(RawPlace rawPlace)
        {
            return new Place
            {
                Id = rawPlace.PlaceId,
                Name = rawPlace.Name,
                Description = rawPlace.DisplayName,
                Location = new Location
                {
                    Latitude = rawPlace.Latitude,
                    Longitude = rawPlace.Longitude
                }
            };
        }
    }
}
