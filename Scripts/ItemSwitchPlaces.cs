using System;
using UnityEngine;

public class ItemSwitchPlaces : MonoBehaviour
{
    public float selectedItem = 0;
    public float itemToReplace = 0;


    private GetIDitem getIDitem;



    private PlayerInventory _playerInventory;

    void Start()
    {
        getIDitem = FindObjectOfType<GetIDitem>();

        _playerInventory = FindObjectOfType<PlayerInventory>();


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftShift) && !getIDitem.switched) 
       
        {

            (_playerInventory.backpackId[_playerInventory.backpackId.IndexOf(selectedItem)],
                _playerInventory.backpackId[_playerInventory.backpackId.IndexOf(itemToReplace)]) = (
                _playerInventory.backpackId[_playerInventory.backpackId.IndexOf(itemToReplace)],
                _playerInventory.backpackId[_playerInventory.backpackId.IndexOf(selectedItem)]);

            getIDitem.switched = true;



        }


        if (Input.GetKey(KeyCode.LeftShift) && getIDitem.switched)
        {
            ResetToDefault();
        }

        void ResetToDefault()
        {
            getIDitem.switched = false;
            getIDitem.clicked = false;

            selectedItem = Single.NaN;
            itemToReplace = Single.NaN;
        }
    }
}




    


