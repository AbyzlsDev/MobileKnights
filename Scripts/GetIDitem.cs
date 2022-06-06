using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GetIDitem : MonoBehaviour
{
    private ItemSwitchPlaces _itemSwitchPlaces;

    private InventoryToggle _inventoryToggle;

  public bool clicked = false;
    
    private SlotId _slotId;

    private void Start()
    {
        _inventoryToggle = FindObjectOfType<InventoryToggle>();
       
        _itemSwitchPlaces = FindObjectOfType<ItemSwitchPlaces>();

        _slotId = FindObjectOfType<SlotId>();

    }




    public void GetId(float id)
    {

        switch (clicked)
        {
            case false:
                _itemSwitchPlaces.selectedItem = id;
                
                break;
            
            case true:
                _itemSwitchPlaces.itemToReplace = id;
                
                break;
           


        }

    }

}

    
    
    

