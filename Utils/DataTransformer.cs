using NewPom.Model;
using Newtonsoft.Json;

namespace NewPom.Utils
{
    public class DataTransformer
    {
        public static string transformJsonToString(string jsonFilePath)
        {
            return File.ReadAllText(jsonFilePath);
        }

        public static Searches transformStringToObject(string jsonString)
        {
            Searches searches;
            searches = JsonConvert.DeserializeObject<Searches>(jsonString);
            return searches;
        }

    }
}