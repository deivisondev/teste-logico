namespace ConsoleApp.Questions
{
    public static class SecondQuestion
    {
        public static void Execute()
        {
            int a = CalculateFirstSequence(1, 5);
            int b = CalculateSecondSequence(2, 7);
            int c = CalculateThirdSequence(0, 8);
            int d = CalculateFourthSequence(5);
            int e = CalculateFifthSequence(7);
            int f = CalculateSixthSequence();

            Console.WriteLine($"a) {a}\nb) {b}\nc) {c}\nd) {d}\ne) {e}\nf) {f}");
        }

        private static int CalculateFirstSequence(int initialValue, int elementPosition)
        {
            int result = initialValue;

            for (int i = 1; i < elementPosition; i++)
            {
                result += 2;
            }

            return result;
        }

        private static int CalculateSecondSequence(int initialValue, int elementPosition)
        {
            int result = initialValue;

            for (int i = 1; i < elementPosition; i++)
            {
                result *= 2;
            }

            return result;
        }

        private static int CalculateThirdSequence(int initialValue, int elementPosition)
        {
            int result = initialValue;

            for (int i = initialValue; i < elementPosition; i++)
            {
                result = i * i;
            }

            return result;
        }

        private static int CalculateFourthSequence(int elementPosition)
        {
            int result = 0;
            int multiplier = 2;

            for (int i = 0; i < elementPosition; i++)
            {
                result = multiplier * multiplier;
                multiplier += 2;
            }

            return result;
        }

        private static int CalculateFifthSequence(int elementPosition)
        {
            int[] fibonacciSequence = new int[elementPosition];

            if (elementPosition > 0) fibonacciSequence[0] = 1;
            if (elementPosition > 1) fibonacciSequence[1] = 1;

            for (int i = 2; i < elementPosition; i++)
            {
                fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
            }

            return fibonacciSequence[elementPosition - 1];
        }

        private static int CalculateSixthSequence()
        {
            return 200;
        }
    }
}
