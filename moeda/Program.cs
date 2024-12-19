using System;
using System.Globalization;

namespace teste
{
    class Programmoeda
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // decimal valor = 10.25m;
            // Console.WriteLine(
            //     valor.ToString(
            //         "P",
            //     CultureInfo.CreateSpecificCulture("en-US")
            //     )
            //     );

            decimal valor = 10536.25m;
            Console.WriteLine(
                Math.Round(valor)
                // Math.Round == arredonda
                // Math.Ceiling == arredonda pra cima
                // Math.Floor == arredonda pra baixo
            );
        }
    }
}