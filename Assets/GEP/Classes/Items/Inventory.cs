using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int blueCount = 0;
    public TMP_Text blueText;
    public int redCount = 0;
    public TMP_Text redText;
    public int greenCount = 0;
    public TMP_Text greenText;
    public int yellowCount = 0;
    public TMP_Text yellowText;

    public void BlueItemPickup()
    {
        blueCount++;
        blueText.text = "x " + blueCount.ToString();
    }
    public void RedItemPickup()
    {
        redCount++;
        redText.text = "x " + redCount.ToString();
    }
    public void GreenItemPickup()
    {
        greenCount++;
        greenText.text = "x " + greenCount.ToString();
    }
    public void YellowItemPickup()
    {
        yellowCount++;
        yellowText.text = "x " + yellowCount.ToString();
    }
}
