using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Vector3 startPosition;
    Renderer renderer;

    // Start is called before the first frame update
    void Start() {
        //make sure player is at the origin
        transform.position = startPosition;
        renderer = GetComponent<Renderer>();
        renderer.material.color = Color.red;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.C)) {
            renderer.material.color = Color.green;
        }
    }
}
