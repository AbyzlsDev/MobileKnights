using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    // public PlayerControler playerControler;

    public Transform player;

    public float smoothSpeed = 0.125f;

    public Vector3 offset;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;


    }

    private void Update()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        
            Vector3 desiredPositon = player.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPositon, smoothSpeed * Time.deltaTime);

            transform.position = smoothedPosition;
        
    }



}
