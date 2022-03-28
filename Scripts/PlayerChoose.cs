
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerChoose : MonoBehaviour
{
  
    public Characters[] playableCharacters;

    public static string path;
  
    public void VikingChoose()
    {

        path = playableCharacters[0].prefabPath;


        SceneManager.LoadScene("ManagmentScene");


    }

    public void WizardChoose() {

        path = playableCharacters[1].prefabPath;
        
        SceneManager.LoadScene("ManagmentScene");

    }

    public void PlayerCharacter3()
    {
        SceneManager.LoadScene("ManagmentScene");

    }
}
