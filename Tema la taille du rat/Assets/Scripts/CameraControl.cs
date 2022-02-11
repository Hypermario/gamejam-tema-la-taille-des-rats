using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform playerpos;
    public Vector3 camPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerpos != null)
        transform.position = playerpos.transform.position + camPos;
    }
}