
using JetBrains.Annotations;
using UnityEngine;


public class GetIDitem : MonoBehaviour
{
    private ItemSwitchPlaces _itemSwitchPlaces;
    
    
     public bool clicked ;


     public bool switched;
      
    

    private void Start()
    {
        _itemSwitchPlaces = FindObjectOfType<ItemSwitchPlaces>();
        
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

    
    
    

