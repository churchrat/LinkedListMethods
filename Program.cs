namespace LinkedListMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> nums = new LinkedList<int>();
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                nums.AddLast(random.Next(100));
            }
            Console.WriteLine(CounterLinkedList(nums));
            Console.WriteLine("====================================================================");
            string[] arrNames = { "John", "Viktor", "Ivan", "Georgi", "Michael" };
            LinkedList<string> names = new LinkedList<string>(arrNames);
            LinkedStringsContains(names);
            Console.WriteLine("====================================================================");
            int[] arrNums = {1,2,4,5};
            LinkedList<int> ints = new LinkedList<int>(arrNums);
            LinkedListNode<int> two = ints.Find(2);
            if (two != null)
            {
                ints.AddAfter(two,3);
            }
            foreach (int item in ints)
            {
                Console.WriteLine(item);
            }
        }
        static int CounterLinkedList(LinkedList<int> nums)
        {
            LinkedListNode<int> currNode = nums.First;
            int count = 0;
            while (currNode != null)
            {
                count++;
                currNode = currNode.Next;
            }
            return count;
        }
        static void LinkedStringsContains(LinkedList<string> names)
        {
            Console.Write("What name are you searching:");
            string search = Console.ReadLine();
            if (names.Contains(search))
            {
                Console.WriteLine($"names contains the name {search}!");
            }
            else
            {
                Console.WriteLine($"names doesnt contain the name {search}!");
            }
        }
    }
}
