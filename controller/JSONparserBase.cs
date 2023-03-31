using mentoring_system.model;
using System.Text.Json;

namespace mentoring_system.controller
{
    public class JSONparserBase
    {
        public void WriteJSON(User Data)
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
            File.WriteAllText("C:\\Users\\glori\\OneDrive\\Desktop\\things to do\\dev\\mentoring-system\\JSON\\data.json", jsonString);
        }
    }
}