using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotId : MonoBehaviour
{
    public float id;

    private GetIDitem _getIDitem;
    
  

    private void Start()
    {
        _getIDitem = FindObjectOfType<GetIDitem>();
    }

   public void Click()
   {
       
        
        switch (_getIDitem.clicked)
        {
            case false:
                
                _getIDitem.clicked = true;
               
                break;
            
            case true:
                
                _getIDitem.clicked = false;
                
                break;

        }
       
        
        _getIDitem.GetId(id);
      
        


      

    }
}
