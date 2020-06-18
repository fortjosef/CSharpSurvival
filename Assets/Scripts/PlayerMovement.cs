using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float horizontalInput;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        //keys and so forth for axes are set in Edit->Project Settings->Input Manager
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput, 0, 0) * _speed * Time.deltaTime);
    }
}
