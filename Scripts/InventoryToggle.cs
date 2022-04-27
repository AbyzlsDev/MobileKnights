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

   public Image[] _images;

 



   // Start is called before the first frame update
    void Start()
    {

        _images = GetComponentsInChildren<Image>();

        _playerInventory = FindObjectOfType<PlayerInventory>();
        
        

       
        
        inventoryGameObject.SetActive(false);
        
      


    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < _playerInventory.backpack.Count; i++)
        {
            _images[i].sprite = _playerInventory.itemsArray[(int)_playerInventory.backpack[i]].gameObject.GetComponent<SpriteRenderer>().sprite;
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
