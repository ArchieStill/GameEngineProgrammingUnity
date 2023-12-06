using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemText : MonoBehaviour
{
    public GameObject blueText;
    public GameObject redText;
    public GameObject greenText;
    public GameObject yellowText;

    public void textActive(int id)
    {
        TextColour colour = (TextColour)id;

        switch (colour)
        {
            case TextColour.BLUE:
                blueText.SetActive(true);
                redText.SetActive(false);
                greenText.SetActive(false);
                yellowText.SetActive(false);
                break;
            case TextColour.RED:
                blueText.SetActive(false);
                redText.SetActive(true);
                greenText.SetActive(false);
                yellowText.SetActive(false);
                break;
            case TextColour.GREEN:
                blueText.SetActive(false);
                redText.SetActive(false);
                greenText.SetActive(true);
                yellowText.SetActive(false);
                break;
            case TextColour.YELLOW:
                blueText.SetActive(false);
                redText.SetActive(false);
                greenText.SetActive(false);
                yellowText.SetActive(true);
                break;
        }
    }

    public void textInactive(int id)
    {
        TextColour colour = (TextColour)id;

        switch (colour)
        {
            case TextColour.BLUE:
                blueText.SetActive(false);
                break;
            case TextColour.RED:
                redText.SetActive(false);
                break;
            case TextColour.GREEN:
                greenText.SetActive(false);
                break;
            case TextColour.YELLOW:
                yellowText.SetActive(false);
                break;
        }
    }
}

[Serializable] public enum TextColour {BLUE = 1, RED = 2, GREEN = 3, YELLOW = 4}
