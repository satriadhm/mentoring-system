using mentoring_system.model;
using System.Text.Json;

namespace mentoring_system.controller
{
    public class JSONparserBase
    {
        public void WriteJSON(User Data, string roleName)
        {
            //[Opsional] Merapikan format JSON
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            //Melakukan perubahan object menjadi string(Serialization)
            String jsonString = JsonSerializer.Serialize(Data,options);
            Console.WriteLine(jsonString);
            //Membuat file JSON yg berisi string hasil serialization
            File.WriteAllText("../../../JSON/data"+roleName+".json", jsonString);
        }

        public void ReadJSON(User? Data, string roleName) 
        {
            //Baca file Json yang diinginkan
            String jsonString = File.ReadAllText("\"../../../JSON/data" + roleName+".json");
            //Deserialize file json menjadi object
            Data = JsonSerializer.Deserialize<User>(jsonString);
        }
    }
}