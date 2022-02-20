
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text text;
    public float Score = 0f;
    public Characters characters;
  

    
    void Awake()
    {
       

       PlayerData data = SaveSystem.LoadPlayer();

        text.text = data.score.ToString();
    }   

    // Update is called once per frame
    void Update()
    {
        Score = characters.score;

        text.text = Score.ToString();
        
    }

    public void GiveScore(float score) {

        characters.score += score;
        SaveSystem.SavePlayer(characters);

    }
}
