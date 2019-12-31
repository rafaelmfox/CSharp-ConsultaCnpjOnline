using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCnpjOnline
{
    class Empresa
    {

        public string complemento { get; set; }
        public string nome { get; set; }
        public string uf { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string situacao { get; set; }
        public string bairro { get; set; }
        public string logadouro { get; set; }
        public string numero { get; set; }
        public string cep { get; set; }
        public string municipio { get; set; }
        public string porte { get; set; }
        public string naturezaJuridica { get; set; }
        public string fantasia { get; set; }
        public string cnpj { get; set; }
        public string status { get; set; }
        public string tipo { get; set; }



        public Empresa(){}
        public Empresa(string complemento, string nome, string uf, string telefone, string email, string situacao, string bairro, string logadouro, string numero, string cep, string municipio, string porte, string naturezaJuridica, string fantasia, string cnpj, string status, string tipo)
        {

            this.complemento = complemento;
            this.nome = nome;
            this.uf = uf;
            this.telefone = telefone;
            this.email = email;
            this.situacao = situacao;
            this.bairro = bairro;
            this.logadouro = logadouro;
            this.numero = numero;
            this.cep = cep;
            this.municipio = municipio;
            this.porte = porte;
            this.naturezaJuridica = naturezaJuridica;
            this.fantasia = fantasia;
            this.cnpj = cnpj;
            this.status = status;
            this.tipo = tipo;


        }


 







    }
}
