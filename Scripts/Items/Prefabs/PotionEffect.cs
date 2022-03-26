using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionEffect : MonoBehaviour
{
    private PlayerControler playerControler;
    public float healVal;

    public void EffectInvokeHeal()
    {
        playerControler = FindObjectOfType<PlayerControler>();
        playerControler.HP += healVal;
    }

  
       

    

    
}
