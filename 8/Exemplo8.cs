using System;

namespace Exemplos_Trabalho_CSharp
{
    class Exemplo8
    {
        // Membros somente Leitura
        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            public readonly double Distance => Math.Sqrt(X * X + Y * Y);

            public readonly override string ToString() =>
                $"({X}, {Y}) está {Distance} da origem";

            
            //public readonly void Translate(int xOffset, int yOffset)
            public void Translate(int xOffset, int yOffset)
            {
                X += xOffset;
                Y += yOffset;
            }
        }

        public void CreatePoint()
        {
            Point p = new Point();
            p.X = 7;
            p.Y = 9;
            Console.WriteLine(p.ToString());
        }



        // Expressões Switch
        public struct RGBColor
        {
            public int R;
            public int G;
            public int B;

            public RGBColor(int r, int g, int b)
            {
                R = r;
                G = g;
                B = b;
            }
        }
        public enum Rainbow
        {
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Indigo,
            Violet
        }
        public static RGBColor FromRainbow(Rainbow colorBand) =>
        colorBand switch
        {
            Rainbow.Red => new RGBColor(0xFF, 0x00, 0x00),
            Rainbow.Orange => new RGBColor(0xFF, 0x7F, 0x00),
            Rainbow.Yellow => new RGBColor(0xFF, 0xFF, 0x00),
            Rainbow.Green => new RGBColor(0x00, 0xFF, 0x00),
            Rainbow.Blue => new RGBColor(0x00, 0x00, 0xFF),
            Rainbow.Indigo => new RGBColor(0x4B, 0x00, 0x82),
            Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
            _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
        };
        /*
        public static RGBColor FromRainbowClassic(Rainbow colorBand)
        {
            switch (colorBand)
            {
                case Rainbow.Red:
                    return new RGBColor(0xFF, 0x00, 0x00);
                case Rainbow.Orange:
                    return new RGBColor(0xFF, 0x7F, 0x00);
                case Rainbow.Yellow:
                    return new RGBColor(0xFF, 0xFF, 0x00);
                case Rainbow.Green:
                    return new RGBColor(0x00, 0xFF, 0x00);
                case Rainbow.Blue:
                    return new RGBColor(0x00, 0x00, 0xFF);
                case Rainbow.Indigo:
                    return new RGBColor(0x4B, 0x00, 0x82);
                case Rainbow.Violet:
                    return new RGBColor(0x94, 0x00, 0xD3);
                default:
                    throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand));
            };
        }
        */



        //Índices e intervalos
        public void ShowNewIndexAndRange()
        {
            var words = new string[]
            {
                            // índice do começo    índice do final
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };              // 9 (ou words.Length) ^0


            Console.WriteLine($"The last word is {words[^1]}");
            // Escreve "dog"

            var allWords = words[..]; // conterá "The" até "dog".
            var firstPhrase = words[..4]; // conterá "The" até "fox"
            var lastPhrase = words[6..]; // conterá "the", "lazy" and "dog"

            Range phrase = 1..4;
            var text = words[phrase];
            // text conterá "quick", "brown" e "fox", não conterá "jumped" porque range é não inclusivo no índice final
            Console.WriteLine($"{text[0]}, {text[1]}, {text[2]}");

        }
    }
}
