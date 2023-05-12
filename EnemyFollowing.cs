using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollowing : MonoBehaviour {

    public NavMeshAgent enemy;
    public Transform playerPos;


    void Update() {

        enemy.SetDestination(playerPos.position);
        //put a navmesh on acertain point of the map, scripts get player position and enemy follows
        
    }
}
