using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatBubble3D : MonoBehaviour {

    private SpriteRenderer backgroundSpriteRenderer;
    private TextMeshPro textMeshPro;


    public static void Create(Transform parent, Vector3 localPosition, string text) {

        Transform chatBubbleTransform = Instantiate(GameAssets.i.ChatBubble3D, parent);
        chatBubbleTransform.localPosition = localPosition;

        chatBubbleTransform.GetComponent<ChatBubble3D>().Setup(text);

        Destroy(chatBubbleTransform.gameObject, 6.5f);
    
    }

    private void Setup(string text) {

        textMeshPro.SetText(text);
        textMeshPro.ForceMeshUpdate();      //avoids text not rendering instantly
        Vector2 textSize = textMeshPro.GetRenderedValues(false);
        Vector2 padding = new Vector2(2.5f, 2.5f);
        backgroundSpriteRenderer.size = textSize + padding;
        backgroundSpriteRenderer.transform.localPosition = new Vector3(backgroundSpriteRenderer.size.x / 3f, 0f);
        // sets the gameobject size based on the text length to avoid text to outbound it

    }


}
