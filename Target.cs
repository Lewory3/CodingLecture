using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    public float Health; //made public so I can change the health based on the enemy without making more than 1 script


    public void TakeDamage(float amount) {

        Health -= amount;
        if (Health <= 0) {

            Destroy(gameObject);
        
        }
    
    }


}
