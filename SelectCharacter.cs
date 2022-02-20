using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectCharacter : MonoBehaviour
{
    public Characters characters;
    public Image image;


    void Update()
    {
       image.sprite = characters.sprite;

    }
    public void CharacterSelect() {

       
        SceneManager.LoadScene("SelectCharacter");

    }
}
