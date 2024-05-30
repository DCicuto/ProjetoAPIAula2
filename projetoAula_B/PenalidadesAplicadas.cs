using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProjetoAPIAula1B
{
    public class PenalidadesAplicadas
    {
        [JsonProperty("razao_social")]
        public string RazaoSocial { get; set; }
        [JsonProperty("cnpj")]
        public string CNPJ { get; set; }
        [JsonProperty("nome_motorista")]
        public string NomeMotorista { get; set; }
        [JsonProperty("cpf")]
        public string CPF { get; set; }
        [JsonProperty("vigencia_do_cadastro")]
        public DateTime VigenciaCadastro { get; set; }
        public override string ToString() => $"Razão Social: {RazaoSocial}, CNPJ: {CNPJ}, Nome do Motorista: {NomeMotorista}, CPF: {CPF}, Vigência do Cadastro: {VigenciaCadastro}";
    }
}
