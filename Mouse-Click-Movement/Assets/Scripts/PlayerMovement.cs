using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    NavMeshAgent agent;
    Animator animationPlayer;
    public GameObject player;
    RaycastHit hit;
    int a;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animationPlayer = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        


        if (Input.GetMouseButtonDown(0))
        {
           
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            animationPlayer.SetBool("Run", true);
            animationPlayer.SetBool("Idle", false);

            if (Physics.Raycast(ray,out hit, Mathf.Infinity))
            {
                agent.SetDestination(hit.point);
                
            }

            /*Debug.Log(player.transform.localPosition);
            Debug.Log(player.transform.position);
            Debug.Log(hit.point);

*/
            /* Debug.Log(hit.point);
             Debug.Log(agent.pathEndPosition);*/

          /*  Debug.Log(hit.point);
            Debug.Log(xPosition);*/

            /*if (hit.point.x == agent.pathEndPosition.x)
            {
                Debug.Log("Reached");
            }*/

        }

    /*    if(player.transform.position.z >= 1)
        {
            Debug.Log("Player Reached at point: " + player.transform.position.z);
        }
        
         if(hit.point.z >= 1)
        {
            Debug.Log("hit point reached : " + hit.point.z);
        }*/

         if(player.transform.position.z == hit.point.z)
        {
            animationPlayer.SetBool("Run", false);
            animationPlayer.SetBool("Idle", true);
        }

    }
}
