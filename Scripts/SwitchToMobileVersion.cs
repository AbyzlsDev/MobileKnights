using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchToMobileVersion : MonoBehaviour
{
    public GameObject MobileControls;

    public void SwitchMobile() {

        if (MobileControls.activeInHierarchy == false) {

            MobileControls.SetActive(true);

            return;
        }

        if (MobileControls.activeInHierarchy == true) {

            MobileControls.SetActive(false);

            return;

        }
    
    }
}
