
using DataStructures.Nodes;

namespace DataStructures
{
    namespace Lists
    {
        public class IList
        {
            public enum SortDirection : int
            {
                Asc = 1,
                Desc = 2,
            }

            public bool descending = false;
            public NodeDoublyLinkedList first;
            public NodeDoublyLinkedList middle;

            public int len = 0;




            public IList(int data)
            {
                first = new();
                first.Data = data;
                middle = first;
                len = 1;
            }

            public IList()
            {
                middle = first; //This is the empty constructor.
            }

            public void Display(string msg)
            {
                System.Console.WriteLine(msg);
                System.Console.Write('[');
                DisplayAux(first);
                System.Console.WriteLine(']');
            }
            public void Display()
            {
                System.Console.Write('[');
                DisplayAux(first);
                System.Console.WriteLine(']');
            }
            public void DisplayAux(NodeDoublyLinkedList first)
            {
                if (first != null)
                {
                    System.Console.Write($"({first.Data})<->");
                    DisplayAux(first.next);
                }
            }
            public NodeDoublyLinkedList FindLastNode(NodeDoublyLinkedList first)
            {
                if (first.next == null)
                {
                    return first;
                } 
                else
                {
                    return FindLastNode(first.next);
                }
            }

            public NodeDoublyLinkedList[] FindNodeAt(NodeDoublyLinkedList first, int pos, int i, NodeDoublyLinkedList previousNode)
            {
                if (i < pos)
                {
                    if (i == pos - 1)
                    {
                        previousNode = first;
                        return FindNodeAt(first.next, pos, i+1, previousNode);
                    }
                    if (first.next != null)
                    {
                        return FindNodeAt(first.next, pos, i+1, previousNode);
                    }
                    System.Console.WriteLine("Index out of range in AddNodeAt/FindNodeAt.");
                    return null;
                } 
                else
                {
                    NodeDoublyLinkedList[] res = new NodeDoublyLinkedList[2];
                    res[0] = previousNode;
                    res[1] = first;
                    return res; //Returns [node at pos-1, node at pos]
                }
            }
            public int FindNodeAtValue(NodeDoublyLinkedList first, int data, int i, NodeDoublyLinkedList previousNode)
            {
                if (first == null)
                {
                    System.Console.WriteLine("Data not found at LinkedList.FindNodeAtValue. Data: " + data);
                    return -1;
                }
                if (first.Data.Equals(data))
                {
                    return i; //Returns index of node with data.
                }
                else
                {
                    previousNode = first;
                    return FindNodeAtValue(first.next, data, i+1, previousNode);

                }
            }
            
            private void AddNode(NodeDoublyLinkedList node)
            {
                if (first == null)  // When list is empty
                {
                    first = node;
                    len ++;
                    middle = first;
                    return;
                }
                NodeDoublyLinkedList lastNode = FindLastNode(first);
                lastNode.next = node;
                node.previous = lastNode;
                len ++;
                if ((node.Data <= middle.Data) ^ descending)
                    {
                        if (len % 2 == 1)
                        {
                            middle = middle.previous;   // ERROR WHEN LIST IS EMPTY
                        }    
                    }
                else
                {
                    if (len % 2 == 0)
                    {
                        middle = middle.next;
                    }    
                }
            }
            public void Add(int data)
            {
                AddNode(new NodeDoublyLinkedList(data));
            }

            private void AddNodeAt(NodeDoublyLinkedList node, int pos)
            {
                NodeDoublyLinkedList[] nodeAtAndPrevious = FindNodeAt(first, pos, 0, null);
                node.next = nodeAtAndPrevious[1];
                nodeAtAndPrevious[1].previous = node;
                len ++;
                
                if (nodeAtAndPrevious[0] != null) //i.e. pos > 0.
                {
                    nodeAtAndPrevious[0].next = node;
                    node.previous = nodeAtAndPrevious[0];
                }
                else
                {
                    // System.Console.WriteLine("ENTRO AQUI POS == 0 EN AddNodeAt.");
                    first = node;    
                }
                
                if ((node.Data <= middle.Data) ^ descending)
                    {
                        if (len % 2 == 1)
                        {
                            middle = middle.previous;   // ERROR WHEN LIST IS EMPTY
                        }    
                    }
                    else
                    {
                        if (len % 2 == 0)
                        {
                            middle = middle.next;
                        }
                    }


            }

