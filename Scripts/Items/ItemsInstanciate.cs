using UnityEngine;

public class ItemsInstanciate : MonoBehaviour
{
    public ItemScriptableObjects[] itemScriptableObjectsArr;
    


    void Start()
    {
      ItemInstance(); 

    }

    void ItemInstance() {

       

        for (int i = 0; i < itemScriptableObjectsArr.Length; i++) {

            GameObject ItemInst = Instantiate(itemScriptableObjectsArr[i].gameObject, transform.position * -i * 2, Quaternion.identity);

            

        }

       // Destroy(GO, 7);

    }

    
}
