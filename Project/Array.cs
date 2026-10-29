using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

internal static class Array
{
    internal static void ArrayExample()
    {
        string[] names = { "Fareed", "Ahmed", "Sultan" };
        Console.WriteLine("Array elements:");
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        Console.WriteLine("For Each Loops:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

    }
    internal static void ArrayStudentNames()
    {
        List<string> names = new List<string>();
        names.Add("Fareed");
        names.Add("Basheer");
        names.Add("Nazeer");

        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine((i + 1) + " " + names[i]);
        }


    }
    internal static void ListOfArray()
    {
        ArrayList newarraylist = new ArrayList();
        {

            newarraylist.Add("Fareed");
            newarraylist.Add(15);

            Console.WriteLine("Name:" + newarraylist[0] + " " + "Age:" + newarraylist[1]);
        }
    }
}
    
