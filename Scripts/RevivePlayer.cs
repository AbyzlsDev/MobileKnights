using UnityEngine.SceneManagement;
using UnityEngine;

public class RevivePlayer : MonoBehaviour
{
   
    public void CharactersDef(Characters characters)
    {

       
      
        PlayerInventory playerInventory = new PlayerInventory();

        characters.HP = characters.maxHP;


        characters.positionX = default;
        characters.positionY = default;
        characters.positionZ = default;

       SaveSystem.SavePlayer(characters);
        

        SceneManager.LoadScene(characters.lastScene);

    }

   

}
