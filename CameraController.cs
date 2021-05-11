using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensitivity = 0.5f;
    public GameObject player;
   // Vector3 v;
   // float left = 0f;
    //float right = 0f;
   
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }
 
    void Update()
    {

        //player.transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * sensitivity, 0);

        /*var v3 = new Vector3(Input.GetAxis("Fire1"), Input.GetAxis("Fire2"), 0.0f);
        player.transform.Rotate(v3 * sensitivity * Time.deltaTime);*/

        if (Input.GetButton("Fire1"))
        {
            player.transform.Rotate(0, Input.GetAxis("Fire1") * sensitivity * Time.deltaTime, 0);
        }

        if (Input.GetButton("Fire2"))
        {
            player.transform.Rotate(0, Input.GetAxis("Fire2") * -1 * sensitivity * Time.deltaTime, 0);
        }

        
        //player.transform.Rotate(0, 0+right+left, 0);

    }
}
