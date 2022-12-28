namespace LinkedList
{
    class program
    {
        public static void Main(String[] args) 
        {
            Console.WriteLine("Welcome To Linked List Program ");
            Console.WriteLine("Choose a option from below\n" +
                "\nChoose 1): To Creating a linked list ");
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
                default:
                    Console.WriteLine("Choose a Valid Option");
                    break;
            }
        }
    }
}