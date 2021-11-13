using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerData 
{
    

    public float HP;
    public float[] position;
    public float score;
   
    


    public PlayerData(Characters characters) {


        HP = characters.HP;

        score = characters.score;

        position = new float[3];
        position[0] = characters.positionX;
        position[1] = characters.positionY;
        position[2] = characters.positionZ;


    }

}


