using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("Hello Sandbox World!");
        
        

        //All the code below was written to prepare for Week 3 Interview Question


        
        var set1 = new HashSet<int>();
        var set2 = new HashSet<int>();
        set1.Add(2);
        set1.Add(1);
        set1.Add(3);
        set1.Add(4);
        set2.Add(3);
        set2.Add(4);
        set2.Add(5);
        set2.Add(6);
        set2.Add(2);
        var unionized = Unionize(set1, set2);
        var intersected = Intersection(set1, set2);
        
        foreach (int i in intersected) {
            Console.WriteLine(i);
        }
        Console.WriteLine("guh");
        foreach (int i in unionized) {
            Console.WriteLine(i);
        }
        
    }
    static HashSet<int> Intersection (HashSet<int> set1, HashSet<int> set2) {
        var finalSet = new HashSet<int>();
        foreach (int number in set2) {
            if (set1.Contains(number)) {
                finalSet.Add(number);
            }
        }
        return finalSet;
    }   
    static HashSet<int> Unionize (HashSet<int> set1, HashSet<int> set2) {
        var finalSet = new HashSet<int>();
        int[] tmpSet = new int[set1.Count];
        set1.CopyTo(tmpSet);
        finalSet = tmpSet.ToHashSet();
        foreach (int number in set2) {
            finalSet.Add(number);
        }
        return finalSet;
    }
}