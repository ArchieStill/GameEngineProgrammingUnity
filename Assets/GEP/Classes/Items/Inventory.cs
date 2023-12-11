using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public AudioSource audioSource;

    public int blueCount = 0;
    public TMP_Text blueText;
    public TMP_Text blueHB;
    public AudioClip bluePickupSound;

    public int redCount = 0;
    public TMP_Text redText;
    public TMP_Text redHB;
    public AudioClip redPickupSound;

    public int greenCount = 0;
    public TMP_Text greenText;
    public TMP_Text greenHB;
    public AudioClip greenPickupSound;

    public int yellowCount = 0;
    public TMP_Text yellowText;
    public TMP_Text yellowHB;
    public AudioClip yellowPickupSound;

    public void BlueItemPickup()
    {
        audioSource.PlayOneShot(bluePickupSound, 0.75f);
        blueCount++;
        blueText.text = "x " + blueCount.ToString();
        blueHB.text = blueCount.ToString();
    }
    public void RedItemPickup()
    {
        audioSource.PlayOneShot(redPickupSound, 0.75f);
        redCount++;
        redText.text = "x " + redCount.ToString();
        redHB.text = redCount.ToString();
    }
    public void GreenItemPickup()
    {
        audioSource.PlayOneShot(greenPickupSound, 0.75f);
        greenCount++;
        greenText.text = "x " + greenCount.ToString();
        greenHB.text = greenCount.ToString();
    }
    public void YellowItemPickup()
    {
        audioSource.PlayOneShot(yellowPickupSound, 0.75f);
        yellowCount++;
        yellowText.text = "x " + yellowCount.ToString();
        yellowHB.text = yellowCount.ToString();
    }
}
