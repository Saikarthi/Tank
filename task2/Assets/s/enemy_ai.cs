using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy_ai : MonoBehaviour
{
    private GameObject player;
    private NavMeshAgent enemy;
    private bool flee = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GetComponent<NavMeshAgent>();
        
    }


    void Update()
    {
       
        if (flee == false)
        {
            enemy.destination = player.transform.position;
        }
        else
        {
            Vector3 dirtoplayer = transform.position - player.transform.position;

            Vector3 newpos = transform.position + dirtoplayer;

            enemy.SetDestination(newpos);
        }
    }
  
}
