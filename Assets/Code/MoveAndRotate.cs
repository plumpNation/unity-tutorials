using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndRotate : MonoBehaviour {

  [SerializeField]
  float speed = 1f;

  [SerializeField]
  bool scaleToTime = false;

  // Use this for initialization
  void Start () {

  }

  // Update is called once per frame
  void Update () {
    if (scaleToTime) {
      speed = Time.deltaTime;
    }
  }

  /// <summary>
  /// This method will make the object rotate
  public void Rotate(float rotateX, float rotateY) {
    // rotation floats represents degrees
    Vector3 rotationVector = new Vector3(rotateX, rotateY, 0.0f);

    transform.Rotate(rotationVector);
  }

  /// <summary>
  /// This method will make the attached object move along the x, y, z every
  /// time it is called.
  public void Move(float moveX, float moveY) {
    Vector3 movingVector = new Vector3(moveX, moveY, 0.0f);

    movingVector *= speed;

    transform.Translate(movingVector);
  }
}
