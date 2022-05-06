using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaUm
{
    public class Album
    {
        public string nome;
        public string generoMusical;
        public DateTime dataLancamento;
        public string capa;
        public Artista artista;
        public Produtor produtor;
        public List<Musica> musicas;

        public Album(string nome, string generoMusical, DateTime dataLancamento, string capa, Artista artista, Produtor produtor)
        {
            this.nome = nome;
            this.generoMusical = generoMusical;
            this.dataLancamento = dataLancamento;
            this.capa = capa;
            this.artista = artista;
            this.produtor = produtor;
            musicas = new List<Musica>();
        }

        public void AddMusica(Musica musica)
        {
            musicas.Add(musica);
        }
    }
}
