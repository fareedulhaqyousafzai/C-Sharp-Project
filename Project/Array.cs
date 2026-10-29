using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public static class Array
{
    public static void ArrayExp()
    {
        int[] myArray = new int[3];

        myArray[0] = 10;
        myArray[1] = 20;
        myArray[2] = 30;

       
        System.Array.Resize(ref myArray, 4);
        myArray[3] = 40;

       
        Console.WriteLine("--- Loop ke zariye ---");
        foreach (int num in myArray)
        {
            Console.WriteLine(num);
        }

   
        Console.WriteLine("\n--- Shortcut ke zariye ---");
        Console.WriteLine("My Numbers: " + string.Join(", ", myArray));
    }
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

    internal static void MyArrayList()
    {
        ArrayList MyList = new ArrayList();
        Console.WriteLine(MyList.Capacity);

        MyList.Add(10);
            MyList.Add(20);
            MyList.Add(30);
            MyList.Add(40);

            Console.WriteLine(MyList.Capacity);
            MyList.Add(60);
            Console.WriteLine(MyList.Capacity);

        foreach (object obj in MyList)
        {
            Console.Write(obj + " ");
         s
        }
        MyList.Insert(2, 25);

          foreach (object obj in MyList)
        {
            Console.Write(obj + " ");
          
        }


      
        MyList.Remove(40);
        foreach (object obj in MyList)
        {
            Console.Write(obj + " ");
       
        }
    }

    }

    
