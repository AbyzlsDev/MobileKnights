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

        if (!_getIDitem.clicked )
        {
            _getIDitem.clicked = true;
            
        } else _getIDitem.clicked = false;


        _getIDitem.GetId(id);
       

    }
}
