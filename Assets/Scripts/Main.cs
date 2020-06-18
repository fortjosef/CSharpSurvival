using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("space key");
        }

        //true when key is held down, misleading, get fire during an average key press
        if (Input.GetKey(KeyCode.E)) {
            Debug.Log("holding E");
        }

        if (Input.GetKeyUp(KeyCode.F)) {
            Debug.Log("F Up");
        }
    }
}
