using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera cam;

    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        cam.transform.position = new Vector3(transform.position.x, transform.position.y, (float)-7.55);

    }

    // Update is called once per frame

    private void Update()
    {
        cam.transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, (float)-7.55);

    }


}
