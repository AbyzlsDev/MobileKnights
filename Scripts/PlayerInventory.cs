using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;


public class PlayerInventory : MonoBehaviour
{

    [SerializeField] public List<float> item = new List<float>();


   
    public PlayerControler playerControler;
    public PlayerInventory playerInventory;

    public List<ItemScriptableObjects> itemsArray = new List<ItemScriptableObjects>();
    private int backpackSize = 9;
    public List<float> backpack = new List<float>();

    [SerializeField] public List<float> itemsOnGroundId = new List<float>();


    //GameObject currentItem;

    public Transform Hand;

    public Transform dropPoint;

    //9 slot inv, 1 slot hand, slot -> hand, slot empty, hand drop

    string[] tags = {"level1", "item"};

    List<string> keys = new List<string>() {"itemScriptables"};

    AsyncOperationHandle<IList<ItemScriptableObjects>> loadHandle;

    private float nextTimeToDrop = 0f;

    int maxWeapons = 3;


    // Start is called before the first frame update
    void Start()
    {
        //idk how is this working, but it fucking does

        LoadAddressablesForItems();


    }

    public void LoadAddressablesForItems()
    {
        loadHandle = Addressables.LoadAssetsAsync<ItemScriptableObjects>(keys, addressable =>
        {
            if (addressable != null)
            {

                itemsArray.Add(addressable);

            }
        }, Addressables.MergeMode.Union, false);
        loadHandle.Completed += LoadHandle_Completed;
    }

    public void LoadHandle_Completed(AsyncOperationHandle<IList<ItemScriptableObjects>> operation)
    {
        if (operation.Status != AsyncOperationStatus.Succeeded)
            Debug.LogWarning("Some assets did not load.");
    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (item.Count != 0)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    if (item[0] == item[i])
                    {
                        float id = item[i];

                        GameObject ItemInst = Instantiate(itemsArray[(int) id].gameObject, dropPoint.position,
                            Quaternion.identity);


                        item.RemoveAt(i);

                        ItemInst.GetComponent<PotionEffect>().EffectInvokeHeal();

                        SaveSystem.SavePlayer(playerControler, playerInventory);

                        Destroy(ItemInst);

                        break;
                    }
                }

            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (item.Count >= 2)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    if (item[1] == item[i])
                    {
                        float id = item[i];

                        GameObject ItemInst = Instantiate(itemsArray[(int) id].gameObject, dropPoint.position,
                            Quaternion.identity);


                        item.RemoveAt(i);

                        ItemInst.GetComponent<PotionEffect>().EffectInvokeHeal();

                        SaveSystem.SavePlayer(playerControler, playerInventory);

                        Destroy(ItemInst);

                        break;
                    }
                }

            }

        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

            if (item.Count == 3)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    if (item[2] == item[i])
                    {
                        float id = item[i];

                        GameObject ItemInst = Instantiate(itemsArray[(int) id].gameObject, dropPoint.position,
                            Quaternion.identity);


                        item.RemoveAt(i);

                        ItemInst.GetComponent<PotionEffect>().EffectInvokeHeal();

                        SaveSystem.SavePlayer(playerControler, playerInventory);

                        Destroy(ItemInst);

                        break;
                    }
                }

            }


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


                item.Add(ColliderHit.gameObject.GetComponent<ItemGetID>().ID);

               // itemsOnGroundId.Remove(ColliderHit.gameObject.GetComponent<ItemGetID>().ID);


                SaveSystem.SavePlayer(playerControler, playerInventory);

                Destroy(ColliderHit.gameObject);


            }
            else if (ColliderHit.transform.CompareTag(tags[i]) && backpack.Count < backpackSize)
            {
                
                backpack.Add(ColliderHit.gameObject.GetComponent<ItemGetID>().ID);
                
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
                    float id = item[i];

                    GameObject ItemInst = Instantiate(itemsArray[(int) id].gameObject, dropPoint.position,
                        Quaternion.identity);

                    ItemInst.transform.localScale = new Vector2(3, 3);

                    item.RemoveAt(i);

                    /*  itemsOnGroundId.Add(id);
  
                      PlayerPrefs.SetFloat(id.ToString() + "x", ItemInst.transform.position.x);
                      PlayerPrefs.SetFloat(id.ToString() + "y", ItemInst.transform.position.y);
  
                      PlayerPrefs.Save();*/

                    SaveSystem.SavePlayer(playerControler, playerInventory);

                    break;
                }
            }

        }

    }

  /*  public void ItemUse()
    {
        if (item.Count != 0)
        {
            for (int i = 0; i < item.Count; i++)
            {
                if (item[0] == item[i])
                {
                    float id = item[i] - 1;

                    GameObject ItemInst = Instantiate(itemsArray[(int) id].gameObject, dropPoint.position,
                        Quaternion.identity);

                    // ItemInst.GetComponent<SpriteRenderer>().sprite = null;

                    item.RemoveAt(i);

                    ItemInst.GetComponent<PotionEffect>().EffectInvokeHeal();

                    SaveSystem.SavePlayer(playerControler, playerInventory);

                    Destroy(ItemInst);

                    break;
                }
            }

        }

    }*/

}