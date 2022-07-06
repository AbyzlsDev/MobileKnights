using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class InventoryToggle : MonoBehaviour
{
   public GameObject inventoryGameObject;

   private bool opened = false;

   private PlayerInventory _playerInventory;

   public Button[] _images;

 



   // Start is called before the first frame update
    void Start()
    {

        _images = GetComponentsInChildren<Button>();

        _playerInventory = FindObjectOfType<PlayerInventory>();
        
        inventoryGameObject.SetActive(false);
        
      


    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < _playerInventory.backpackId.Count; i++) // fix backpackId with backpack
        {
            _images[i].GetComponent<Image>().sprite = _playerInventory.itemsArray[(int)_playerInventory.backpackId[i]].gameObject.GetComponent<SpriteRenderer>().sprite;


            _images[i].GetComponent<SlotId>().id = _playerInventory.backpackId[i];

        }
        
        


        if (Input.GetKeyDown(KeyCode.P) && opened == false)
        {
            inventoryGameObject.SetActive(true);

            opened = true;


        } 
        
       else if (Input.GetKeyDown(KeyCode.P) && opened)
        {
            inventoryGameObject.SetActive(false);

            opened = false;


        } 
       

    }
}
