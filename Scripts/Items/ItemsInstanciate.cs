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

            ItemInst.transform.localScale = new Vector2(3, 3);
            

        }

       // Destroy(GO, 7);

    }

    
}
