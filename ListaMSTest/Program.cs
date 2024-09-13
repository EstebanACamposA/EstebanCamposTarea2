using DataStructures.Lists;

namespace app
{
    public class Program
    {
        static void Main(string[] args)
        {
            // IList a = new(1);
            // for (int i = 2; i <= 10; i++)
            // {
            //     a.Add(i);
            // }
            // a.Display();
            // System.Console.WriteLine("a.middle.Data = " + a.middle.Data);

            // System.Console.WriteLine();

            // System.Console.WriteLine("a.len = " + a.len);
            // for (int i = 9; i > 0; i--)
            // { 
            //     NodeDoublyLinkedList node_i = a.FindNodeAt(a.first, i, 0, null)[1];
            //     System.Console.WriteLine("node_i.Data = " + node_i.Data);
            //     System.Console.WriteLine("node_i.previous.Data = " + node_i.previous.Data);
            // }

            // System.Console.WriteLine();

            // // Empty list and call GetMiddle() (returns an excepption).
            // // for (int i = 0; i < 10; i++)
            // // {
            // //     a.Delete();
            // //     a.Display();
            // //     System.Console.WriteLine("a.len = " + a.len);
            // //     System.Console.WriteLine("a.GetMiddle() = " + a.GetMiddle());
            // //     System.Console.WriteLine();
            // // }


            // a.Display("a is going to invert. a is... ");
            // System.Console.WriteLine("a.len = " + a.len);
            // a.Invert();
            // a.Display();
            // System.Console.WriteLine("inverted a.len = " + a.len);


            // INVERT TEST - INVERT TEST - INVERT TEST - INVERT TEST - INVERT TEST
            // IList s = new(1);
            // for (int i = 2; i <= 4; i++)
            // {
            //     s.Add(i);
            // }
            // s.Display();
            // System.Console.WriteLine("s.GetMiddle() = " + s.GetMiddle());
            // System.Console.WriteLine("s.descending = " + s.descending);

            // System.Console.WriteLine();
            
            // s.Invert();
            // s.Display("inverts.");
            // System.Console.WriteLine("s.GetMiddle() = " + s.GetMiddle());
            // System.Console.WriteLine("s.middle.next.Data = " + s.middle.next.Data);
            // System.Console.WriteLine("s.middle.previous.Data = " + s.middle.previous.Data);
            // System.Console.WriteLine("s.descending = " + s.descending);

            // s.InsertInOrder(88);
            // s.Display();
            // s.InsertInOrder(3);
            // s.Display();
            // s.InsertInOrder(-8);
            // s.Display();
            // System.Console.WriteLine("s.GetMiddle() = " + s.GetMiddle());
            // System.Console.WriteLine("s.middle.next.Data = " + s.middle.next.Data);
            // System.Console.WriteLine("s.middle.previous.Data = " + s.middle.previous.Data);
            // System.Console.WriteLine("s.descending = " + s.descending);



            // MIDDLE TEST - MIDDLE TEST - MIDDLE TEST - MIDDLE TEST - MIDDLE TEST - MIDDLE TEST
            // IList d = new(1);
            // for (int i = 2; i <= 4; i++)
            // {
            //     d.InsertInOrder(i);
            // }
            // d.Display();
            // System.Console.WriteLine("d.GetMiddle() = " + d.GetMiddle());
            // System.Console.WriteLine("d.descending = " + d.descending);

            // System.Console.WriteLine();
            // for (int i = 0; i < 1; i++)
            // {
            //     d.InsertInOrder((d.FindLast() + 1) * (int)Math.Pow(-1,i));      //THIS CAN BE A TEST FOR MIDDLE.
            //     d.Display();
            //     System.Console.WriteLine("d.GetMiddle() = " + d.GetMiddle());
            // }
            // d.InsertInOrder(7);
            // d.Display();
            // System.Console.WriteLine("d.GetMiddle() = " + d.GetMiddle());

            // System.Console.WriteLine();

            // d.Invert();
            // d.Display("inverts.");
            // System.Console.WriteLine("s.GetMiddle() = " + d.GetMiddle());
            // System.Console.WriteLine("s.middle.next.Data = " + d.middle.next.Data);
            // System.Console.WriteLine("s.middle.previous.Data = " + d.middle.previous.Data);
            // System.Console.WriteLine("s.descending = " + d.descending);

            // d.InsertInOrder(9);
            // d.Display();
            // System.Console.WriteLine("d.GetMiddle() = " + d.GetMiddle());
            // // d.InsertInOrder(3);
            // // d.Display();
            // // System.Console.WriteLine("d.GetMiddle() = " + d.GetMiddle());
            // d.InsertInOrder(-9);
            // d.Display();
            // System.Console.WriteLine("s.GetMiddle() = " + d.GetMiddle());
            // System.Console.WriteLine("s.middle.next.Data = " + d.middle.next.Data);
            // System.Console.WriteLine("s.middle.previous.Data = " + d.middle.previous.Data);
            // System.Console.WriteLine("s.descending = " + d.descending);

            // System.Console.WriteLine();

            // d.Invert();
            // d.Display("reverts.");
            // System.Console.WriteLine("s.GetMiddle() = " + d.GetMiddle());
            // System.Console.WriteLine("s.middle.next.Data = " + d.middle.next.Data);
            // System.Console.WriteLine("s.middle.previous.Data = " + d.middle.previous.Data);
            // System.Console.WriteLine("s.descending = " + d.descending);

            // d.InsertInOrder(100);
            // d.Display();
            // System.Console.WriteLine("d.GetMiddle() = " + d.GetMiddle());
            // d.InsertInOrder(200);
            // d.Display();
            // System.Console.WriteLine("d.GetMiddle() = " + d.GetMiddle());
            // d.InsertInOrder(-100);
            // d.Display();
            // System.Console.WriteLine("d.GetMiddle() = " + d.GetMiddle());
            // d.InsertInOrder(-200);
            // d.Display();
            // System.Console.WriteLine("d.GetMiddle() = " + d.GetMiddle());




            // MERGE TEST - MERGE TEST - MERGE TEST - MERGE TEST - MERGE TEST - MERGE TEST - MERGE TEST - MERGE TEST
            IList f = new(2);
            for (int i = 5; i <= 9; i++)
            {
                f.InsertInOrder(i*2);
            }
            f.Display();
            System.Console.WriteLine("f.GetMiddle() = " + f.GetMiddle());
            System.Console.WriteLine("f.descending = " + f.descending);
            System.Console.WriteLine("f.Size() = " + f.Size());
            

            System.Console.WriteLine();
            System.Console.WriteLine();

            IList g = new(1);
            for (int i = -5; i <= 1; i++)
            {
                g.InsertInOrder(i*3);
                // g.Display();
                // System.Console.WriteLine("g.GetMiddle() = " + g.GetMiddle());
                // if (g.middle.previous != null)
                // {
                //     System.Console.WriteLine("g.middle.previous.Data = " + g.middle.previous.Data);    
                // }
                // if (g.middle.next != null)
                // {
                //     System.Console.WriteLine("g.middle.next.Data = " + g.middle.next.Data);    
                // }
                // System.Console.WriteLine();
            }
            g.Display();
            System.Console.WriteLine("g.GetMiddle() = " + g.GetMiddle());
            System.Console.WriteLine("g.descending = " + g.descending);
            System.Console.WriteLine("g.Size() = " + g.Size());

            System.Console.WriteLine();

            f.MergeSorted(f,g,IList.SortDirection.Desc);
            f.Display();
            System.Console.WriteLine("f.GetMiddle() = " + f.GetMiddle());
            System.Console.WriteLine("f.descending = " + f.descending);
            System.Console.WriteLine("f.Size() = " + f.Size());

            System.Console.WriteLine();
        }
    }
}