using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTeleport : MonoBehaviour
{
    Transform teleport;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        teleport = GameObject.Find("Teleport").transform;
        Player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    public void Touch()
    {
        Player.transform.position = teleport.position;
        
    }
}
