using System.Collections.Generic;
using UnityEngine;



public class PlayerInventory : MonoBehaviour
{

    public List<float> item = new List<float>();

    public Characters characters;
    public PlayerInventory playerInventory;
    public ItemScriptableObject[] itemsArray;

    // GameObject currentItem;

    //public Transform Hand;

    public Transform dropPoint;

    //9 slot inv, 1 slot hand, slot -> hand, slot empty, hand drop

    string[] tags = { "item" };

    private float nextTimeToDrop = 0f;

    int maxWeapons = 3;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            SelectItem(0);


        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            SelectItem(1);


        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

            SelectItem(2);


        }*/


        /*    if (Input.GetKeyDown(KeyCode.Q) && currentItem != null)
            {

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

            */



        if (Input.GetKeyDown(KeyCode.E))
        {



            ItemInstance();
            item.RemoveAt(0);


            


        }

        /*  void SelectItem(int index)
          {

              if (item.Count > index)
              {

                  if (currentItem != null)
                  {


                      currentItem.SetActive(false);


                  }

                  currentItem = item[index];

                  currentItem.SetActive(true);

                  DisableGravity();


              }



          }

          void DisableGravity()
          {

              currentItem.GetComponent<Rigidbody2D>().isKinematic = true;


          }
        */
        
    }

    void OnTriggerEnter2D(Collider2D ColliderHit)
    {


        for (int i = 0; i < tags.Length; i++)
        {
            if (ColliderHit.transform.CompareTag(tags[i]) && item.Count < maxWeapons)
            {

                item.Add(ColliderHit.gameObject.GetComponent<ItemGetID>().ID);
                SaveSystem.SavePlayer(characters, playerInventory);
                Destroy(ColliderHit.gameObject);


            }
        }

    }
    void ItemInstance()
    {
        GameObject ItemInst = new GameObject();
        ItemInst.transform.localScale = new Vector2(4, 4);
        ItemInst.AddComponent<ItemGetID>();
        ItemInst.AddComponent<SpriteRenderer>();
        ItemInst.AddComponent<BoxCollider2D>().isTrigger = true;
        ItemInst.GetComponent<BoxCollider2D>().size = new Vector2(0.5f, 0.5f);
        // ItemInst.AddComponent<BoxCollider2D>().size = new Vector2(0.5f, 0.5f);

            ItemInst.GetComponent<ItemGetID>().ID = item[0];

            ItemInst.GetComponent<SpriteRenderer>().sprite = itemsArray[itemsArray.Length - (int)item[0]].sprite;
            ItemInst.tag = "item";
            Instantiate(ItemInst, dropPoint.position, Quaternion.identity);


        
        


    }

}