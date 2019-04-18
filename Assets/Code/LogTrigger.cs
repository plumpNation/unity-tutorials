using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogTrigger : MonoBehaviour {
  private void OnTriggerEnter(Collider other) {
    Debug.Log("entering " + other.gameObject.name);
  }

  private void OnTriggerExit(Collider other) {
    Debug.Log("exiting " + other.gameObject.name);
  }
}
