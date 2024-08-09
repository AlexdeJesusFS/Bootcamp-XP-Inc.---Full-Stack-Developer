using prologue.Models;

//Class:
Person person1 = new Person();

person1.Name = "Lex";
person1.Age = 23;
person1.Show();

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

//precedência dos operadores aritméticos: +, -, *, /, %

string a = "10";
int.TryParse(a, out int b);

Console.WriteLine("TryParse: ", b);

/*operadores condicionais:

*/
bool boolean = 1 <= 10;
Console.WriteLine(boolean);

boolean = 1 >= 10;
Console.WriteLine(boolean);

boolean = 1 == 10;
Console.WriteLine(boolean);

//operadores lógicos:

