using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour {
    [SerializeField]
    private Transform _target;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        Vector3 directionToFace = _target.position - transform.position;
        Debug.DrawRay(transform.position, directionToFace);
        //directionToFace = Quaternion.Euler(new Vector3(0, -90, -90)) * directionToFace;
        Quaternion newRotation = Quaternion.LookRotation(directionToFace);
        transform.rotation = newRotation;
    }
}
