using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ProjetoAPIAula1B;
using projetoAula1B;

namespace projetoAula_B
{
    public class ReadFile
    {
        public static List<PenalidadesAplicadas> GetData(string path)
        {
            StreamReader reader = new StreamReader(path);
            string jsonString = reader.ReadToEnd();

            var objGeral = JsonConvert.DeserializeObject<MotoristaHabilitado>(jsonString, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            if (objGeral != null) return objGeral.PenalidadeAplicadas;
            return null;
        }
    }
}