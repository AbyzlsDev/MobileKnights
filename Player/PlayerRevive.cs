using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRevive : MonoBehaviour
{
    public Characters characters;

    

    // Start is called before the first frame update
    public void RevivePlayer() {

        characters.HP = characters.maxHP;




        characters.positionX = default;
        characters.positionY = default;
        characters.positionZ = default;

        SaveSystem.SavePlayer(characters);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
}
