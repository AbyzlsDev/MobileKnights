using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelToSwitch : MonoBehaviour
{
    public SceneMngr sceneManager;
    public string nextlevelPath;
    public string previouslevelPath;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) {

            sceneManager.LoadAddressableLevel(nextlevelPath);
        
        
        }
        if (Input.GetKeyDown(KeyCode.J))
        {

            sceneManager.LoadAddressableLevel(previouslevelPath);


        }

    }
}
