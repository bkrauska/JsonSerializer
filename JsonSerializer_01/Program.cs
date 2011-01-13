using System;

namespace JsonSerializer_01 {
    class Program {
        static void Main(string[] args) {
            var featureType = new TypeToSerialize() { ChurchID = 15, FeatureID = 1, IsEnabled = true };
            var json = JsonHelper.Serialize<TypeToSerialize>(featureType);
            var deserializedJsonString = JsonHelper.Deserialize<TypeToSerialize>(json);
            Console.WriteLine(json);

            Console.ReadKey();
        }
    }

    public class TypeToSerialize {
        public int ChurchID { get; set; }
        public int FeatureID { get; set; }
        public bool IsEnabled { get; set; }
    }
}
