/*using Prologue.Common.Models;

//Class:
Person person1 = new Person();

person1.Name = "Lex";
person1.Age = 23;
person1.Show();
*/
/*
//Variables:
int intValue = 1;
decimal decimalValue = 10.00M; //decimal é comumente usado para valores monetários.
double doubleValue = 10.0001; //double é o tipo mais preciso para uso de ponto flutuante. 
Console.WriteLine($"int: {intValue}\ndecimal: {decimalValue}\ndouble: {doubleValue}");

DateTime today = DateTime.Now; //08/08/2024 20:04:09
Console.WriteLine($"date today: {today}");

//Combined Assignment Operators:
int value = 15;
//recebe ele mesmo mais a operação aritemetica realizada.
Console.WriteLine($"{value += 2}");
Console.WriteLine($"{value -= 2}");
Console.WriteLine($"{value /= 2}");
Console.WriteLine($"{value *= 2}");
Console.WriteLine($"{value %= 2}");

//Cast - Casting:
value = Convert.ToInt32("32");
Console.WriteLine($"string to int: {value.GetType()}");

double newValue = 10.001;
string sValue = Convert.ToString(newValue);
Console.WriteLine($"int to string: {sValue} {sValue.GetType()}");

//int a = Convert.ToInt32(null);//resulta em 0, preferivel uso do Convert.
//int a = int.Parse(null);//resulta em erro

//Para conversão de valores de qualquer tipo a variavel já possui um metodo herdado .ToString(), sendo preferivel usar *variavel.ToString()*
Console.WriteLine($"{value}|{value.GetType()} .ToString → {value.ToString()}|{value.ToString().GetType()}");

//implicitly convert:
int i = 10;
double d = i;
Console.WriteLine($"um valor int possui um tamanho aceitavel para double, por isso é aceito: {d}");

string a = "10";
int.TryParse(a, out int b);

Console.WriteLine("TryParse: ", b);

//tipo enum: forma de definir um conjunto de valores constantes 
enum DiaDaSemana
{
    Domingo,
    Segunda,
    Terça,
    Quarta,
    Quinta,
    Sexta,
    Sabado
}

//operadores de comparação:
bool boolean = 1 <= 10;//menor ou igual
Console.WriteLine(boolean);

boolean = 1 >= 10;//maior ou igual
Console.WriteLine(boolean);

boolean = 1 == 10;//igual
Console.WriteLine(boolean);

boolean = 1 != 10;//diferente
Console.WriteLine(boolean);


//operadores condicionais:
int estoque = 10;
int carrinhoCompra = 5;

if (carrinhoCompra < estoque) {
    Console.WriteLine("Venda concluida com sucesso!");
}
else if (carrinhoCompra == estoque) {
    Console.WriteLine("Venda não autorizada! Estoque será zerado.");
}
else {
    Console.WriteLine("Venda cancelada! Quantidade de compra maior que estoque.");
}
*/
//operadores logicos:
// OR == || // AND == &&

//swithc case: para verificar valores

//operadores aritméticos
//precedência dos operadores aritméticos: +, -, *, /, %
/*
Console.WriteLine("Digite 2 valores para calcular potência:");
double n1 = Convert.ToDouble(Console.ReadLine());
double n2 = Convert.ToDouble(Console.ReadLine());
//utilizando potencia e arredondamento:
Console.WriteLine($"Potência = {Math.Round(Math.Pow(n1, n2), 2)}");


Console.WriteLine("Digite um valor para calcular a raiz quadrada:");
double n = Convert.ToDouble(Console.ReadLine());
//utilizando potencia e arredondamento:
Console.WriteLine($"Raiz quadrada = {Math.Sqrt(n)}");
*/
/*
//pos-incremento 
int i = 0;
i++; 
Console.WriteLine(i);
//pre-incremento 
i = 0;
++i; 
Console.WriteLine(i);

//Loops:
// for: Ideal para quando você precisa de um contador ou sabe o número exato de iterações.
// while: Útil quando o número de iterações não é conhecido antecipadamente, mas depende de uma condição.
// do-while: Usado quando o bloco de código deve ser executado pelo menos uma vez, independentemente da condição.
// foreach: Melhor para iterar sobre coleções, como arrays ou listas, de maneira simples e segura.

Console.WriteLine("Digite um numero para ver sua tabuada:");
int number = Convert.ToInt32(Console.ReadLine());

for (int i=1; i<=10; i++) {
    Console.WriteLine($"{number} x {i} = {number*i}");
}
*/

//Arrays:

