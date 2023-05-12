using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PInteractUI : MonoBehaviour {

    [SerializeField] private GameObject containerGObj;
    [SerializeField] private PlayerInteract playerInteract;

    
    private void Update() { 
    
        if(playerInteract.GetInteractableObject()!= null) {

            Show();
        
        }else {

            Hide();

        }
    
    
    }



    private void Show() {

        containerGObj.SetActive(true);
    
    }

    private void Hide() {

        containerGObj.SetActive(false);
    
    }

    //shows UI based on the range of the player to show button which needs to be pressed


}
