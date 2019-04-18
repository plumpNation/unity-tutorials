using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {
  MoveAndRotate moveComponent;

  // Use this for initialization
  void Start () {
    // initialise MoveAndRotate component
    moveComponent = this.GetComponent<MoveAndRotate>();

    if (moveComponent == null) {
      Debug.LogError("MoveAndRotate may not be attached to this game object");
    }

  }

  /// <summary>
  /// In each frame we will grab input values and call appropriate methods
  void Update () {
    float moveX = Input.GetAxis("MovementX");
    float moveY = Input.GetAxis("MovementY");
    float rotateX = Input.GetAxis("RotateX");
    float rotateY = Input.GetAxis("RotateY");

    bool pressed = Input.GetButtonDown("Pulse");

    moveComponent.Move(moveX, moveY);
    moveComponent.Rotate(rotateX, rotateY);

    if (pressed) {
      Pulse();
    }
  }

  void Pulse() {
    Debug.Log("PULSE!");
  }
}
