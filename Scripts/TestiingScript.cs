using UnityEngine;
using UnityEngine.UI;

public class TestiingScript : MonoBehaviour
{
    public int CoinValue;
    public Text text;

    

    public void SavePlayer(Characters characters, PlayerInventory playerInventory)
    {
        Debug.Log("Pressed the button");
        SaveSystem.SavePlayer(characters);
        SaveSystem.SaveItems(playerInventory);


    }

  

    private void Update()
    {
        text.text = CoinValue.ToString();
    }

    public void ValueAdd() {

        CoinValue++;


    }
}
