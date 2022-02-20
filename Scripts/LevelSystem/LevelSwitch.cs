using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSwitch : MonoBehaviour
{
    public float currentLevel = 1;

    GameObject player;

    GameObject[] levels;

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");

        levels = GameObject.FindGameObjectsWithTag("Levels");

        for (int x = 0; x < levels.Length; x++)
        {

            if (levels[x].GetComponent<Level_ID>().LevelID != currentLevel)
            {

                levels[x].SetActive(false);

            }
        }

    }

    private void Update()
    {


        if (Input.GetKeyDown(KeyCode.M)) {

            currentLevel++;
            SwitchLevel();


        }

        if (Input.GetKeyDown(KeyCode.N))
        {

            currentLevel--;
            SwitchLevel();


        }
    }




    public void SwitchLevel()
    {

        for (int x = 0; x < levels.Length; x++)
        {

            if (levels[x].GetComponent<Level_ID>().LevelID == currentLevel)
            {
                levels[x].SetActive(true);
                player.transform.position = levels[x].GetComponent<Level_ID>().LevelStartPoint.position;
                break;
            }

        }

        for (int x = 0; x < levels.Length; x++)
        {

            if (levels[x].GetComponent<Level_ID>().LevelID != currentLevel)
            {

                levels[x].SetActive(false);

            }


        }

    } 
}
