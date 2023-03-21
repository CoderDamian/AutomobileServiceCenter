using System.Text.Json;

namespace ASC.Utilities
{
    public static class ObjectExtensions
    {
        public static T CopyObject<T>(this object objSource)
        {
            var serialized = JsonSerializer.Serialize(objSource);  // JsonConvert.SerializeObject(objSource);
            return JsonSerializer.Deserialize<T>(serialized); // JsonConvert.DeserializeObject<T>(serialized);
        }
    }
}