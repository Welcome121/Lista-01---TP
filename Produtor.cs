using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaUm
{
    public class Produtor : Pessoa
    {
        private string nomeProdutora;

        public string GetnomeProdutora() { return nomeProdutora; }

        private void SetnomeProdutora(string value) { nomeProdutora = value; }

        public List<string> generosMusicais;
        public List<Album> albuns;

        public Produtor(string nome, string CPF, bool isAlive, DateTime DataNascimento, DateTime DataFalecimento, string nomeProdutora)
        {
            base.nome = nome;
            base.CPF = CPF;
            base.isAlive = isAlive;
            base.DataNascimento = DataNascimento;
            base.DataFalecimento = DataFalecimento;
            this.SetnomeProdutora(nomeProdutora);
            generosMusicais = new List<string>();
            albuns = new List<Album>();
        }

        public void AddGeneroMusical(string nome)
        {
            nome = nome.Replace(" ", String.Empty);

            if (!generosMusicais.Contains(nome.ToLower()))
            {
                generosMusicais.Add(nome);
                Console.WriteLine("Genero musical adicionado!");
            }
            else { Console.WriteLine("Genero musical jah existente"); }
        }

        public void AddAlbum(Album album)
        {
            albuns.Add(album);
        }
    }
}
