using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogCollision : MonoBehaviour {

  void OnCollisionEnter(Collision collision) {
    string otherObject = collision.gameObject.name;

    Debug.Log(otherObject);
  }

  // Use this for initialization
  void Start () {

  }

  // Update is called once per frame
  void Update () {

  }
}
