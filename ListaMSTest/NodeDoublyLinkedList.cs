using System;
namespace DataStructures
{
    namespace Nodes
    {
        public class NodeDoublyLinkedList : Node<int>
        {
            public NodeDoublyLinkedList next;
            public NodeDoublyLinkedList previous;

            public NodeDoublyLinkedList(){}
            public NodeDoublyLinkedList(int data)
            {
                Data = data;
            }
            // public NodeDoublyLinkedList(int data, NodeLinkedList<T> next)    //CONSTRUCTOR THAT SETS NEXT NODE. NOT PREVIOUS.
            // {
            //     Data = data;
            //     this.next = next;
            // }

            // public new NodeDoublyLinkedList DeepCopy()   //DeepCopy CODE NOT FINISHED.
            // {
            //     NodeDoublyLinkedList new_node = new(Data);

            //     if(next != null)
            //     {
            //         new_node.next = this.next.DeepCopy();
            //     }
            //     return new_node;
            // }


            public override void Display()
            {
                string _next = next != null ? $"{next.Data}" : "null";
                Console.WriteLine($"({Data})->({_next})\n");
            }
            
        }
    }
}