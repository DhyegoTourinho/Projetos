using System;
using System.Diagnostics;
using JogoDeCharadas;
using System.Threading.Tasks;
using JogoDasCharadas.Methods;

namespace JogoDeCharadas
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            DateTime senha;
            LetraDeMaquina Escrita = new LetraDeMaquina();
            Senhas senhas = new Senhas();
            
            //Jeremias inicia o presente.
            Console.WriteLine("Use em tela cheia para uma melhor experiência, após isso pressione qualquer tecla para iniciar!");
            Console.ReadKey();
            Console.Clear();
            await Escrita.Escreva("Olá, bem vinda ao jogo das charadas. Eu sou o Jerimias e meu criador, Dhyego Tourinho, o seu amado, me criou para te direcionar até o seu presente.");
            await Escrita.Escreva("Este código foi feito para intreter um coração quente como o seu!");
            await Escrita.Escreva("Você precisa descobrir uma sequência de informaç--- çç in in-- infor- for- forma... BIIII aaaa EEEE");
            await Escrita.Bug();
            await Escrita.Aguarde(1);
            Console.Clear();

            //Charada Toma o controle.
            await Escrita.Hacker();
            Console.WriteLine();
            await Escrita.Escreva("Como você pode ver, o seu sistema foi HACKEADO!!");
            await Escrita.Escreva("Agora, eu tenho o controle, da localização do seu presente.");
            await Escrita.Escreva("Já estava de olho em você a um tempo, meu nome é Charada, serei seu guia.");
            await Escrita.Escreva("ATENÇÃO, VOU EXPLICAR AS REGRAS");
            await Escrita.Aguarde(2);
            await Escrita.Escreva("\nPRIMEIRO: Não vale trapaças, jogue limpo e terá um bom fim.");
            await Escrita.Escreva("\nSEGUNDO: Você terá que desvendar enigmas. Eles são compostos de uma instrução e um pergaminho.");
            await Escrita.Escreva("\nTERCEIRO: Cada instrução te levará a um pergaminho. Cada pergaminho te concederá uma chave.");
            await Escrita.Escreva("\nQUARTO: Colete todas as chaves para obter o enigma final! Ele te levará ao seu presente.");
            await Escrita.Escreva("\nQUINTO: Se divirta. Porque eu já estou me divertindo HAHAHAHAHAHAHAHAHA, e... Boa sorte 'HOOPER'...");
            await Escrita.Escreva("\nPodemos começar? Pressione qualquer tecla para aceitar.");
            Console.ReadKey();
            Console.Clear();
            await Escrita.Enigma();
            Console.WriteLine();
            await Escrita.Um();

            // Charada 1
            Console.WriteLine();
            await Escrita.Escreva("Estou no local mais rápido da sua casa.");
            Console.WriteLine();
            await Escrita.EscrevaSemPularLinha("Digite a senha: ");
            senha = DateTime.Parse(Console.ReadLine());
            await senhas.SenhaUm(senha);
            await Escrita.Escreva("\nAcesso liberado! Pressione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();

            ///Charada 2
            await Escrita.Enigma();
            Console.WriteLine();
            await Escrita.Dois();
            await Escrita.Escreva("Sendo vigiado por quem acertaria uma de 3 de qualquer lugar");
            Console.WriteLine();
            await Escrita.EscrevaSemPularLinha("Digite a senha: ");
            senha = DateTime.Parse(Console.ReadLine());
            await senhas.SenhaDois(senha);
            await Escrita.Escreva("\nAcesso liberado! Pressione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();

            //Charada 3
            await Escrita.Enigma();
            Console.WriteLine();
            await Escrita.Tres();
            await Escrita.Escreva("Quero ver achar agora!!!\n");
            await Escrita.Escreva("Ouve, ouviria, ouvirá ela todos os dias");
            Console.WriteLine();
            await Escrita.EscrevaSemPularLinha("Digite a senha: ");
            string senhaString = Console.ReadLine();
            await senhas.SenhaTres(senhaString);

            //Final
            await Escrita.Escreva("Droga, você me venceu, por ter sido justa, vou liberar seu computador... ");
            await Escrita.Escreva("Jerimias... pode volt--");
            Console.WriteLine();
            await Escrita.Bug();
            await Escrita.Aguarde(1);
            Console.Clear();
            await Escrita.Hacker();
            Console.WriteLine();
            await Escrita.Fail();

            //Jeremias de volta.
            await Escrita.Escreva("UFA! Consegui recuperar o controle. Este tal de charada era muito poderoso, ainda bem que você ajudou!");
            await Escrita.Escreva("Enfim, acho que ja passou por muita coisa, vou te dizer onde está o seu presente final...");
            await Escrita.Escreva("Procure em (Criptografado), ops! Ele não me deu acesso à essa informação. Mas tenho uma dica");
            Console.WriteLine();
            await Escrita.Escreva("Procure em 'O lugar feito por letras, tal que, foi habitado por ambos em formato de imagem, sempre quente, talvez em chamas'!");
            Console.WriteLine();
            await Escrita.Escreva("Infelizmente meu acesso é restrito, só pude te informar isso, espero que encontre, tenha um otimo dia 11. Meu criador te ama");
            await Escrita.Escreva("F i n a l i z a n d o    a p l i c a ç ã o");

            Console.ReadKey();
            Console.ReadLine();
        }
    }
}