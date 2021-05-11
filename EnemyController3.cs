using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController3 : MonoBehaviour
{
    private Transform p1;
    private Transform p2;
    //private Transform p3;
    private NavMeshAgent nav;
    private bool flag1;
    private bool flag2;
    //private bool flag3;

    // Start is called before the first frame update
    void Start()
    {
        flag1 = false;
        flag2 = false;
        //flag3 = false;

        p1 = GameObject.FindGameObjectWithTag("point1").transform;
        p2 = GameObject.FindGameObjectWithTag("point2").transform;
        //p3 = GameObject.FindGameObjectWithTag("point3").transform;


        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!flag1 && !flag2 /*&& !flag3*/)
        {
            nav.SetDestination(p1.position);
        }
        else if (flag1 && !flag2)
        {
            nav.SetDestination(p2.position);

        }
        /*else if (flag1 && flag2 && !flag3)
        {
            nav.SetDestination(p3.position);
            
        }*/
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
        /*
        if (collision.gameObject.tag == "point3")
        {
            flag3 = true;
            Debug.Log("flag3 touched 3");
            flag1 = false;
            flag2 = false;
            flag3 = false;
        }*/
    }
}
