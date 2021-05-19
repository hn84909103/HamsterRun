using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController3 : MonoBehaviour
{
    private Transform p1;
    private Transform p2;
    private NavMeshAgent nav;
    private bool flag1;
    private bool flag2;

    void Start()
    {
        flag1 = false;
        flag2 = false;

        p1 = GameObject.FindGameObjectWithTag("point1").transform;
        p2 = GameObject.FindGameObjectWithTag("point2").transform;

        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (!flag1 && !flag2)
        {
            nav.SetDestination(p1.position);
        }
        else if (flag1 && !flag2)
        {
            nav.SetDestination(p2.position);

        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "point1")
        {
            flag1 = true;
            Debug.Log("flag1 touched");
        }
        
        if (collision.gameObject.tag == "point2")
        {
            flag2 = true;
            Debug.Log("flag2 touched");
            flag1 = false;
            flag2 = false;
        }
    }
}
