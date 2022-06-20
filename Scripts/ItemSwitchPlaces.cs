using System;
using UnityEngine;

public class ItemSwitchPlaces : MonoBehaviour
{
    public float selectedItem = Single.NaN;
    public float itemToReplace = Single.NaN;


    private GetIDitem _getIDitem;


    private InventoryToggle _inventoryToggle;

    private PlayerInventory _playerInventory;

    void Start()
    {
        _inventoryToggle = FindObjectOfType<InventoryToggle>();

        _getIDitem = FindObjectOfType<GetIDitem>();

        _playerInventory = FindObjectOfType<PlayerInventory>();


    }

    // Update is called once per frame
    void Update()
    {

        if (_getIDitem.switchActive && Input.GetKey(KeyCode.LeftShift))
        {

            (_playerInventory.backpackId[_playerInventory.backpackId.IndexOf(selectedItem)], _playerInventory.backpackId[_playerInventory.backpackId.IndexOf(itemToReplace)]) = 
                (_playerInventory.backpackId[_playerInventory.backpackId.IndexOf(itemToReplace)], _playerInventory.backpackId[_playerInventory.backpackId.IndexOf(selectedItem)]);
            
            ResetToDefault();
            
} 
           else if (!Input.GetKey(KeyCode.LeftShift) && _getIDitem.switchActive)
            {
                ResetToDefault();
            }

            void ResetToDefault()
            {
                _getIDitem.switchActive = false;
                _getIDitem.clicked = false;
                selectedItem = Single.NaN;
                itemToReplace = Single.NaN;
            }
    }
    }



    


