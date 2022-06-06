using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

using UnityEngine;

public class ItemSwitchPlaces : MonoBehaviour
{
    public float selectedItem = Single.NaN;
    public float selectedToReplace;
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
      
            if (_playerInventory.backpackId.Count > 1)
            {
                for (int i = 0; i < _playerInventory.backpackId.Count; i++)
                {
                    if (_playerInventory.backpackId[i] == selectedItem)
                    {

                        for (int x = 0; x < _playerInventory.backpackId.Count; x++)
                        {
                            if (_playerInventory.backpackId[x] == itemToReplace)
                            {
                                
                                _playerInventory.backpackId[i] = itemToReplace;

                                _playerInventory.backpackId[x] = selectedItem;

                                selectedItem = default;
                                itemToReplace = default;
                             

                                break;
                                
                               


                            }
                            
                           


                        }
                    }
                }

            }
        }
    }



    


