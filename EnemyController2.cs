using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController2 : MonoBehaviour
{
    private Transform p2;
    private Transform p3;
    private NavMeshAgent nav;
    private bool flag;

    // Start is called before the first frame update
    void Start()
    {
        flag = false;

        p2 = GameObject.FindGameObjectWithTag("point2").transform;
        p3 = GameObject.FindGameObjectWithTag("point3").transform;


        nav = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            nav.SetDestination(p3.position);
            Debug.Log("flag3 = " + flag);
        }
        else
        {
            nav.SetDestination(p2.position);
            Debug.Log("flag2 = " + flag);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "point2")
        {
            flag = true;
            Debug.Log("flag2 touched 2");
        }


        if (collision.gameObject.tag == "point3")
        {
            flag = false;
            Debug.Log("flag2 touched 3");
        }
    }
}
