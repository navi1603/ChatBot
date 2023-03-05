
namespace ChatBot
{
    public class ChatBot
    {
        public static void Main (string[] args)
        {
            var tutor = new Tutor();
            tutor.AddWord("hello", "привет");
            tutor.AddWord("dog", "собака");
            tutor.AddWord("cat", "кот");

            while (true)
            {
                var word = tutor.GetRandomEngWord();
                Console.WriteLine($"Как переводится слово: {word}?");
                var userAnswer = Console.ReadLine();
                if (tutor.CheckWord(word, userAnswer))
                    Console.WriteLine("Привильно!");
                else
                {
                    var correctAnswer = tutor.Translate(word);
                    Console.WriteLine($"Неверною Правильный ответ: {correctAnswer}");
                }
                   

            }
        }
    }
}
