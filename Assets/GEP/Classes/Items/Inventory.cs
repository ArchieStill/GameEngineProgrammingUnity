using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public AudioSource audioSource;
    public int pickupOrder = 0;

    public int blueCount = 0;
    public TMP_Text blueText;
    public TMP_Text blueHB;
    public AudioClip bluePickup;

    public int redCount = 0;
    public TMP_Text redText;
    public TMP_Text redHB;
    public AudioClip redPickup;

    public int greenCount = 0;
    public TMP_Text greenText;
    public TMP_Text greenHB;
    public AudioClip greenPickup;

    public int yellowCount = 0;
    public TMP_Text yellowText;
    public TMP_Text yellowHB;
    public AudioClip yellowPickup;

    public int purpleCount = 0;
    public TMP_Text purpleText;
    public TMP_Text purpleHB;
    public AudioClip purplePickup;

    private void Update()
    {
        Debug.Log(pickupOrder);
        if (pickupOrder < 0)
            pickupOrder = 0;
        if (pickupOrder == 5)
            pickupOrder = 4;
    }

    public void BlueItemPickup()
    {
        if (blueCount == 0)
            if (pickupOrder < 5)
                pickupOrder++;
        if (pickupOrder < 5)
        {
            audioSource.PlayOneShot(bluePickup, 0.5f);
            blueCount++;
            blueText.text = "x " + blueCount.ToString();
            blueHB.text = blueCount.ToString();
        }
    }
    public void RedItemPickup()
    {
        if (redCount == 0)
            if (pickupOrder < 5)
                pickupOrder++;
        if (pickupOrder < 5)
        {
            audioSource.PlayOneShot(redPickup, 0.5f);
            redCount++;
            redText.text = "x " + redCount.ToString();
            redHB.text = redCount.ToString();
        }
    }
    public void GreenItemPickup()
    {
        if (greenCount == 0)
            if (pickupOrder < 5)
                pickupOrder++;
        if (pickupOrder < 5)
        {
            audioSource.PlayOneShot(greenPickup, 0.5f);
            greenCount++;
            greenText.text = "x " + greenCount.ToString();
            greenHB.text = greenCount.ToString();
        }
    }
    public void YellowItemPickup()
    {
        if (yellowCount == 0)
            if (pickupOrder < 5)
                pickupOrder++;
        if (pickupOrder < 5)
        {
            audioSource.PlayOneShot(yellowPickup, 0.5f);
            yellowCount++;
            yellowText.text = "x " + yellowCount.ToString();
            yellowHB.text = yellowCount.ToString();
        }
    }
    public void PurpleItemPickup()
    {
        if (purpleCount == 0)
            if (pickupOrder < 5)
                pickupOrder++;
        if (pickupOrder < 5)
        {
            purpleCount++;
            purpleText.text = "x " + purpleCount.ToString();
            purpleHB.text = purpleCount.ToString();
        }
    }
}
