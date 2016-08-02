namespace SinglyLinkedList
{
    using System;

    class Program
    {
        static void Main()
        {


            LinkedList<int> numbers = new LinkedList<int>() {3, 5, 7};
            numbers.AddFirst(9);
            numbers.AddLast(1);
            numbers.AddFirst(9);
            numbers.RemoveFirst();
            numbers.AddLast(1);
            numbers.RemoveLast();

            PrintList(numbers.Head);
            Console.ReadLine();
        }

        private static void PrintList<T>(LinkedListNode<T> node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
