using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectItem : MonoBehaviour
{
    public int selectedColour = 1;

    public GameObject HBBlueSelect;
    public GameObject HBRedSelect;
    public GameObject HBGreenSelect;
    public GameObject HBYellowSelect;
    public GameObject IVBlueSelect;
    public GameObject IVRedSelect;
    public GameObject IVGreenSelect;
    public GameObject IVYellowSelect;

    public void DropByButton()
    {
        switch (selectedColour)
        {
            case 1:
                FindObjectOfType<DropItem>().dropItem(id: 1);
                break;
            case 2:
                FindObjectOfType<DropItem>().dropItem(id: 2);
                break;
            case 3:
                FindObjectOfType<DropItem>().dropItem(id: 3);
                break;
            case 4:
                FindObjectOfType<DropItem>().dropItem(id: 4);
                break;
            default:
                break;
        }
    }

    public void selectItem()
    {
        switch (selectedColour) 
        {
            case 1:
                HBBlueSelect.SetActive(true);
                HBRedSelect.SetActive(false);
                HBGreenSelect.SetActive(false);
                HBYellowSelect.SetActive(false);
                IVBlueSelect.SetActive(true);
                IVRedSelect.SetActive(false);
                IVGreenSelect.SetActive(false);
                IVYellowSelect.SetActive(false);
                break;
            case 2:
                HBBlueSelect.SetActive(false);
                HBRedSelect.SetActive(true);
                HBGreenSelect.SetActive(false);
                HBYellowSelect.SetActive(false);
                IVBlueSelect.SetActive(false);
                IVRedSelect.SetActive(true);
                IVGreenSelect.SetActive(false);
                IVYellowSelect.SetActive(false);
                break;
            case 3:
                HBBlueSelect.SetActive(false);
                HBRedSelect.SetActive(false);
                HBGreenSelect.SetActive(true);
                HBYellowSelect.SetActive(false);
                IVBlueSelect.SetActive(false);
                IVRedSelect.SetActive(false);
                IVGreenSelect.SetActive(true);
                IVYellowSelect.SetActive(false);
                break;
            case 4:
                HBBlueSelect.SetActive(false);
                HBRedSelect.SetActive(false);
                HBGreenSelect.SetActive(false);
                HBYellowSelect.SetActive(true);
                IVBlueSelect.SetActive(false);
                IVRedSelect.SetActive(false);
                IVGreenSelect.SetActive(false);
                IVYellowSelect.SetActive(true);
                break;
            default:
                break;
        }
    }

    // Initially in the player input script I had each of the Item1 Item2 etc inputs call
    // one of these functions, but I changed it so it calls a single function with a switch
    // statement while changing the value of selectedColour.

    /*public void blueSelected()
    {
        selectedColour = 1;
        blueSelect.SetActive(true);
        redSelect.SetActive(false);
        greenSelect.SetActive(false);
        yellowSelect.SetActive(false);
    }
    public void redSelected()
    {
        selectedColour = 2;
        blueSelect.SetActive(false);
        redSelect.SetActive(true);
        greenSelect.SetActive(false);
        yellowSelect.SetActive(false);
    }
    public void greenSelected()
    {
        selectedColour = 3;
        blueSelect.SetActive(false);
        redSelect.SetActive(false);
        greenSelect.SetActive(true);
        yellowSelect.SetActive(false);
    }
    public void yellowSelected()
    {
        selectedColour = 4;
        blueSelect.SetActive(false);
        redSelect.SetActive(false);
        greenSelect.SetActive(false);
        yellowSelect.SetActive(true);
    }*/
}
