using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectItem : MonoBehaviour
{
    [SerializeField] Inventory inventory;
    public int selectedSlot = 1;
    public ItemText text;

    public GameObject[] Select1;
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
        switch (selectedSlot)
        {
            case 1:
                FindObjectOfType<DropItem>().dropItem(id: inventory.pickupOrder);
                break;
            case 2:
                FindObjectOfType<DropItem>().dropItem(id: inventory.pickupOrder);
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
    
    // Don't need to touch these for inventory expansion, purely for which
    // hotbar selection square is active!
    public void selectItem(int select)
    {
        SelectedSlot slot = (SelectedSlot)select;

        switch (slot) 
        {
            case SelectedSlot.SLOT1:
                HBBlueSelect.SetActive(true);
                HBRedSelect.SetActive(false);
                HBGreenSelect.SetActive(false);
                HBYellowSelect.SetActive(false);
                IVBlueSelect.SetActive(true);
                IVRedSelect.SetActive(false);
                IVGreenSelect.SetActive(false);
                IVYellowSelect.SetActive(false);
                text.textActive((int)ItemText.TextColour.BLUE);
                break;
            case SelectedSlot.SLOT2:
                HBBlueSelect.SetActive(false);
                HBRedSelect.SetActive(true);
                HBGreenSelect.SetActive(false);
                HBYellowSelect.SetActive(false);
                IVBlueSelect.SetActive(false);
                IVRedSelect.SetActive(true);
                IVGreenSelect.SetActive(false);
                IVYellowSelect.SetActive(false);
                text.textActive((int)ItemText.TextColour.RED);
                break;
            case SelectedSlot.SLOT3:
                HBBlueSelect.SetActive(false);
                HBRedSelect.SetActive(false);
                HBGreenSelect.SetActive(true);
                HBYellowSelect.SetActive(false);
                IVBlueSelect.SetActive(false);
                IVRedSelect.SetActive(false);
                IVGreenSelect.SetActive(true);
                IVYellowSelect.SetActive(false);
                text.textActive((int)ItemText.TextColour.GREEN);
                break;
            case SelectedSlot.SLOT4:
                HBBlueSelect.SetActive(false);
                HBRedSelect.SetActive(false);
                HBGreenSelect.SetActive(false);
                HBYellowSelect.SetActive(true);
                IVBlueSelect.SetActive(false);
                IVRedSelect.SetActive(false);
                IVGreenSelect.SetActive(false);
                IVYellowSelect.SetActive(true);
                text.textActive((int)ItemText.TextColour.YELLOW);
                break;
            default:
                break;
        }
    }

    public void LastItem()
    {
        FindObjectOfType<SelectItem>().selectedSlot--;
        if (FindObjectOfType<SelectItem>().selectedSlot < 1)
            FindObjectOfType<SelectItem>().selectedSlot = 1;
    }
    public void NextItem()
    {
        FindObjectOfType<SelectItem>().selectedSlot++;
        if (FindObjectOfType<SelectItem>().selectedSlot > 4)
            FindObjectOfType<SelectItem>().selectedSlot = 4;
    }

    [Serializable] public enum SelectedSlot { SLOT1 = 1, SLOT2 = 2, SLOT3 = 3, SLOT4 = 4 }

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
