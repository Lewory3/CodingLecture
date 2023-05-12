using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour {

    public string NPCText;  //made string public so I don't need to make more scripts for every text
    
    
    public void Interact() {

        ChatBubble3D.Create(transform.transform, new Vector3(-.3f, 1.7f, 0), NPCText);
        //calls the function of the chatbubble script each time this function is called in the player interaction script 

    }
  
}
