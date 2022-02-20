using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileDetection : MonoBehaviour
{
    public GameObject MobileControls;

    public Canvas canvas;
    // Start is called before the first frame update
    void Awake()
    {
     

        if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer) {

            MobileControls.SetActive(false);


        } else if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer) {

            MobileControls.SetActive(true);

        }
        
    }

   
    
}
