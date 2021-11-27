
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRevive : MonoBehaviour
{

    // Start is called before the first frame update
    public void RevivePlayer(Characters characters, PlayerInventory playerInventory) {

        characters.HP = characters.maxHP;


        characters.positionX = default;
        characters.positionY = default;
        characters.positionZ = default;

        SaveSystem.SavePlayer(characters, playerInventory);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
}
