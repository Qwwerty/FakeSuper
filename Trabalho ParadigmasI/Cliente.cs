using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_ParadigmasI
{
    class Cliente
    {
        //nome, n´umero do cart˜ao de cidad˜ao, NIF, morada, telefone, email
        private string nome;
        private string numero_cartao_cidadao;
        private string nif;
        private string morada;
        private string telefone;
        private string email;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Numero_Cartao_Cidadao
        {
            get { return numero_cartao_cidadao; }
            set { numero_cartao_cidadao = value; }
        }

        public string NIF
        {
            get { return nif; }
            set { nif = value; }
        }

        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Cliente(string nome,string numero_cartao_cidadao,string nif,string morada,string telefone,string email)
        {
            this.nome = nome;
            this.numero_cartao_cidadao = numero_cartao_cidadao;
            this.nif = nif;
            this.morada = morada;
            this.telefone = telefone;
            this.email = email;
        }
    }
}
