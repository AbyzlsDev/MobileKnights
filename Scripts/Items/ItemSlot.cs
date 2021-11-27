using UnityEngine;
using UnityEngine.UI;


public class ItemSlot : MonoBehaviour
{
    public Image[] itemsImage;
    public PlayerInventory playerInventory;
    public ItemScriptableObject[] itemScriptableObjects;

    
    // Start is called before the first frame update
    void Start()
    {
        

        for (int i = 0; i < itemsImage.Length; i++)
        {
            float id = playerInventory.item[i];
           
            itemsImage[i].sprite = itemScriptableObjects[itemsImage.Length - (int)id].sprite;

           

        }
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < itemsImage.Length; i++)
        {
            float id = playerInventory.item[i];

            itemsImage[i].sprite = itemScriptableObjects[itemsImage.Length - (int)id].sprite;



        }

    }
}
