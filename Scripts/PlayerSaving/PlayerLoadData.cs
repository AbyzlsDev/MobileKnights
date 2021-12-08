using UnityEngine;

public class PlayerLoadData : MonoBehaviour
{

    public Characters characters;
    public PlayerInventory playerInventory;
    public ItemsInstanciate itemsInstanciate;



    private void Awake()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        characters.HP = data.HP;

        characters.score = data.score;

        transform.position = new Vector3(data.position[0], data.position[1], data.position[2]);

        playerInventory.item = data.items;

        playerInventory.itemsOnGroundId = data.itemsOnGroundIdToSave;

        for (int i = 0; i < playerInventory.itemsOnGroundId.Count; i++)
        {
            var id = playerInventory.itemsOnGroundId[i];

            float x = PlayerPrefs.GetFloat(playerInventory.itemsOnGroundId[i].ToString() + "x");
            float y = PlayerPrefs.GetFloat(playerInventory.itemsOnGroundId[i].ToString() + "y");


            Vector2 pos = new Vector2(x, y);
            GameObject ItemInst = Instantiate(itemsInstanciate.itemScriptableObjectsArr[(int)id - 1].gameObject, pos, Quaternion.identity);

            ItemInst.transform.localScale = new Vector2(3, 3);


        }

    }

    
}
