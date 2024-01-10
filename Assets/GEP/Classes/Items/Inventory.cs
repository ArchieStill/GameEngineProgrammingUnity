using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public AudioSource audioSource;

    public int blueCount = 0;
    public TMP_Text blueText;
    public TMP_Text blueHB;
    public AudioClip bluePickup;
    public GameObject IVBlueIcon;
    public GameObject HBBlueIcon;

    public int redCount = 0;
    public TMP_Text redText;
    public TMP_Text redHB;
    public AudioClip redPickup;
    public GameObject IVRedIcon;
    public GameObject HBRedIcon;

    public int greenCount = 0;
    public TMP_Text greenText;
    public TMP_Text greenHB;
    public AudioClip greenPickup;
    public GameObject IVGreenIcon;
    public GameObject HBGreenIcon;

    public int yellowCount = 0;
    public TMP_Text yellowText;
    public TMP_Text yellowHB;
    public AudioClip yellowPickup;
    public GameObject IVYellowIcon;
    public GameObject HBYellowIcon;

    private void Update()
    {
        while (blueCount > 0)
        {
            IVBlueIcon.SetActive(true);
            HBBlueIcon.SetActive(true);
        }
        while (redCount > 0)
        {
            IVRedIcon.SetActive(true);
            HBRedIcon.SetActive(true);
        }
        while (greenCount > 0)
        {
            IVGreenIcon.SetActive(true);
            HBGreenIcon.SetActive(true);
        }
        while (yellowCount > 0)
        {
            IVYellowIcon.SetActive(true);
            HBYellowIcon.SetActive(true);
        }
    }

    public void BlueItemPickup()
    {
        audioSource.PlayOneShot(bluePickup, 0.5f);
        blueCount++;
        blueText.text = "x " + blueCount.ToString();
        blueHB.text = blueCount.ToString();
    }
    public void RedItemPickup()
    {
        audioSource.PlayOneShot(redPickup, 0.5f);
        redCount++;
        redText.text = "x " + redCount.ToString();
        redHB.text = redCount.ToString();
    }
    public void GreenItemPickup()
    {
        audioSource.PlayOneShot(greenPickup, 0.5f);
        greenCount++;
        greenText.text = "x " + greenCount.ToString();
        greenHB.text = greenCount.ToString();
    }
    public void YellowItemPickup()
    {
        audioSource.PlayOneShot(yellowPickup, 0.5f);
        yellowCount++;
        yellowText.text = "x " + yellowCount.ToString();
        yellowHB.text = yellowCount.ToString();
    }
}
