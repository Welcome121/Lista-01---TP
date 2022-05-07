using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaUm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Artistas
                List<Artista> artistas = new List<Artista>();

                Artista James_Arthur = new Artista("James Arthur", "13846705010", true, new DateTime(1988, 3, 2), DateTime.Now, "Pop");
                Artista Ludovico_Einaudi = new Artista("Ludovico Einaudi", "55578555511", true, new DateTime(1955, 11, 23), DateTime.Now, "Classica");
                Artista Johnny_Cash = new Artista("Johnny Cash", "83176463005", false, new DateTime(1932, 2, 26), new DateTime(2003, 9, 12), "Country");

                artistas.Add(James_Arthur);
                artistas.Add(Ludovico_Einaudi);
                artistas.Add(Johnny_Cash);

            //Produtores
                List<Produtor> produtores = new List<Produtor>();

                Produtor Hans_Zimmer = new Produtor("Hans Zimmer", "13844478905", true, new DateTime(1957, 9, 12), DateTime.Now, "HZ productions");
                Produtor Max_Martin = new Produtor("Martin Karl Sandberg", "99999999999", true, new DateTime(1971, 2, 26), DateTime.Now, "Max Martin");

                Hans_Zimmer.AddGeneroMusical("Classica");
                Hans_Zimmer.AddGeneroMusical("Eletronica");
                Max_Martin.AddGeneroMusical("Pop");
                Max_Martin.AddGeneroMusical("Eletronica");

                produtores.Add(Hans_Zimmer);
                produtores.Add(Max_Martin);

            //Musicas
                //musicas Ludovico_Einaudi
                    Musica Experience = new Musica("Experience", 6.17, "Classica", new DateTime(2014));
                    Musica Giorni_Dispari = new Musica("Giorni Dispari", 5.18, "Classica", new DateTime(2010));
                    Musica Una_Mattina = new Musica("Una Mattina", 3.24, "Classica", new DateTime(2004));
                    Musica Nuvole_Bianche = new Musica("Nuvole Bianche", 6.41, "Classica", new DateTime(2003));
                    Musica Ora = new Musica("Ora", 7.58, "Classica", new DateTime(2003));

                //Musicas Johnny_Cash
                    Musica Hurt = new Musica("Hurt", 3.39, "Country", new DateTime(2002));
                    Musica In_my_life = new Musica("In my life", 2.58, "Country", new DateTime(2002));
                    Musica Big_Iron = new Musica("Big Iron", 3.53, "Folk", new DateTime(2002));

                //musicas James_Arthur
                    Musica Train_Wreck = new Musica("Train Wreck", 3.29, "Pop", new DateTime(2016));
                    Musica I_Am = new Musica("I Am", 3.11, "Pop", new DateTime(2016));
                    Musica Can_I_Be_Him = new Musica("Prisoner", 3.58, "Pop", new DateTime(2016));
                    Musica Finally = new Musica("Finally", 4.21, "Pop", new DateTime(2016));

            //Albuns
                List<Album> albuns = new List<Album>();
                Album bestOfLudovico = new Album("Best of Ludovico", "Classica", new DateTime(2022), "So as melhores", Ludovico_Einaudi, Hans_Zimmer);
                Album AmericanIV = new Album("American IV", "Country", new DateTime(2002), "Covers Johnny Cash", Johnny_Cash, Hans_Zimmer);
                Album BackFromTheEdge = new Album("Back From The Edge", "Pop", new DateTime(2016), "Sofrencia", James_Arthur, Max_Martin);
                
                albuns.Add(bestOfLudovico);
                albuns.Add(AmericanIV);
                albuns.Add(BackFromTheEdge);

                bestOfLudovico.AddMusica(Experience);
                bestOfLudovico.AddMusica(Giorni_Dispari);
                bestOfLudovico.AddMusica(Una_Mattina);
                bestOfLudovico.AddMusica(Nuvole_Bianche);
                bestOfLudovico.AddMusica(Ora);

                AmericanIV.AddMusica(Hurt);
                AmericanIV.AddMusica(In_my_life);
                AmericanIV.AddMusica(Big_Iron);

                BackFromTheEdge.AddMusica(Train_Wreck);
                BackFromTheEdge.AddMusica(I_Am);
                BackFromTheEdge.AddMusica(Can_I_Be_Him);
                BackFromTheEdge.AddMusica(Finally);

                Ludovico_Einaudi.AddAlbum(bestOfLudovico);
                Hans_Zimmer.AddAlbum(bestOfLudovico);

                Johnny_Cash.AddAlbum(AmericanIV);
                Hans_Zimmer.AddAlbum(AmericanIV);

                James_Arthur.AddAlbum(BackFromTheEdge);
                Max_Martin.AddAlbum(BackFromTheEdge);

            //Testes
                //Busca.AlbunsArtista(artistas, "Ludovico Einaudi");
                //Busca.AlbunsAno(albuns, new DateTime(2002));
                //Busca.MusicasArtista(artistas, "James Arthur");
                //Busca.MusicasArtistaAno(artistas, "Ludovico Einaudi", 2003);
                //Busca.albunsGeneroProdutor(produtores, "Hans Zimmer", "Country");
                //Busca.albunsAnoProdutor(produtores, "Hans Zimmer", 2002);
                Busca.ordemDecrescenteAlbunsArtista(artistas, "Ludovico Einaudi");

            Console.ReadLine();
        }
    }
}
