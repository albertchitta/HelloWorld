using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Y'all!!");

            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();
            Console.WriteLine($"Howdy {name}!");

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Random rand = new Random();
            int index = rand.Next(animals.Length);
            Console.WriteLine($"Would you like to have a {color} {animals[index]}?");

            Console.ReadKey(); // What happens if you run the app without this line?

            foreach (var animal in animals)
            {
                if (animal.Length >= 5)
                {
                    Console.WriteLine(animal);
                }
            }

            Console.WriteLine("Pick a language to see it's greeting: French, Chinese, Spanish, or Southern.");
            string answer = Console.ReadLine(); // Returns a string

            if (answer.ToLower() == "french")
            {
                Console.WriteLine("Bonjour!");
            }
            else if (answer.ToLower() == "chinese")
            {
                Console.WriteLine("Ni hao!");
            }
            else if (answer.ToLower() == "spanish")
            {
                Console.WriteLine("Hola!");
            }
            else
            {
                Console.WriteLine("Howdy Ya'll!");
            }

            //ConsoleKeyInfo enteredKey;

            //do
            //{
            //    enteredKey = Console.ReadKey();
            //    Console.WriteLine($"You pressed the {enteredKey.Key.ToString()} key");

            //} while (enteredKey.Key != ConsoleKey.Escape);

            //string sentence;

            //do
            //{
            //    Console.WriteLine("Type in a sentence. Press enter when done.");
            //    sentence = Console.ReadLine();
            //    Console.WriteLine($"You entered the sentence: {sentence}");
            //} while (sentence != "quit");
        }
    }
}
