using System.Collections.Generic;
using Newtonsoft.Json;

namespace Geniy_Idiot_Common
{
    
    public class UserResult
    {
        private static string userResultsPath = "userResults.json";
        public string Name;
        public int CountRightAnswers;
        public string Diagnos;

        public UserResult( string name, int countRightAnswers, string diagnos)
        {
            this.Name = name;
            this.CountRightAnswers = countRightAnswers;
            this.Diagnos = diagnos;
        }

        public  static void CreateFileResultsIfNotExists()
        {
            
            if (!FileProvider.IsExists(userResultsPath))
            {
                var value = JsonConvert.SerializeObject(new List<UserResult>(), Formatting.Indented);
                FileProvider.Add(userResultsPath, value);
            }
        }

        public static void SaveResults(List<UserResult> results)
        {
            var serializedResults = JsonConvert.SerializeObject(results, Formatting.Indented);
            FileProvider.Set(userResultsPath, serializedResults);
        }

        public static List<UserResult> GetResultsFromFile()
        {
            var serializedResults = FileProvider.Get(userResultsPath);
            var results = JsonConvert.DeserializeObject<List<UserResult>>(serializedResults);
            return results;
        }
    }
}
