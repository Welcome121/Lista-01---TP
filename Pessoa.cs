using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaUm
{
    public abstract class Pessoa
    {
        public string nome;
        public string CPF;
        public bool isAlive;
        protected DateTime DataNascimento;
        protected private DateTime DataFalecimento;

        public string getDataFalecimento()
        {
            string message;

            if (isAlive) message = nome + " esta vivo";
            else message = nome + " faleceu na data: " + DataFalecimento.ToString();

            return message;
        }

        protected void SetDataFalecimento(DateTime value) { DataFalecimento = value; }
    }
}
