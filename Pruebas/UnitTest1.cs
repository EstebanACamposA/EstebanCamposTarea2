using DataStructures.Lists;

namespace Pruebas;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMergeSorted()
    {
        // Instantiate list_a
        IList list_a = new(2);
        // Initializes list_a with even numbers.
        for (int i = 5; i <= 9; i++)
        {
            list_a.InsertInOrder(i*2);
        }
        // Displays the list and its size.
        list_a.Display();
        System.Console.WriteLine("list_a.Size() = " + list_a.Size());

        System.Console.WriteLine();
        System.Console.WriteLine();

        // Instantiate list_b
        IList list_b = new(1);
        // Initializes list_a with k*3 numbers and a 1.
        for (int i = -5; i <= 1; i++)
        {
            list_b.InsertInOrder(i*3);
        }
        // Displays the list and its size.
        list_b.Display();
        System.Console.WriteLine("list_b.Size() = " + list_b.Size());

        System.Console.WriteLine();
        System.Console.WriteLine();



        // Merges both lists into list_a.
        IList.SortDirection descending_direction = IList.SortDirection.Desc;
        list_a.MergeSorted(list_a, list_b, descending_direction);
        // Displays list_a and its size.
        list_a.Display("list_a merged with list_b");
        System.Console.WriteLine("list_a.Size() = " + list_a.Size());

        System.Console.WriteLine();
        System.Console.WriteLine();



        // Proves the merge was succesful by checking that the elements are in the correct order.
        bool test_succesful = true;

        // sort_direction = true --> ascending
        // sort_direction = false --> descending
        bool sort_direction = true;
        if (descending_direction == IList.SortDirection.Desc)
        {
            sort_direction = false;
        }

        int size = list_a.Size();
        for (int i = 0; i < size -1; i++)
        {
            int current = list_a.FindAt(i);
            int next = list_a.FindAt(i+1);
            if (current != next & (current < next ^ sort_direction))
            {
                test_succesful = false;
            }
        }
        Assert.IsTrue(test_succesful);
    }


    [TestMethod]
    public void TestInvert()
    {
        // Instantiate list
        IList list = new(1);
        // Initializes list with some values. list = [1,2,3,4]
        for (int i = 2; i <= 4; i++)
        {
            list.Add(i);
        }
        // Displays the list and its orientation.
        list.Display();
        System.Console.WriteLine("s.descending = " + list.descending);

        System.Console.WriteLine();
        


        // Inverts the list.
        list.Invert();
        list.Display("inverts.");
        System.Console.WriteLine("s.GetMiddle() = " + list.GetMiddle());
        System.Console.WriteLine("s.descending = " + list.descending);



        // Adds elements greater than max, less than min and within the range.
        list.InsertInOrder(88);
        list.Display();
        list.InsertInOrder(3);
        list.Display();
        list.InsertInOrder(-8);
        list.Display();

        // Proves the inversion was succesful by checking that the elements are in the correct order.
        bool test_succesful = true;

        // sort_direction = true --> ascending
        // sort_direction = false --> descending
        bool sort_direction = true;
        if (list.descending)
        {
            sort_direction = false;
        }

        int size = list.Size();
        for (int i = 0; i < size -1; i++)
        {
            int current = list.FindAt(i);
            int next = list.FindAt(i+1);
            if (current != next & (current < next ^ sort_direction))
            {
                test_succesful = false;
            }
        }
        Assert.IsTrue(test_succesful);




    }


    [TestMethod]
    public void TestMiddle()
    {
        
        // MIDDLE TEST - MIDDLE TEST - MIDDLE TEST - MIDDLE TEST - MIDDLE TEST - MIDDLE TEST
        // This tests consists in adding elements on the right and left of the list repeatedly.
        //If the length is even and starts adding an element on the right, the middle should not change.
        //If starts with the left OR was not even and starts with the right, the middle should change with each insertion.
        //Also checks that the middle when length == 1 is the element of the list.
        bool test_succesful = true;

        IList list = new(0);
        list.Display();
        System.Console.WriteLine("list.GetMiddle() = " + list.GetMiddle());
        System.Console.WriteLine("list.descending = " + list.descending);
        int current_middle = list.GetMiddle();
        if (current_middle != list.FindAt(0))
        {
            test_succesful = false;
        }
        Assert.IsTrue(test_succesful);

        System.Console.WriteLine();

        for (int i = 0; i < 3; i++) //List starts with odd amount of elements. Starts adding to the right.
        {
            list.InsertInOrder((list.FindLast() + 1) * (int)Math.Pow(-1,i));
            if (list.GetMiddle() == current_middle)
            {
                test_succesful = false;
            }
            current_middle = list.GetMiddle();
        }
        Assert.IsTrue(test_succesful);

        for (int i = 0; i < 3; i++) //List starts with even amount of elements. Starts adding to the right.
        {
            list.InsertInOrder((list.FindLast() + 1) * (int)Math.Pow(-1,i));
            if (list.GetMiddle() != current_middle)
            {
                test_succesful = false;
            }
            current_middle = list.GetMiddle();
        }
        Assert.IsTrue(test_succesful);

        // List has an odd amount of elements. If a new element is added to the right, the middle should change.
        //If more elements are added to the right, the middle should change every two elements.

        bool counter = true;   // This makes the check happen every two interations
        for (int i = 0; i < 3; i++)
        {
            list.InsertInOrder(list.FindLast() + 1);
            if (counter & list.GetMiddle() == current_middle)
            {
                test_succesful = false;
            }
            current_middle = list.GetMiddle();
            counter ^= true;
        }
        Assert.IsTrue(test_succesful);

        // List has an even amount of elements. If the elements near the middle are different, which they are,
        //inverting the list should result in the middle element changing position.

        list.Invert();
        if (list.GetMiddle() == current_middle)
        {
            test_succesful = false;
        }
        current_middle = list.GetMiddle();
        Assert.IsTrue(test_succesful);

        // Repeats test with inverted list
        for (int i = 0; i < 3; i++) //List starts with even amount of elements. Starts adding to the right.
        {
            list.InsertInOrder((list.FindLast() - 1) * (int)Math.Pow(-1,i));
            if (list.GetMiddle() != current_middle)
            {
                test_succesful = false;
            }
            current_middle = list.GetMiddle();
        }
        Assert.IsTrue(test_succesful);

        // Repeats test with inverted list
        for (int i = 0; i < 3; i++) //List starts with odd amount of elements. Starts adding to the right.
        {
            list.InsertInOrder((list.FindLast() - 1) * (int)Math.Pow(-1,i));
            if (list.GetMiddle() == current_middle)
            {
                test_succesful = false;
            }
            current_middle = list.GetMiddle();
        }

        Assert.IsTrue(test_succesful);

    }
}