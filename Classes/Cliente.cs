using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana08.Classes
{
    internal class Cliente
    {
        private string nome;
        private string cpf;
        public string email;
        public string profissao;
        public string telefone;
        Endereco endereco;

        // Propriedades públicas para acessar e modificar os atributos privados
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        // Construtor
        public Cliente(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }
        // Construtor que exige as informações
        public string ObterDescricao()
        {
            return $"Nome do Cliente: {nome}, CPF: {cpf}";
        }
    }
}
