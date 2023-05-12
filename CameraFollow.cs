using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    [Header("References")]
    [SerializeField] private Transform cameraPosition;

    void Update() {

        transform.position = cameraPosition.position;
        // camera is put on an empty object to avoid bugs so I need to make that object to follow the player

    }
}
