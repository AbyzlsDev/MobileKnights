using UnityEngine;

public class ItemsInstanciate : MonoBehaviour
{
    public ItemScriptableObjects[] itemScriptableObjectsArr;

  




    void Start()
    {
      

        itemScriptableObjectsArr = Resources.LoadAll<ItemScriptableObjects>("Items");

 

    }

   

    
}
