using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int blueCount = 0;
    public TMP_Text blueText;
    public TMP_Text blueHB;
    public int redCount = 0;
    public TMP_Text redText;
    public TMP_Text redHB;
    public int greenCount = 0;
    public TMP_Text greenText;
    public TMP_Text greenHB;
    public int yellowCount = 0;
    public TMP_Text yellowText;
    public TMP_Text yellowHB;

    public void BlueItemPickup()
    {
        blueCount++;
        blueText.text = "x " + blueCount.ToString();
        blueHB.text = blueCount.ToString();
    }
    public void RedItemPickup()
    {
        redCount++;
        redText.text = "x " + redCount.ToString();
        redHB.text = redCount.ToString();
    }
    public void GreenItemPickup()
    {
        greenCount++;
        greenText.text = "x " + greenCount.ToString();
        greenHB.text = greenCount.ToString();
    }
    public void YellowItemPickup()
    {
        yellowCount++;
        yellowText.text = "x " + yellowCount.ToString();
        yellowHB.text = yellowCount.ToString();
    }
}