            public void AddAt(int data, int pos)
            {
                AddNodeAt(new NodeDoublyLinkedList(data), pos);
            }
            
            /// <summary>
            /// Deletes last element.
            /// </summary>
            public void Delete()
            {
                DeleteAt(len - 1);
            }
            public void DeleteAt(int pos)
            {
                if (len == 0)
                {
                    System.Console.WriteLine("LIST IS ALREADY EMPTY at LinkedList.DeleteAt.");
                    return;
                }
                if (pos >= len )
                {
                    System.Console.WriteLine("Index out of range in DeleteAt.");
                    //RETURN!!!!!!!!????????ERROR??
                }
                if (pos == 0)
                {
                    if (len >= 1)
                    {
                        if (first == middle)
                        {
                            middle = first.next;
                        }
                        first = first.next;
                        if (first != null)
                        {
                            first.previous = null;    
                        }
                        len --;
                        if (len % 2 == 1)
                        {
                            middle = middle.previous;
                        }
                    }
                    return;
                }
                NodeDoublyLinkedList[] nodeAtAndPrevious = FindNodeAt(first, pos, 0, null);
                nodeAtAndPrevious[0].next = nodeAtAndPrevious[1].next;
                if (nodeAtAndPrevious[1].next != null)
                {
                    nodeAtAndPrevious[1].next.previous = nodeAtAndPrevious[0];    
                }
                
                len --;
                if (len % 2 == 1)
                {
                    middle = middle.previous;
                }
            }

            public bool DeleteValue(int data)
            {
                int foundAt = FindNodeAtValue(first, data, 0, null);
                if (foundAt == -1)
                {
                    return false;
                }
                
                DeleteAt(foundAt); 
                return true;
            }

            public int FindAt(int pos)
            {
                NodeDoublyLinkedList[] nodeAtAndPrevious = FindNodeAt(first, pos, 0, null);
                return nodeAtAndPrevious[1].Data;
            }
            public int FindLast()
            {
                return FindAt(len-1);
            }

            public void SetAt(int data, int pos)
            {
                FindNodeAt(first, pos, 0, null)[1].Data = data;
            }

            public bool IsEmpty()
            {
                if (len == 0)
                {
                    return true;
                }
                return false;
            }

            public int Size()
            {
                return len;
            }














            public void InsertInOrder(int value)
            {
                InsertInOrderAux(value, first, 0);
            }
            private void InsertInOrderAux(int value, NodeDoublyLinkedList first, int i)
            {
                if (first == null)
                {
                    Add(value);
                    return;
                }
                if ((value <= first.Data) ^ descending)
                {
                    AddAt(value, i);
                    return;
                }
                InsertInOrderAux(value, first.next, i+1);
            }

            public int DeleteFirst()
            {
                if (len == 0)
                {
                    System.Console.WriteLine("Error DeleteFirst on empty list!");
                    return -1;  // -1 is a possible value and can't be taken as an error.
                }
                int result = first.Data;
                DeleteAt(0);
                return result;
            }
 
            /// <summary>
            /// Deletes last element and returns its value.
            /// </summary>
            public int DeleteLast()
            {
                if (len == 0)
                {
                    System.Console.WriteLine("Error DeleteLast on empty list!");
                    return -1;  // -1 is a possible value and can't be taken as an error.
                }
                int result = FindLast();
                Delete();
                return result;
            }

            public int GetMiddle()
            {
                return middle.Data;
            }

            public void Invert()
            {
                NodeDoublyLinkedList first_aux = FindNodeAt(first, len-1, 0, null)[1];
                NodeDoublyLinkedList current_node = first;
                for (int i = 0; i < len; i++)
                {
                    NodeDoublyLinkedList aux_node = current_node.next;
                    current_node.next = current_node.previous;
                    current_node.previous = aux_node;
                    current_node = current_node.previous;
                }
                first = first_aux;
                if (len % 2 == 0)
                {
                    middle = middle.next;
                }
                descending ^= true;
            }

            public void MergeSorted(IList listA, IList listB, SortDirection direction)
            {
                SortDirection listA_direction = SortDirection.Asc;
                if (listA.descending)
                {
                    listA_direction = SortDirection.Desc;
                }
                if (listA_direction != direction)
                {
                    listA.Invert();
                }
                
                int listB_size = listB.Size();
                for (int i = 0; i < listB_size; i++)
                {
                    listA.InsertInOrder(listB.FindAt(i));
                    // listA.Display();
                }
            }

        }
    }
}