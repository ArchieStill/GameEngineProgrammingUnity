using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    int greyCount = 0;
    int redCount = 0;

    public void GreyItemPickup()
    {
        greyCount++;
        Debug.Log("Total grey items: " + greyCount);
    }

    public void RedItemPickup()
    {
        redCount++;
        Debug.Log("Total red items: " + redCount);
    }
}
