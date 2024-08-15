using Project.Models;
using System.ComponentModel;
using System.Globalization;


/*
Console.WriteLine("Hello, World!");

Console.WriteLine("Glória a Deus!!!!!!!");

Person person1 = new("Lexus", "de Jesus", 18);

person1.Show();
*/
/*
using System.Globalization;
//Altera a cultura do sistema para todo o arquivo:
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
Console.WriteLine($"{1560.50M:C}");

//Altera a cultura especificamente e unicamente somente para esse valor: 
Console.WriteLine($"{1560.50.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
*/
//Formas de formatação numerica:
decimal n = 1569.99M;
Console.WriteLine($"{n:C}");//moeda
Console.WriteLine($"{n:N}");//separadores de milhar
Console.WriteLine($"{0.1234:P2}");//porcentagem com 2 casas decimais
Console.WriteLine($"{n}");//ponto fixo
Console.WriteLine($"{123456789:##-##-##-##}");

//Formatação de datas:
DateTime date = DateTime.Now;
Console.WriteLine(date.ToString("MMM dd, yyyy HH:mm"));
//Conversão de String para DateTime:
Console.WriteLine(DateTime.Parse("10/08/2024 09:30"));
//Conversão com Try, dessa forma evita-se exceções:

bool success = DateTime.TryParseExact("14/08/2024 09:30", //valor da data string que deseja converte
                        "dd/MM/yyyy HH:mm", // formato em que está a data string
                        CultureInfo.InvariantCulture, // cultura em que deseja converte a data string
                        DateTimeStyles.None, // estilo em que deseja convete a data string
                        out DateTime data); // saida: declaração da variavel para onde vai a data string convertida
//com operador ternário:
Console.WriteLine(success ? $"convertido: {data}" : "Não convertido");
