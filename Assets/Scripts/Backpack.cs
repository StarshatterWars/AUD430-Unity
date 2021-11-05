using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack
{
    public int itemCount;
    public static int capacity;

    public Backpack()
    {
        this.itemCount = 0;
        Backpack.capacity = 10;
    }

    public Backpack(int capacity)
    {
        this.itemCount = 0;
        Backpack.capacity = capacity;
    }

    public void AddToBackpack()
    {
        if (itemCount < Backpack.capacity)
        {
            this.itemCount++;
        }
        else
        {
            Debug.Log("Backpack if FULL!!!");
        }
    }

}
