
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text text;
    public float score;
    

    public PlayerControler playerControler;
    public PlayerInventory playerInventory;

    
    void Start()
    {
        AllData playerData = SaveSystem.LoadPlayer();

        text.text = playerData.score.ToString();
    }   

    // Update is called once per frame
    void Update()                                                                
    {
        score = playerControler.score;

        text.text = score.ToString();
        
    }

    public void GiveScore(float scoreVoid) {

        playerControler.score += scoreVoid;
        SaveSystem.SavePlayer(playerControler, playerInventory);

    }
}
