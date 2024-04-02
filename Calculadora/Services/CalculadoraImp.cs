namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int ContarCaracteres(string texto)
        {
            int quantidadeCaracteres = texto.Length;
            return quantidadeCaracteres;
        }

        public bool IdentificarNumeroPar(int num)
        {
            return num % 2 == 0;
        }

        public bool IdentificarNumeroImpar(int num)
        {
            return num % 2 == 1;
        }
    }
}