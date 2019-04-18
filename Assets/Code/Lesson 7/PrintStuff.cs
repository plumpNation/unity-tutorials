using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Method
{
    FIND_BY_NAME,
    FIND_BY_TAG
}

public class PrintStuff : MonoBehaviour {
  [SerializeField]
  Method gameObjectSearchMethod;

  [SerializeField]
  string gameObjectName;

  [SerializeField]
  string gameObjectTag;

  WriteStuff writeStuff;

  // Use this for initialization
  void Start () {
    Debug.Log("PRINT STUFF: Ready to print stuff");

    GameObject gameObject;

    switch(gameObjectSearchMethod) {
      case Method.FIND_BY_NAME:
        gameObject = GameObject.Find(gameObjectName);
        break;

      case Method.FIND_BY_TAG:
        gameObject = GameObject.FindGameObjectWithTag(gameObjectTag);
        break;

      default:
        gameObject = null;
        break;
    }

    if (gameObject == null) {
      Debug.LogError("PRINT STUFF: could not find WriteStuff attached to this game object");

      return;
    }

    writeStuff = gameObject.GetComponent<WriteStuff>();

    if (writeStuff == null) {
      Debug.LogError("PRINT STUFF: could not find WriteStuff attached to this game object");
    }
  }

  // Update is called once per frame
  void Update () {
    if (writeStuff == null) {
      return;
    }

    string nextString = writeStuff.GetStuff();
    int calls = writeStuff.numberCalls;

    Debug.Log("PRINT STUFF: " + calls + " - " + nextString);
  }
}
