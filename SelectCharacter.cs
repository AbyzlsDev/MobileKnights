using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectCharacter : MonoBehaviour
{
    public Characters characters;
    public Image image;


    
    public void CharacterSelect() {

       
        SceneManager.LoadScene("SelectCharacter");

    }
}
