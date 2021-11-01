using UnityEngine;
using UnityEngine.UI;

public class TestiingScript : MonoBehaviour
{
    public int CoinValue;
    public Text text;

    public Characters characters;

    public void SavePlayer()
    {
        Debug.Log("Pressed the button");
        SaveSystem.SavePlayer(characters);

    }

  

    private void Update()
    {
        text.text = CoinValue.ToString();
    }

    public void ValueAdd() {

        CoinValue++;


    }
}
