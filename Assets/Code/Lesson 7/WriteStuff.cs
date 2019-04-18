using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WriteStuff : MonoBehaviour {
  public int numberCalls;

  // Use this for initialization
  void Start () {
    Debug.Log("WRITE STUFF: Ready to write stuff");

    numberCalls = 0;
  }

  public string GetStuff() {
    numberCalls++;

    return "STUFF";
  }
}
