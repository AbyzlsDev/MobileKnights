using System.Collections.Generic;
using UnityEngine;






public class PlayerInventory : MonoBehaviour
{

    public List<float> item = new List<float>();


    public Characters characters;
    public PlayerInventory playerInventory;
    public ItemScriptableObjects[] itemsArray;

   
    public List<float> RandomKeys = new List<float>();

    

    public List<float> itemsOnGroundId = new List<float>();
    //GameObject currentItem;

    public Transform Hand;

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
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

             


        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            


        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

           


        }


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
                float rKey = ColliderHit.gameObject.GetComponent<ItemGetID>().numberOfString - ColliderHit.gameObject.GetComponent<ItemGetID>().ID;
                string rKeyS = rKey.ToString();

                PlayerPrefs.DeleteKey(rKeyS);

                item.Add(ColliderHit.gameObject.GetComponent<ItemGetID>().ID);

                itemsOnGroundId.Remove(ColliderHit.gameObject.GetComponent<ItemGetID>().ID);

                RandomKeys.Remove(ColliderHit.gameObject.GetComponent<ItemGetID>().numberOfString);

                SaveSystem.SavePlayer(characters, playerInventory);

                Destroy(ColliderHit.gameObject);


            }
        }

    }
    public void ItemInstance()
    {
        if (item.Count != 0)
        {
            for (int i = 0; i < item.Count; i++)
            {
                if (item[0] == item[i])
                {
                    var id = item[i];

                    float RandomKey = Random.Range(0, 99999);

                    RandomKeys.Add(RandomKey);

                    Debug.Log(RandomKey);

                    GameObject ItemInst = Instantiate(itemsArray[(int)id - 1].gameObject, dropPoint.position, Quaternion.identity);

                    ItemInst.transform.localScale = new Vector2(3, 3);

                    float numberForPrefs = id + RandomKey;

                    Debug.Log(numberForPrefs);

                    string nameForPrefs = numberForPrefs.ToString();

                    ItemInst.GetComponent<ItemGetID>().numberOfString = RandomKey;

                    item.RemoveAt(i);

                    itemsOnGroundId.Add(id);

                    PlayerPrefs.SetFloat(nameForPrefs, dropPoint.position.x);
                    PlayerPrefs.SetFloat(nameForPrefs, dropPoint.position.y);

                    PlayerPrefs.Save();

                    SaveSystem.SavePlayer(characters, playerInventory);

                    break;
                }
            }

        }

    }

}