using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;

    public Transform[] destinations;

    public float distanceToFollowPath = 2;

    private int i = 0;

   [Header("----------------------Follow Player?----------------------")]

    public bool followPlayer;

    private GameObject player;

    private float distanceToPlayer;

    public float distanceToFollowPlayer = 10;


    void Start()
    {
        navMeshAgent.destination = destinations[0].transform.position;

        player = FindAnyObjectByType<PlayerMovement>().gameObject;
    }
    

    void Update()
    {

        distanceToPlayer = Vector3.Distance(transform.position,player.transform.position);
        if (distanceToPlayer <= distanceToFollowPlayer && followPlayer)
        {
            FollowPlayer();
        }
        else
        {
            EnemyPath();
        }

    }

    public void EnemyPath()
    {
        navMeshAgent.destination = destinations[i].position;

        if (Vector3.Distance(transform.position, destinations[i].position) <= distanceToFollowPath)
        {
            if (destinations[i] != destinations[destinations.Length - 1])
            {
                i++;
            }
            else
            {
                i = 0;
            }
        }

    }

    public void FollowPlayer()
    {
        navMeshAgent.destination = player.transform.position;
    }

}
