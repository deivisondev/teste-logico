using ConsoleApp.Questions;

namespace ConsoleApp
{
    public static class Menu
    {
        public static bool Closed = false;

        public static void ShowOptions()
        {
            string line = new string('=', 10);
            string header = $"{line} Respostas {line}";
            string content = string.Empty;

            for (int i = 1; i <= 5; i++)
            {
                content += $"- Questão {i}\n";
            }

            content += "(0 para encerrar)\n";

            string template = $"{header}\n{content}\n> Digite o número da questão que deseja ver a resposta: ";

            Console.Clear();
            Console.Write(template);
        }

        public static void Execute()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    Closed = true;
                    break;

                case "1":
                    FirstQuestion.Execute();
                    WaitingToPress();
                    break;

                case "2":
                    SecondQuestion.Execute();
                    WaitingToPress();
                    break;

                case "3":
                    ThirdQuestion.Execute();
                    WaitingToPress();
                    break;

                case "4":
                    Console.WriteLine(input);
                    WaitingToPress();
                    break;

                case "5":
                    Console.WriteLine(input);
                    WaitingToPress();
                    break;

                default:
                    return;
            }
        }

        private static void WaitingToPress()
        {
            Console.WriteLine("\nPressione uma tecla para voltar...");
            Console.ReadKey();
        }
    }
}
