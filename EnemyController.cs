using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{ 
    private Transform p1;
    private Transform p2;
    private NavMeshAgent nav;
    private bool flag;
    

    // Start is called before the first frame update
    void Start()
    {
        flag = false; 

        p1 = GameObject.FindGameObjectWithTag("point1").transform;
        p2 = GameObject.FindGameObjectWithTag("point2").transform;


        nav = GetComponent<NavMeshAgent>();
 

    }

    // Update is called once per frame
    void Update()
    {
  
       if(flag)
        {
            nav.SetDestination(p2.position);
            Debug.Log("flag = " + flag);
        }else
        {
            nav.SetDestination(p1.position);
            Debug.Log("flag = " + flag);
        }
        
        
    }
    
    public void OnCollisionEnter(Collision collision)
    {   
        if (collision.gameObject.tag == "point1")
        {
            flag = true;
        }

        
        if (collision.gameObject.tag == "point2")
        {
            flag = false;
        }
    }

}
