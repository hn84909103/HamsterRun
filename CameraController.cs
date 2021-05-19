using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensitivity = 0.5f;
    public GameObject player;
   
    void Start()
    {
    }
 
    void Update()
    {

        if (Input.GetButton("Fire1"))
        {
            player.transform.Rotate(0, Input.GetAxis("Fire1") * sensitivity * Time.deltaTime, 0);
        }

        if (Input.GetButton("Fire2"))
        {
            player.transform.Rotate(0, Input.GetAxis("Fire2") * -1 * sensitivity * Time.deltaTime, 0);
        }

    }
}
