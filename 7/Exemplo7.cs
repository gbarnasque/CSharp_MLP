using Microsoft.VisualBasic;
using System;

namespace Exemplos_Trabalho_CSharp
{
    class Exemplo7
    {
        // Tuplas, Descartes, e funções locais
        public void ShowGameScore()
        {
            (string time1, int score1, string time2, int score2) = GetGameScore("Alemanha", "Brasil");
            Console.WriteLine($"{time1}:{score1} | {time2}:{score2}");


            (string, int, string, int) GetGameScore(string team1, string team2)
            {
                if (team1 == "Alemanha" && team2 == "Brasil")
                {
                    return (team1, 7, team2, 1);
                }

                return (team1, -1, team2, -1);
            }
        }


        //Variáveis out
        public int? StringToInt(string s)
        {

            if (int.TryParse(s, out int result))
                return result;
            else
                return null;

            /*
            int? result;
            try
            {
                result = int.Parse(s);
            }
            catch(FormatException e)
            {
                result = null;
            }
                return result;
            */
        }

    }
}
