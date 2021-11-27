using UnityEngine;

public class ItemsInstanciate : MonoBehaviour
{
    public ItemScriptableObject[] itemScriptableObjectsArr;
    


    void Start()
    {
      ItemInstance(); 

    }

    void ItemInstance() {

        GameObject GO = new GameObject();
        GO.transform.localScale = new Vector2(4,4);
        GO.AddComponent<ItemGetID>();
        GO.AddComponent<SpriteRenderer>();
        GO.AddComponent<BoxCollider2D>().isTrigger = true;
        GO.GetComponent<BoxCollider2D>().size = new Vector2(0.5f, 0.5f);
        GO.AddComponent<BoxCollider2D>().size = new Vector2(0.5f, 0.5f);
       

        for (int i = 0; i < itemScriptableObjectsArr.Length; i++) {

            GameObject ItemInst = Instantiate(GO, transform.position * -i * 2, Quaternion.identity);
           
            ItemInst.GetComponent<ItemGetID>().ID = itemScriptableObjectsArr[i].ID;
            ItemInst.GetComponent<SpriteRenderer>().sprite = itemScriptableObjectsArr[i].sprite;
            ItemInst.tag = "item";

        }

        Destroy(GO, 7);

    }

    
}
