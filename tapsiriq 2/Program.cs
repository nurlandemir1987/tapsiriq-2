namespace tapsiriq_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("birinci reqem :");
            int a = int.Parse(Console.ReadLine());
            Console.Write("ikinci reqem :");
            int b = int.Parse(Console.ReadLine());
            Console.Write($"{a} ededinin / {b} ededine bolunmesinden alinan qaliq = {a % b}");
        }   
    }
}