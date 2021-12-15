using System.Collections.Generic;

[System.Serializable]
public class PlayerData 
{
    

    public float HP;
    public float[] position;
    public float score;
    public List<float> items = new List<float>();
    public List<float> RandomKeysToSave = new List<float>();
    public List<float> itemsOnGroundIdToSave = new List<float>();





    public PlayerData(Characters characters, PlayerInventory playerInventory) {


        HP = characters.HP;

        score = characters.score;

        position = new float[3];
        position[0] = characters.positionX;
        position[1] = characters.positionY;
        position[2] = characters.positionZ;

        items = playerInventory.item;
      
        itemsOnGroundIdToSave = playerInventory.itemsOnGroundId;

        

    }

}


