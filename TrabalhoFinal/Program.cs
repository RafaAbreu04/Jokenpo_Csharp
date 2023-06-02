using System;
using System.IO;

namespace TrabalhoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string save = "T,T,E&PP,PP,E&P,PP,2";
            string[] teste = save.Split('&');
            string resultado = string.Empty;
            

            string final = string.Join('&', teste);

             Console.WriteLine(final);

            int linha = 1;
            foreach(string s1 in teste)
            {
                string[] jogadas = s1.Split(',');
                if (jogadas[2].Equals("1"))
                {
                    resultado = "Jogador 1 venceu";
                }
                else if (jogadas[2].Equals("2"))
                {
                    resultado = "Jogador 2 venceu";
                }
                else if (jogadas[3].Equals("E"))
                {
                    resultado = "Empate";
                    Console.WriteLine($"Jogada {++linha} {jogadas[0]} vs {jogadas[1]} = {jogadas[2]}");
                }

            }


            //3 estruturas de repetição provavelmente
            //estrutura do jogo
            //estrutura da vitoria (3 pontos)
            //estrutura da partida

            //salvar (array)lista de jogadas, mas pelo menos o nome e a pontuação
            //salvar só a partida do último jogo
            //antes de salvar o jogo, tem que verificar se tem um arquivo salvo e se ele existe, carrega o arquivo e lê, a fim de incrementar ele para colocar mais uma vitória se ele vencer
            //metodo .split para quebrar o & que ficaria no meio de P&&PP = E por exemplo
            //os resultados dariam uma lista

            //while (continuar_programa)
            {
                //------------------------- MENU DO JOGO ---------------------------------------------------------
                int repetirmenu = 0;
                do
                {
                    Console.WriteLine("------ Jokenpô -----\n");

                    Console.WriteLine("Digite o número da opção: \n");
                    Console.WriteLine("1 - Iniciar jogo");
                    Console.WriteLine("2 - Exibir resumo");
                    Console.WriteLine("3 - Sair");

                    string strOpcao = Console.ReadLine();
                    if (!int.TryParse(strOpcao, out int opcao) || (opcao <= 0 || opcao >= 4))
                    {
                        //fazer while para quando errar o número e repetir o loop
                        Console.WriteLine("Opção inválida!");
                        repetirmenu = opcao;
                    }
                } while (repetirmenu <= 0 || repetirmenu >= 4);

                if (opcao == 1)
                {
                    //------------------------- PARTIDA  --------------------------------------------------------- 

                    Console.Write("Insira seu nome: ");
                    string nomeJogador = Console.ReadLine();
                    Console.WriteLine("Iniciando jogo...\n");

                    Console.WriteLine($"Bem-vindo(a), {nomeJogador}!\n");
                    Console.WriteLine("Você jogará Jokenpô. Escolha entre os símbolos pedra, papel, e tesoura. Você irá jogar contra o computador!\");

                    Console.WriteLine("Sobre o jogo, a pedra vence a tesoura, a tesoura vence o papel e o papel ganha da pedra. Se uma combinação diferente dessas ocorrer, resultará em um empate.\n");

                    //while (continuar_partida)
                    {
                        Console.WriteLine("Escolha umas das siglas das 3 opções: ");
                        Console.WriteLine("P (Pedra)");
                        Console.WriteLine("PP (Papel)");
                        Console.WriteLine("T (Tesoura)");

                        Console.Write("Insira sua jogada: ");

                    }
                }
                else if (opcao == 2)
                {
                    //fazer if para indicar que não tem resumo se for a primeira partida
                }
                else if (opcao == 3)
                {
                    //se a pessoa ainda não tiver jogado e nem dado o nome ai não tem o que salvar
                    //perguntar se quer salvar o nome do jogador, histórico de jogadas da última partida e total de vitórias
                    //break;

                }




            }
            
        }
    }
}
