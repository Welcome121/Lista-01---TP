using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaUm
{
    public class Artista : Pessoa
    {
        private string generoMusical;

        public string GetgeneroMusical() { return generoMusical; }

        private void SetgeneroMusical(string value) { generoMusical = value; }

        public List<Album> albuns;

        public Artista(string nome, string CPF, bool isAlive, DateTime DataNascimento, DateTime DataFalecimento, string generoMusical)
        {
            base.nome = nome;
            base.CPF = CPF;
            base.isAlive = isAlive;
            base.DataNascimento = DataNascimento;
            base.SetDataFalecimento(DataFalecimento);
            this.SetgeneroMusical(generoMusical);
            albuns = new List<Album>();
        }

        public void AddAlbum(Album album)
        {
            albuns.Add(album);
        }
    }
}
