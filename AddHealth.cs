using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHealth : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject crumb;
    public HealthManager healthManager;


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            healthManager.AddHP();
            crumb.SetActive(false);

        }
    }
}
