namespace LinkedList
{
    class program
    {
        public static void Main(String[] args) 
        {
            Console.WriteLine("Welcome To Linked List Program ");
            Console.WriteLine("===============================");
            Console.WriteLine("Choose a option from below\n" +
                "\nChoose 1): To Creating a linked list \n" +
                "Choose 2): To Creating a linked list \n");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Linkedlist linkedList = new Linkedlist();
                    linkedList.Add(56);
                    linkedList.Add(30);
                    linkedList.Add(70);
                    linkedList.Display();
                    break;
                case 2:
                    Linkedlist linkedlist = new Linkedlist();
                    linkedlist.AddFirst(70);
                    linkedlist.AddFirst(30);
                    linkedlist.AddFirst(56);
                    linkedlist.Display();
                    break;
                default:
                    Console.WriteLine("Choose a Valid Option");
                    break;
            }
        }
    }
}