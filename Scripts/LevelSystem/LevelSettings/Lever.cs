using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    LayerMask layerMask;
    public GameObject element;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 3f, layerMask);

        if (collider.Length > 0 || Input.GetKeyDown(KeyCode.U)) {

            element.SetActive(false); 
        
        }
        
    }
}
