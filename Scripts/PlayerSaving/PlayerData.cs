using System.Collections.Generic;

[System.Serializable]

public class AllData
{
    public float HP;
    //public float[] position;
    public float score;
    
    public List<float> items = new List<float>();
    public List<float> itemsOnGroundIdToSave = new List<float>();

    public AllData(PlayerControler playerControler, PlayerInventory playerInventory)
    {
        HP = playerControler.HP;

        score = playerControler.score;
        
        items = playerInventory.item;
        
        /*position = new float[3];
        position[0] = characters.positionX;
        position[1] = characters.positionY;
        position[2] = characters.positionZ;*/

        itemsOnGroundIdToSave = playerInventory.itemsOnGroundId;
        
        
    }


}


