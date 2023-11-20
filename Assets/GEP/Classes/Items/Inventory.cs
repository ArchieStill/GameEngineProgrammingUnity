using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int blueCount = 0;
    public TMP_Text blueText;
    int redCount = 0;
    public TMP_Text redText;
    int greenCount = 0;
    public TMP_Text greenText;
    int yellowCount = 0;
    public TMP_Text yellowText;

    public void BlueItemPickup()
    {
        blueCount++;
        blueText.text = blueCount.ToString();
    }
    public void RedItemPickup()
    {
        redCount++;
        redText.text = redCount.ToString();
    }
    public void GreenItemPickup()
    {
        greenCount++;
        greenText.text = greenCount.ToString();
    }
    public void YellowItemPickup()
    {
        yellowCount++;
        yellowText.text = yellowCount.ToString();
    }
}
