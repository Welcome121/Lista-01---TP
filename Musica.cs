using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Musica
{
    string nome;
    double duracao;
    string generoMusical;
    DateTime lancamento;

    public Musica(string nome, double duracao, string generoMusical, DateTime lancamento)
    {
        this.nome = nome;
        this.duracao = duracao;
        this.generoMusical = generoMusical;
        this.lancamento = lancamento;
    }
}
