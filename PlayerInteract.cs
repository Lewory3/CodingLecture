using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {
    

    void Update() {

        if (Input.GetKeyDown(KeyCode.E)) {
           
            float interactRange = 2.5f; 
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);

            foreach(Collider collider in colliderArray) { 
            
                if(collider.TryGetComponent(out NPCInteractable npcInteractable)) {

                    npcInteractable.Interact(); 
                    //when E is pressed in the range call the function
                }
            
            }

        }

        //checks if an npc is interactable by "accessing" its collider

    }


    public NPCInteractable GetInteractableObject() {

        float interactRange = 2.5f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);

        foreach (Collider collider in colliderArray) {

            if (collider.TryGetComponent(out NPCInteractable npcInteractable)) {

                return npcInteractable;

            }

        }

        return null;

    }

    //needed to return to other stuff if an npc was interactable

}
