using System;

namespace Exemplos_Trabalho_CSharp
{
    class Exemplo9
    {
        // Tipos de Registro
        public record Person
        {
            public string LastName { get; }
            public string FirstName { get; }

            public Person(string first, string last) => (FirstName, LastName) = (first, last);

            public void changeFirstName(string first)
            {
                FirstName = first;
            }
        }
        public record Teacher : Person
        {
            public string Subject { get; }

            public Teacher(string first, string last, string sub)
                : base(first, last) => Subject = sub;
        }

        public sealed record Student : Person
        {
            public int Level { get; }

            public Student(string first, string last, int level) : base(first, last) => Level = level;
        }

        public void RecordExample()
        {
            Person p = new Person("Gustavo", "Barnasque");
            p.changeFirstName("Augusto");
            //p.FirstName = "Augusto";
        }



        // Setter somente init
        public struct WeatherObservation
        {
            public DateTime RecordedAt { get; init; }
            public decimal TemperatureInCelsius { get; init; }
            public decimal PressureInMillibars { get; init; }

            public override string ToString() =>
                $"At {RecordedAt:h:mm tt} on {RecordedAt:M/d/yyyy}: " +
                $"Temp = {TemperatureInCelsius}, with {PressureInMillibars} pressure";

            public void changeTemperature(decimal temp)
            { 
                TemperatureInCelsius = temp;
            }
        }

        public void ExampleIniti()
        {
            var now = new WeatherObservation
            {
                RecordedAt = DateTime.Now,
                TemperatureInCelsius = 20,
                PressureInMillibars = 998.0m
            };

            now.changeTemperature(21);
            now.TemperatureInCelsius = 21;
        }


        //Melhoria na correspondência de padrões
        public bool IsLetter(char? c) =>
            c is  (not null) and (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');
    }
}