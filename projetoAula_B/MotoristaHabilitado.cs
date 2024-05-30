using Newtonsoft.Json;
using ProjetoAPIAula1B;
using projetoAula1B;
namespace projetoAula1B
{
    public class MotoristaHabilitado
    {
        [JsonProperty("penalidades_aplicadas")]
        public List<PenalidadesAplicadas> PenalidadeAplicadas { get; set; }
    }
}

