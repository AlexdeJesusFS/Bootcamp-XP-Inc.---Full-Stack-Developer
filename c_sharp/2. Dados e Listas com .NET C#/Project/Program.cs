using Project.Models;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;


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


//Leitura de arquivos:

//Funções Globais: método de classe criado implicitamente pelo compilador.
static void ReadFile(string path) {
    string[] file = File.ReadAllLines(path);

    foreach (string line in file) {
        Console.WriteLine(line);
    }
}

//Bloco de exceção
try {
    ReadFile("Arquivos/arquivo.txt");
//usando catch when para capturar duas exceções e aplicar a mesma solução:
} catch (Exception ex) when (ex is DirectoryNotFoundException || ex is FileNotFoundException) {
    Console.WriteLine($"Exception: Directory or File not find!\n{ex.Message}");
} finally {// bloco escutado sempre, independente se houve ou não exceção
    Console.WriteLine("Finally here!");
}
*/
/*
//Fila - FIFO (First In First Out)
Queue<int> queue = new();
List<int> list = [1,2,3,4,5,6,7,8];
//forma simplificada de percorrer uma lista com foreach, exclusiva para o tipo lista:
//list.ForEach(Console.WriteLine);

foreach (int i in list) {
    queue.Enqueue(i);
}
queue.ForEach(Console.WriteLine);
Console.WriteLine("");
queue.Dequeue();
queue.Dequeue();
queue.ForEach(Console.WriteLine);
*/
/*
//Pilha - LIFO (Last In First Out)
List<int> list = [1,2,3,4,5,6,7,8];
Stack<int> stack = new(list); //cria a pilha com os valores da lista
foreach (int item in stack) {
    Console.WriteLine(item);
}

stack.Push(10);
stack.Pop();
Console.WriteLine("");

foreach (int item in stack) {
    Console.WriteLine(item);
}
//ao final a pilha está igual já que o primeiro que entrou foi também quem saiu.
*/
/*
//Dicionário - Coleção composta de chaver e valor, onde é criado a chave e a chave é de valor único
Dictionary<string, string> states = new();

states["SP"] = "São Paulo";
states["RJ"] = "Rio de Janeiro";
states["BA"] = "Bahia";

foreach (var state in states) {
    Console.WriteLine(state);
}

states.Remove("RJ");
states["SP"] = "New York";
Console.WriteLine("");

foreach (var state in states) {
    Console.WriteLine(state);
}

Console.WriteLine(states.ContainsKey("SP") ? "Key Exists" : "Key Don't Exist");
*/
/*
//Tuplas: coleção imutavel de dados de diferentes tipos
var tupla = (name: "Lex", lastName: "Souza", age: 20);
Console.WriteLine($"{tupla.GetType().Name}\n{tupla}");

static (bool Success, string[] Lines, int CountLines) ReadFile(string path) {
    try {
        string[] file = File.ReadAllLines(path);
        return (true, file, file.Length);
    } catch {
        return (false, Array.Empty<string>(), 0);
    }
}
//Formas de acessar os valores da tupla:
//salvando em tupla e acessando pela chave
var result = ReadFile(path: "Arquivos/arquivo.txt"); 
Console.WriteLine($"{result.Success}, {result.Lines}, {result.CountLines}");

//salvando cada valor separadamente em uma variavel
var (Success, Lines, _) = ReadFile(path: "Arquivos/arquivo.txt");
Console.WriteLine($"{Success} {Lines} {"CountLines descartado pelo _"}");
*/


