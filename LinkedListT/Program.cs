using System;
using System.Text;
using System.Collections.Generic;

public class LinkedList
{
    public static void Main()
    {
        // Create the link list.
        string[] food =
            { "Pizza", "Stromboli", "French Fries", "Chesseburger", "Apple"};
        LinkedList<string> foodList = new LinkedList<string>(food);

        Console.WriteLine("The first node in the list is: {0}.",foodList.First.Value);
        Console.WriteLine("The last node in the list is: {0}.", foodList.Last.Value);

        LinkedListNode<string> targetLocation = foodList.Find("French Fries");
        foodList.AddBefore(targetLocation, "Grapes");

        Console.WriteLine();
        
        foodList.RemoveFirst();

        Console.WriteLine("Afer removing Pizza from the linked list & adding Grapes before French Fries, there are now {0} food items", foodList.Count);
        Console.WriteLine("");
        
        foreach (string foods in foodList)
        {
            Console.WriteLine(foods);
        }
    }

}
