using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaUm
{
    public class Busca
    {
        static void AlbunsArtista(List<Artista> artistas, string nome) {
            var resultados = from artista in artistas
                            from album in artista.albuns
                            where artista.nome == nome
                            select album;

            foreach (var resultado in resultados ) { Console.WriteLine(resultado.nome); }
        }

        static void AlbunsAno(List<Album> albuns, DateTime data) {
            var resultados = from album in albuns
                            where album.dataLancamento == data
                            select album;
                            
            foreach (var resultado in resultados) { Console.WriteLine(resultado.nome); }
        }

        static void MusicasArtista(List<Artista> artistas, string nome) {
            var resultados = from artista in artistas
                            from album in artista.albuns
                            from musica in album.musicas
                            where artista.nome = nome
                            select musica;
            
            foreach (var resultado in resultados) { Console.WriteLine(resultado.nome); }
        }

        static void MusicasArtistaAno(List<Artista> artistas, string nome, DateTime data) {
            var resultados = from artista in artistas
                            from album in artista.albuns
                            from musica in album.musicas
                            where artista.nome == nome && musica.lancamento.Year == data
                            select musica
            foreach(var resultado in resultados) { console.WriteLine(resultado.nome); }
        }
    }
}
