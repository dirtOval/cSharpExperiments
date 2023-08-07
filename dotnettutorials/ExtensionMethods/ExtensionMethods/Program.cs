namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OldClass obj = new OldClass();
            obj.Test1();
            obj.Test2();
            obj.Test3();
            obj.Test4(100);
            obj.Test5();
            Console.WriteLine("What is your favorite saying?");
            string favoriteSaying = Console.ReadLine();
            int wordCount = favoriteSaying.GetWordCount();
            Console.WriteLine($"Your favorite saying has {wordCount} words!");
        }
    }
}