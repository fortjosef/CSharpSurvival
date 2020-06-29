using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour {
    public float bill = 40f;
    public float tipPct = .2f;

    // Start is called before the first frame update
    void Start() {
        float tip = bill * tipPct;
        Debug.Log("Your bill is " + bill + "\nYour tip is " + tip + "\nYour total is " + (bill + tip));
    }

    // Update is called once per frame
    void Update() {
        
    }
}
