
using System.Collections.Generic;

[System.Serializable]
public class ItemData 
{
    public List<float> items = new List<float>();
    public List<float> itemsOnGroundIdToSave = new List<float>();

    public ItemData(PlayerInventory playerInventory) {


        items = playerInventory.item;

        itemsOnGroundIdToSave = playerInventory.itemsOnGroundId;}
    }
