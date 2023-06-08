using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrabalhoProgramacao
{
    class Program
    {
        public static int opcaomenu, PontosJogador, PontosPC, FimdeJogo, FechandoJogo;
        public static int ContadorRodadas = 1;
        public static char jogada;
        public static string VencedorRodada, EscolhaJogador, EscolhaPC;
        public static string nomeJogador = "";
        public static List<string> BagulhosProSave = new List<string>();
        public static string Path = @"c:\temp\SaveJokenpô.txt";

        public static void FinaldeJogo()
        {
            Console.WriteLine("\nDigite 1 para começar um novo jogo, 2 para voltar ao menu ou 3 para encerrar o jogo.");
            string nada = (Console.ReadLine());
            if (int.TryParse(nada, out FimdeJogo))
            {
                if (FimdeJogo < 1 || FimdeJogo > 3)
                {
                    Console.WriteLine("Opção inválida, digite 1, 2 ou 3.\n");
                    FinaldeJogo();
                }
            }

            else
            {
                Console.WriteLine("Opção inválida, digite 1, 2 ou 3.\n");
                FinaldeJogo();
            }

            if (FimdeJogo == 1)
            {
                FimdeJogo = -1;
                PontosJogador = 0;
                PontosPC = 0;
                ContadorRodadas = 1;
                VencedorRodada = string.Empty;
                BagulhosProSave.Clear();
                Jokenpô();
            }

            else if (FimdeJogo == 2)
            {
                FimdeJogo = -1;
                PontosJogador = 0;
                PontosPC = 0;
                ContadorRodadas = 1;
                VencedorRodada = string.Empty;
                BagulhosProSave.Clear();
                Menu();
            }

            else if (FimdeJogo == 3)
            {
                FecharJogo();
            }
        }

        static string Vencedor()
        {
            VencedorRodada = string.Empty;
            ContadorRodadas++;

            if (EscolhaJogador == EscolhaPC)
            {
                VencedorRodada = "Empate";
            }

            if (EscolhaJogador == "Pedra")
            {
                if (EscolhaPC == "Tesoura")
                {
                    VencedorRodada = "Você venceu esta rodada";
                    PontosJogador++;
                }
                if (EscolhaPC == "Papel")
                {
                    VencedorRodada = "Você perdeu esta rodada";
                    PontosPC++;
                }
            }

            if (EscolhaJogador == "Papel")
            {
                if (EscolhaPC == "Pedra")
                {
                    VencedorRodada = "Você venceu esta rodada";
                    PontosJogador++;
                }
                if (EscolhaPC == "Tesoura")
                {
                    VencedorRodada = "Você perdeu esta rodada";
                    PontosPC++;
                }
            }

            if (EscolhaJogador == "Tesoura")
            {
                if (EscolhaPC == "Papel")
                {
                    VencedorRodada = "Você venceu esta rodada";
                    PontosJogador++;
                }
                if (EscolhaPC == "Pedra")
                {
                    VencedorRodada = "Você perdeu esta rodada";
                    PontosPC++;
                }
            }

            return VencedorRodada;
        }
        public static void cabeçalho()
        {
            Console.Clear();
            Console.WriteLine("------ Jokenpô -----\n");

            Console.WriteLine($"Bem-vindo(a), {nomeJogador}!\n");
            Console.WriteLine("Você jogará Jokenpô. Escolha entre os símbolos pedra, papel, e tesoura. Você irá jogar contra o computador!\n");

            Console.WriteLine("Sobre o jogo, a pedra vence a tesoura, a tesoura vence o papel e o papel ganha da pedra.\nSe uma combinação diferente dessas ocorrer, resultará em um empate.\n");
            Console.WriteLine($"\n{nomeJogador} - {PontosJogador}\nComputador - {PontosPC}\n\n");
            Console.WriteLine("Escolha umas das siglas das 3 opções: ");
            Console.WriteLine("P (Pedra)");
            Console.WriteLine("PP (Papel)");
            Console.WriteLine("T (Tesoura)");
            if (ContadorRodadas > 1)
            {
                Console.WriteLine($"\n{EscolhaJogador} X {EscolhaPC}");
                BagulhosProSave.Add($"\n{EscolhaJogador} X {EscolhaPC}\n{VencedorRodada}");
            }
            else
            {
                Console.WriteLine("\n");
            }
            Console.WriteLine($"\n{VencedorRodada}");
        }

        public static void JogadorEscolha()
        {
            Console.Write("Insira sua jogada: \n");
            string strJogada = Console.ReadLine().ToUpper();

            if (strJogada.Equals("P") || strJogada.Equals("PEDRA") || strJogada.Equals("P (Pedra)"))
            {
                jogada = 'R';
                EscolhaJogador = "Pedra";
            }
            else if (strJogada.Equals("PP") || strJogada.Equals("PAPEL") || strJogada.Equals("PP (Papel)"))
            {
                jogada = 'P';
                EscolhaJogador = "Papel";
            }
            else if (strJogada.Equals("T") || strJogada.Equals("TESOURA") || strJogada.Equals("T (Tesoura)"))
            {
                jogada = 'T';
                EscolhaJogador = "Tesoura";
            }
            else
            {
                Console.Clear();
                cabeçalho();
                Console.WriteLine("Jogada inválida!");
                JogadorEscolha();
            }
        }

        public static void EscolhaMenu()
        {
            string nada2 = (Console.ReadLine());
            if (int.TryParse(nada2, out opcaomenu))
            {
                if (opcaomenu < 1 || opcaomenu > 3)
                {
                    Console.WriteLine("Opção inválida, digite 1, 2 ou 3.\n");
                    EscolhaMenu();
                }
            }

            else
            {
                Console.WriteLine("Opção inválida, digite 1, 2 ou 3.\n");
                EscolhaMenu();
            }
        }

        public static void Jokenpô()
        {
            Console.Clear();
            Console.WriteLine("------ Jokenpô -----\n");
            Console.Write("Insira seu nome: ");
            nomeJogador = Console.ReadLine();
            BagulhosProSave.Add($"{nomeJogador} X Computador");
            do
            {
                cabeçalho();
                JogadorEscolha();

                Random rnd = new Random();
                int IntEscolhaPC = rnd.Next(1, 4);
                if (IntEscolhaPC == 1)
                {
                    EscolhaPC = "Pedra";
                }

                else if (IntEscolhaPC == 2)
                {
                    EscolhaPC = "Papel";
                }

                else if (IntEscolhaPC == 3)
                {
                    EscolhaPC = "Tesoura";
                }

                Vencedor();
            } while (PontosJogador < 3 && PontosPC < 3);

            if (PontosJogador == 3 || PontosPC == 3)
            {
                cabeçalho();
                BagulhosProSave.Add($"\n{nomeJogador} - {PontosJogador}\nComputador - {PontosPC}\n");
                if (PontosJogador == 3)
                {
                    Console.WriteLine("VOCÊ GANHOU!!!!");
                    BagulhosProSave.Add("VOCÊ GANHOU!!!!");
                }

                else if (PontosPC == 3)
                {
                    Console.WriteLine("Você perdeu.");
                    BagulhosProSave.Add("Você perdeu.");
                }
                Console.Clear();
                Console.WriteLine("------ Jokenpô -----\n");
                foreach (var Bagulho in BagulhosProSave)
                {
                    Console.WriteLine(Bagulho);
                }
                FinaldeJogo();
            }
        }

        static void Menu()
        {
            do
            {

                Console.Clear();
                Console.WriteLine("------ Jokenpô -----\n");
                Console.WriteLine("Digite o número da opção: \n");
                Console.WriteLine("1 - Iniciar jogo");
                Console.WriteLine("2 - Exibir resumo");
                Console.WriteLine("3 - Sair");
                EscolhaMenu();
            } while (opcaomenu < 1 || opcaomenu > 3);

            if (opcaomenu == 1)
            {
                opcaomenu = -1;
                char[] arrayIA = { 'R', 'P', 'T' };
                //------------------------- PARTIDA  --------------------------------------------------------- 
                
                Jokenpô();
            }

            else if (opcaomenu == 2)
            {
                opcaomenu = -1;
                MostrarDados();
                Console.WriteLine("Aperte qualquer botão para retornar ao menu.");
                Console.ReadLine();
                Menu();
            }

            else if (opcaomenu == 3)
            {
                FecharJogo();
            }
        }

        static void SalvarDados()
        {
            File.WriteAllLines(Path, BagulhosProSave);
        }

        static void MostrarDados()
        {
            Console.Clear();
            Console.WriteLine("------ Jokenpô -----\n");
            using (StreamReader sr = File.OpenText(Path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        static void FecharJogo()
        {
            if (nomeJogador != "")
            {
                Console.Clear();
                Console.WriteLine("------ Jokenpô -----\n");
                Console.WriteLine("\nDigite 1 para salvar os resultados antes de sair ou 2 para encerrar sem salvar.");
                string nada4 = (Console.ReadLine());
                if (int.TryParse(nada4, out FechandoJogo))
                {
                    if (FechandoJogo < 1 || FechandoJogo > 2)
                    {
                        Console.WriteLine("Opção inválida, digite 1 ou 2.\n");
                        FechandoJogo = -1;
                        FecharJogo();
                    }
                }

                else
                {
                    Console.WriteLine("Opção inválida, digite 1 ou 2.\n");
                    FechandoJogo = -1;
                    FecharJogo();
                }

                if (FechandoJogo == 1)
                {
                    SalvarDados();
                    Environment.Exit(-1);
                }

                else if (FechandoJogo == 2)
                {
                    Environment.Exit(-1);
                }
            }

            else
            {
                Environment.Exit(-1);
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}