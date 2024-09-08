namespace ConsoleApp.Questions
{
    public static class FirstQuestion
    {
        public static void Execute()
        {
            int indice = 12, soma = 0, k = 1;

            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
            }

            Console.WriteLine($"Valor: {soma}");
        }
    }
}
