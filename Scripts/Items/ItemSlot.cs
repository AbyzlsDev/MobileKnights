using UnityEngine;
using UnityEngine.UI;


public class ItemSlot : MonoBehaviour
{
    public Image[] itemsImage;
    public PlayerInventory playerInventory;
    public ItemScriptableObjects[] itemScriptableObjects;

    
    // Start is called before the first frame update
    void Start()
    {
        

        for (int i = 0; i < itemsImage.Length; i++)
        {
            float id = playerInventory.item[i];
           
            itemsImage[i].sprite = itemScriptableObjects[(int)id - 1].gameObject.GetComponent<SpriteRenderer>().sprite;

           

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (itemsImage.Length == playerInventory.item.Count)
        {
            for (int i = 0; i < itemsImage.Length; i++)
            {

                float id = playerInventory.item[i];

                itemsImage[i].sprite = itemScriptableObjects[(int)id - 1].gameObject.GetComponent<SpriteRenderer>().sprite;



            }
        }
        else if(itemsImage.Length > playerInventory.item.Count) {

            for (int i = 0; i < itemsImage.Length; i++)
            {

                itemsImage[i].sprite = default;

                float id = playerInventory.item[i];

                itemsImage[i].sprite = itemScriptableObjects[(int)id - 1].gameObject.GetComponent<SpriteRenderer>().sprite;

                
                
            }

        }
    }
}
