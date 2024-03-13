using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDasCharadas.Methods
{
    internal class Senhas
    {
        public Senhas() { }
        LetraDeMaquina Escrita = new LetraDeMaquina();
        public async Task SenhaUm(DateTime senha)
        {
            DateTime correto = new DateTime(2023, 11, 11);
            await Escrita.EscrevaSemPularLinha("Processando informação. ");
            await Escrita.Aguarde(1);
            await Escrita.EscrevaSemPularLinha(". ");
            await Escrita.Aguarde(1);
            await Escrita.EscrevaSemPularLinha(".");
            await Escrita.Aguarde(1);
            Console.WriteLine();
            if (senha == correto)
            {
                await Escrita.Escreva("Olha só, você passou de fase. Vamos para proxima");
            }
            else
            {
                await Escrita.Escreva("Incorreto, você perdeu! Recomece o jogo.");
                Console.WriteLine("\n\n\n");
                await Escrita.Aguarde(1000);
            }
        }

        public async Task SenhaDois(DateTime senha)
        {
            DateTime correto = new DateTime(2023, 08, 26);
            await Escrita.EscrevaSemPularLinha("Processando informação. ");
            await Escrita.Aguarde(1);
            await Escrita.EscrevaSemPularLinha(". ");
            await Escrita.Aguarde(1);
            await Escrita.EscrevaSemPularLinha(".");
            await Escrita.Aguarde(1);
            Console.WriteLine();
            if (senha == correto)
            {
                await Escrita.Escreva("Que memória boa, vou fazer questão da proxima ser mais dificil!");
            }
            else
            {
                await Escrita.Escreva("Que pena! Foi quase, tente de novo hahaha.");
                Console.WriteLine("\n\n\n");
                Environment.Exit(0);
            }
        }

        public async Task SenhaTres(string senha)
        {
            string correto = "Ela toda Taylor, ele todo Djonga";
            await Escrita.EscrevaSemPularLinha("Processando informação. ");
            await Escrita.Aguarde(1);
            await Escrita.EscrevaSemPularLinha(". ");
            await Escrita.Aguarde(1);
            await Escrita.EscrevaSemPularLinha(".");
            await Escrita.Aguarde(1);
            Console.WriteLine();
            if (senha == correto)
            {
                await Escrita.Escreva("NÃÃO! Você conseguiu de novo, você é boa mesmo!");
            }
            else
            {
                await Escrita.Escreva("Você tava quase lá, vai vai, você pode tentar novamente.");
                Console.WriteLine("\n\n\n");
                Environment.Exit(0);
            }
        }

    }
}
