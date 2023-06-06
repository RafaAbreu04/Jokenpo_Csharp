using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public static int ContadorDePontosJogador, ContadorDePontosPC;

        static string Vencedor(string Jogador, string PC) //Lembrar de colocar essas strings no código
        {
            string Ganhador = string.Empty;

            if (Jogador == PC)
            {
                Ganhador = "Empate";
            }

            if(Jogador == "Pedra")
            {
                if(PC == "Tesoura")
                {
                    Ganhador = "Você venceu esta rodada";
                    ContadorDePontosJogador++;
                }
                if (PC == "Papel")
                {
                    Ganhador = "Você perdeu esta rodada";
                    ContadorDePontosPC++;
                }
            }

            if (Jogador == "Papel")
            {
                if (PC == "Pedra")
                {
                    Ganhador = "Você venceu esta rodada";
                    ContadorDePontosJogador++;
                }
                if (PC == "Tesoura")
                {
                    Ganhador = "Você perdeu esta rodada";
                    ContadorDePontosPC++;
                }
            }

            if (Jogador == "Tesoura")
            {
                if (PC == "Papel")
                {
                    Ganhador = "Você venceu esta rodada";
                    ContadorDePontosJogador++;
                }
                if (PC == "Tesoura")
                {
                    Ganhador = "Você perdeu esta rodada";
                    ContadorDePontosPC++;
                }
            }

            return Ganhador;
        }

        static void Main(string[] args)
        {
        }
    }
}
