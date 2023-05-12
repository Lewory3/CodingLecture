using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public float damage;
    public float range; //made both public so I can change the based on the different weapons

    public Camera camera;

    public ParticleSystem muzzleFlash;


    void Update() {

        if(Input.GetButtonDown("Fire1")) {

            Shoot();
        
        }

        //script check if mousebutton1 is pressed if so the function gets called

    }

    void Shoot() {

        muzzleFlash.Play();
        
        RaycastHit hit;
        if(Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, range)) {

            Target target = hit.transform.GetComponent<Target>();
            if(target != null) {

                target.TakeDamage(damage);
            
            }
        
        }
        
        // scripts checks if the ray hits a collider and if so outs damage

    }

}
