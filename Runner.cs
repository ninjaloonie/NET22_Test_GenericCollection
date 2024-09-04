using FinalExam;

namespace GenericCollectionItem
{
    public class Runner
    {
        public static void Main(string[] args)
        {
            TestCollection<int> items = new TestCollection<int>();
            Random random = new Random();
            for (int i = 1; i < 10; i++)
            {
                items.Add(random.Next(99));
            }

            foreach(int i in items.ListDescending())
            {
                Console.WriteLine(i);
            }
        }
    }
}
