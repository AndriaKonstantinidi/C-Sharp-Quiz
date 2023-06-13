class Program
{
    static void Main(string[] args)
    {
        //using(StreamWriter writer = new StreamWriter("test.txt"))
        //{
        //    writer.WriteLine("First test");
        //    writer.WriteLine("Second test");
        //}
        //using (StreamReader reader = new StreamReader("test.txt"))
        //{
        //    string Line = reader.ReadLine();
        //    string secondline = reader.ReadLine();
        //    Console.WriteLine(Line);
        //    Console.WriteLine(secondline);
        //}
        string[] questions = new string[]
        {
            "name of city?:Tbilisi",
            "name of city?:Tbilisi",
            "name of city?:Tbilisi"
        };
        using(StreamWriter qwrite = new StreamWriter("quiz.txt"))
        {
            foreach(string question in questions)
            {
                qwrite.WriteLine(question);
            }
        }

        string[] thinred = File.ReadAllLines("quiz.txt");

        foreach(string line in thinred)
        {
            var ss = line.Split(":");
            Console.WriteLine(ss[0]);
            var bb = Console.ReadLine();
            if(bb == ss[1])
            {
                Console.WriteLine("Correct");
            }
        }
    }
}