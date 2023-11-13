using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    int blueCount = 0;
    public TMP_Text blueText;
    int redCount = 0;
    public TMP_Text redText;
    int greenCount = 0;
    public TMP_Text greenText;

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
}