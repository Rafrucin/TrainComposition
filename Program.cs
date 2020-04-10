using System;
using System.Collections.Generic;

public class TrainComposition
{
    public LinkedList<int> wagons { get; set; } = new LinkedList<int>();
    public void AttachWagonFromLeft(int wagonId)
    {
        wagons.AddFirst(wagonId);
    }

    public void AttachWagonFromRight(int wagonId)
    {
        wagons.AddLast(wagonId);
    }

    public int DetachWagonFromLeft()
    {
        if (wagons.Count>0)
        {
            int i = wagons.First.Value;
            wagons.RemoveFirst();
            return i;
        }
        throw new ArgumentOutOfRangeException("Argument out of Range");
    }

    public int DetachWagonFromRight()
    {
        if (wagons.Count>0)
        {
            int i = wagons.Last.Value;
            wagons.RemoveLast();
            return i;
        }
        throw new ArgumentOutOfRangeException("Argument out of Range");
    }

    public static void Main(string[] args)
    {
        TrainComposition train = new TrainComposition();
        train.AttachWagonFromLeft(7);
        train.AttachWagonFromLeft(13);
        Console.WriteLine(train.DetachWagonFromRight()); // 7 
        Console.WriteLine(train.DetachWagonFromLeft()); // 13
        Console.ReadLine();
    }
}