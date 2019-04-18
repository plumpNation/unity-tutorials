using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndRotate : MonoBehaviour {

  // translation floats represent unity units that are roughly 1 metre

  [SerializeField]
  Vector3 movementVector = new Vector3(1.0f, 0.0f, 0.0f);

  [SerializeField]
  float rotateX = 0.2f;

  [SerializeField]
  float rotateY = 1f;

  [SerializeField]
  float rotateZ = 2.5f;

  [SerializeField]
  float currentScale = 1.0f;

  [SerializeField]
  float scaleChangePerFrame = 0.001f;

  [SerializeField]
  float speed = 1f;

  [SerializeField]
  bool useSpeed = false;

  // use the world as the origin, and not the object

  [SerializeField]
  Space transformSpace = Space.World;

  // Use this for initialization
  void Start () {

  }

  // Update is called once per frame
  void Update () {
    // time between each update/frame
    speed = Time.deltaTime;

    Scale();
    Move();
    Rotate();

    currentScale = currentScale + scaleChangePerFrame;
  }

  /// <summary>
  /// This method will make the object scale
  public void Scale() {
    // rotation floats represents degrees
    Vector3 scaleVector = new Vector3(currentScale, currentScale, currentScale);

    transform.localScale = scaleVector;
  }

  /// <summary>
  /// This method will make the object rotate
  public void Rotate() {
    // rotation floats represents degrees
    Vector3 rotationVector = new Vector3(rotateX, rotateY, rotateZ);

    transform.Rotate(rotationVector, transformSpace);
  }

  /// <summary>
  /// This method will make the object move
  public void Move() {
    Vector3 movingVector = movementVector;

    if (useSpeed) {
      movingVector = movingVector * speed;
    }

    transform.Translate(movingVector, transformSpace);
  }
}
