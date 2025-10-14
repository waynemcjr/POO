using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO2
{
    internal class Endereco
    {
        public int Numero { get; set; }
        public string Rua { get; set; } = String.Empty;
        public string Bairro { get; set; } = String.Empty;
        public string Cep { get; set; } = String.Empty;
        public string? Complemento { get; set; } // "?" pode ser nulo
        public string Cidade { get; set; } = String.Empty;
        public string Estado { get; set; } = String.Empty;
        public string Pais { get; set; } = String.Empty;

        public Endereco(int numero,
            string rua, string bairro,
            string cep, string? complemento,
            string cidade, string estado, 
            string pais)
        {
            this.Numero = numero;
            this.Rua = rua;
            this.Bairro = bairro;
            this.Cep = cep;
            this.Complemento = complemento;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Pais = pais;

            //shit + alt = escrever em varias linhas ao mesmo tempo
        }
    }   
}  