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

        playerInventory.RandomKeys = data.RandomKeysToSave;

        playerInventory.itemsOnGroundId = data.itemsOnGroundIdToSave;

        for (int i = 0; i < playerInventory.itemsOnGroundId.Count; i++)
        {
            var id = playerInventory.itemsOnGroundId[i];

            float x = PlayerPrefs.GetFloat((playerInventory.itemsOnGroundId[i] + playerInventory.RandomKeys[i]).ToString());
            float y = PlayerPrefs.GetFloat((playerInventory.itemsOnGroundId[i] + playerInventory.RandomKeys[i]).ToString());

            Vector2 pos = new Vector2(x, y);
            GameObject ItemInst = Instantiate(itemsInstanciate.itemScriptableObjectsArr[(int)id - 1].gameObject, pos, Quaternion.identity);



        }

    }

    
}
