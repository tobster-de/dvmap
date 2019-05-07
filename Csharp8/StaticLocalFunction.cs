using System;

namespace App
{
    class StaticLocalFunction
    {
        public void MethodWithStaticLocalFunction(int input)
        {
            Console.WriteLine($"Inside MethodWithStaticLocalFunction, input: {input}.");
            StaticLocalFunction(input);

            // input variable is not captured
            static void StaticLocalFunction(int input)
            {
                Console.WriteLine($"Inside StaticLocalFunction, input: {input}.");
            }
        }

        public void MethodWithLocalFunction(int input)
        {
            Console.WriteLine($"Inside MethodWithLocalFunction, input: {input}.");
            LocalFunction();

            // input variable is automatically captured
            void LocalFunction()
            {
                Console.WriteLine($"Inside LocalFunction, input: {input}.");
            }
        }
    }
}
