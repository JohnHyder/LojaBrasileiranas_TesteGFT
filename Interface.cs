using System;

namespace LojaBrasileiranas
{
    class Interface
    {
        static void Main(string[] args)
        {
            double calculaImposto;
            Livro livro = new Livro();
            VideoGame videogame = new VideoGame();

            if(livro.tema == "educativo")
            {
                calculaImposto = 0;
                livro.preco = livro.preco + (livro.preco*calculaImposto);
                return;
            }
            else
            {
                calculaImposto = 0.1;
                livro.preco = livro.preco + (livro.preco*calculaImposto);
                return;
            }
            if (videogame.isUsado == true)
            {
                calculaImposto = 0.25;
                videogame.preco = videogame.preco + (videogame.preco*calculaImposto);
                return;
            }
    }
}
}
