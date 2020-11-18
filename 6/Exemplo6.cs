using System;

namespace Exemplos_Trabalho_CSharp
{
    public class Exemplo6
    {
        // Propriedades automáticas somente leitura
        public string FirstName { get; }
        public string LastName { get; }
        public void ChangeLastName(string newLastName)
        {
            // Generates CS0200: Property or indexer cannot be assigned to -- it is read only
            LastName = newLastName;
        }


        // Membros de função aptos para expressão e Interpolação de cadeia de caracteres
        public override string ToString() => $"{FirstName} {LastName}";
        public string FullName => $"{FirstName} {LastName}";

        /* public override string ToString()
        * {
        *    return FirstName + " " + LastName;
        * }
        */
        //public string FullName { get; set; } 

        public Exemplo6(string firstName, string lastName)
        {

            FirstName = firstName;

            LastName = lastName;
            //ChangeLastName(lastName);

            //FullName = FirstName + " " +LastName;
        }
    }
}
