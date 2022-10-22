using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform thePlayer;
    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(thePlayer.position.x, thePlayer.position.y, transform.position.z);
    }
}
