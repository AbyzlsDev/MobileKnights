using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{

    public List<GameObject> item = new List<GameObject>();

    GameObject currentItem;

   public Transform Hand;

   string[] tags = {"item"};

    int maxWeapons = 3;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {

            SelectItem(0);


        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            SelectItem(1);


        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

            SelectItem(2);


        }


        if (Input.GetKeyDown(KeyCode.Q) && currentItem != null) {

            currentItem.transform.parent = null;

            currentItem.transform.position = Hand.position;

            currentItem.GetComponent<Rigidbody2D>().isKinematic = false;

            var WeaponInstanceId = currentItem.GetInstanceID();

            for (int i = 0; i < item.Count; i++)
            {

                if (item[i].GetInstanceID() == WeaponInstanceId)
                {

                    item.RemoveAt(i);
                    break;

                }




            }

            currentItem = null;
        }

       




    }

    void SelectItem(int index) {

        if (item.Count > index && item[index] != null) {

            if (currentItem != null) {


                currentItem.SetActive(false);
            
            
            }

            currentItem = item[index];

            currentItem.SetActive(true);

            DisableGravity();


        }
    
    
    
    }

    void DisableGravity() {

        currentItem.GetComponent<Rigidbody2D>().isKinematic = true;
    
    }

    void OnTriggerEnter2D(Collider2D ColliderHit)
    {
        for (int i = 0; i < tags.Length; i++)
        {
            if (ColliderHit.transform.CompareTag(tags[i]) && item.Count < maxWeapons)
            {
                item.Add(ColliderHit.gameObject);
                ColliderHit.gameObject.SetActive(false);
                ColliderHit.transform.parent = Hand;
                ColliderHit.transform.localPosition = Vector3.zero;

            }
        }
       
    }


}
