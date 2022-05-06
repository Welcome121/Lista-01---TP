using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaUm
{
    public class Busca
    {
        static void AlbunsArtista(List<Artista> artistas, string nome)
        {
            var resultados = from artista in artistas
                            from album in artista.albuns
                            where artista.nome == nome
                            select album;

            foreach (var resultado in resultados )
            {
                Console.WriteLine(resultado.nome);
            }
        }

        static List<Album> AlbunsAno(List<Album> albuns, DateTime data)
        {
            var resultados = (from album in albuns
                            where album.dataLancamento == data
                            select album).ToList();
                            
            return resultados;
        }
    }
}
