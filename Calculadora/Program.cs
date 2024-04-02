using Calculadora.Services;


CalculadoraImp c = new CalculadoraImp();

int num1 = 4;
int num2 = 1;
string texto = "Palavra";

Console.WriteLine($"{num1} + {num2} = {c.Somar(num1, num2)}");
Console.WriteLine($"{num1} - {num2} = {c.Subtrair(num1, num2)}");
Console.WriteLine($"{num1} / {num2} = {c.Dividir(num1, num2)}");
Console.WriteLine($"{num1} * {num2} = {c.Multiplicar(num1, num2)}");
Console.WriteLine($"A QUANTIDADE de letras do texto '{texto}' é {c.ContarCaracteres(texto)}");
Console.WriteLine($"O número {num1} é par? {c.IdentificarNumeroPar(num1)}");
Console.WriteLine($"O número {num1} é ímpar? {c.IdentificarNumeroImpar(num1)}");
Console.WriteLine($"O número {num2} é ímpar? {c.IdentificarNumeroImpar(num2)}");
Console.WriteLine($"O número {num2} é par? {c.IdentificarNumeroPar(num2)}");