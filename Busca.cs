using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaUm
{
    public class Busca
    {
        public static void AlbunsArtista(List<Artista> artistas, string nome) {
            var resultados = from artista in artistas
                             from album in artista.albuns
                             where artista.nome == nome
                             select album;

            foreach (var resultado in resultados ) { Console.WriteLine(resultado.nome); }
        }

        public static void AlbunsAno(List<Album> albuns, DateTime data) {
            var resultados = from album in albuns
                             where album.dataLancamento == data
                             select album;
                            
            foreach (var resultado in resultados) { Console.WriteLine(resultado.nome); }
        }

        public static void MusicasArtista(List<Artista> artistas, string nome) {
            var resultados = from artista in artistas
                             from album in artista.albuns
                             from musica in album.musicas
                             where artista.nome == nome
                             select musica;
            
            foreach (var resultado in resultados) { Console.WriteLine(resultado.nome); }
        }

        public static void MusicasArtistaAno(List<Artista> artistas, string nome, int data) {
            var musicasArtista = (artistas.Where(artista => artista.nome == nome)
                                     .SelectMany(artista => artista.albuns)).ToList()
                                     .SelectMany(album => album.musicas);

            var resultados = from musica in musicasArtista
                             where musica.lancamento.Ticks == data
                             select musica;
            
            foreach(var resultado in resultados) { Console.WriteLine(resultado.nome); }
        }

        public static void albunsGeneroProdutor(List<Produtor> produtores, string nomeProdutor, string nomeGenero) {
            var resultados = from produtor in produtores
                             from album in produtor.albuns
                             where (produtor.nome == nomeProdutor && album.generoMusical == nomeGenero)
                             select album;

            foreach(var resultado in resultados) { Console.WriteLine(resultado.nome); }
        }

        public static void albunsAnoProdutor(List<Produtor> produtores, string nomeProdutor, int data) {
            var resultados = from produtor in produtores
                             from album in produtor.albuns
                             where (produtor.nome == nomeProdutor && album.dataLancamento.Ticks == data)
                             select album;

            foreach(var resultado in resultados) { Console.WriteLine(resultado.nome); }
        }

        public static void ordemDecrescenteAlbunsArtista(List<Artista> artistas, string nome) {
            var resultados = from artista in artistas
                             from album in artista.albuns
                             orderby album.dataLancamento.Ticks descending
                             select album;

            foreach (var resultado in resultados) { Console.WriteLine($"{resultado.nome} - {resultado.dataLancamento.Ticks}"); }
        }
    }
}
