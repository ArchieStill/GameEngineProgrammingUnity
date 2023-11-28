using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemText : MonoBehaviour
{
    public GameObject blueText;
    public GameObject redText;
    public GameObject greenText;
    public GameObject yellowText;

    public void showBlueText()
    {
        blueText.SetActive(true);
        redText.SetActive(false);
        greenText.SetActive(false);
        yellowText.SetActive(false);
    }

    public void showRedText()
    {
        blueText.SetActive(false);
        redText.SetActive(true);
        greenText.SetActive(false);
        yellowText.SetActive(false);
    }

    public void showGreenText()
    {
        blueText.SetActive(false);
        redText.SetActive(false);
        greenText.SetActive(true);
        yellowText.SetActive(false);
    }

    public void showYellowText()
    {
        blueText.SetActive(false);
        redText.SetActive(false);
        greenText.SetActive(false);
        yellowText.SetActive(true);
    }
}
