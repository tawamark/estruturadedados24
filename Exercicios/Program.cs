using System;
using System.Globalization;

namespace GettingStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string fullName = Console.ReadLine();

            Console.Write("Digite a quantidade de pessoas: ");
            string pessoasString = Console.ReadLine();
            int.TryParse(pessoasString, out int pessoas);

            Console.Write("Digite a data e hora da reserva (formato M/d/yyyy HH:mm): ");
            string dateTimeString = Console.ReadLine();

            if (!DateTime.TryParseExact(
                dateTimeString,
                "M/d/yyyy HH:mm",
                new CultureInfo("en-US"),
                DateTimeStyles.None,
                out DateTime reservaDateTime))
            {
                Console.WriteLine("Data e hora inválidas. Usando a data e hora atuais.");
                reservaDateTime = DateTime.Now;
            }

            string numeroMesa = "A100";
            Console.WriteLine("\nResumo da Reserva:");
            Console.WriteLine($"Nome: {fullName}");
            Console.WriteLine($"Mesa: {numeroMesa}");
            Console.WriteLine($"Quantidade de Pessoas: {pessoas}");
            Console.WriteLine($"Data e Hora da Reserva: {reservaDateTime.ToString("M/d/yyyy HH:mm", new CultureInfo("en-US"))}");

            Console.WriteLine("\nReserva realizada com sucesso!");
        }
    }
}
