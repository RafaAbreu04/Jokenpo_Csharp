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

            //loop do jogo

            bool continuar_programa = true;
            bool continuar_partida = true;
            

            //while (continuar_programa)
            {
                //criando o menu
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
                        //fazer while para quando errar e repetir o loop
                        Console.WriteLine("Opção inválida!");
                        repetirmenu = opcao;
                    }
                } while (repetirmenu <= 0 || repetirmenu >= 4);

                if (opcao == 1)
                {
                    //while (continuar_partida)
                    Console.Write("Insira seu nome: ");
                    string nomeJogador = Console.ReadLine();
                    Console.WriteLine("Iniciando jogo...\n");

                    do
                    {
                        Console.Clear;
                        Console.WriteLine("------ Jokenpô -----\n");
                        Console.WriteLine("Melhor de 3\n");
                        Console.WriteLine($"{nomeJogador} = {INSERIR CONTADOR DE PONTOS JOGADOR AQUI}");
                        Console.WriteLine($"Computador = {INSERIR CONTADOR DE PONTOS COMPUTADOR AQUI}\n\n");
                        Console.WriteLine("Digite:\n1 - Pedra\n2 - Papel\n3 - Tesoura");
                        int EscolhaJogador = int.Parse(Console.ReadLine());
                        //Inserir comparação da jogada do jogador com a do pc aqui
                        Console.Clear
                        Console.WriteLine("------ Jokenpô -----\n");
                        Console.WriteLine("Melhor de 3\n");
                        Console.WriteLine($"{nomeJogador} = {INSERIR CONTADOR DE PONTOS JOGADOR AQUI}");
                        Console.WriteLine($"Computador = {INSERIR CONTADOR DE PONTOS COMPUTADOR AQUI}\n\n");
                        //Inserir mensagem se perdeu ou ganhou a rodada aqui
                        if () //Se ContadorDePontosJogador der 3, mensagem de vitória
                        {

                        }

                        else if () //Se ContadorDePontosComputador der 3, mensagem de perdeu
                        {

                        }
                    } while () //Inserir enquanto ContadorDePontosJogador for inferior à 3 OU ContadorDePontosComputador for inferior à 3 aqui 
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
