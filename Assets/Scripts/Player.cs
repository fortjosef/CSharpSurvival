using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Vector3 startPosition;
    Renderer renderer;
    public int speed = 0;
    public int maxSpeed;
    public GameObject daCube;
    public CustomClass[] test;
    public CustomClass foo;

    void changeColor(GameObject objectToChange, Color colorToChangeTo) {
        MeshRenderer mr = objectToChange.GetComponent<MeshRenderer>();
        mr.material.color = colorToChangeTo;
    }

    // Start is called before the first frame update
    void Start() {
        //make sure player is at the origin
        transform.position = startPosition;
        renderer = GetComponent<Renderer>();
        renderer.material.color = Color.red;
        maxSpeed = Random.Range(60, 120);
        StartCoroutine(speedFunc());
        //StartCoroutine(myfunc());
    }

    private IEnumerator speedFunc() {
        Debug.Log("coroutine called");
        while (speed < maxSpeed) {
            speed += 5;
            Debug.Log("Incremented speed to " + speed.ToString());
            yield return new WaitForSeconds(1);
        }
    }

    private IEnumerator myfunc() {
        int ticks = 0;
        while (true) {
            ticks++;
            Debug.Log("Tick " + ticks.ToString());
            yield return new WaitForSeconds(1);
        }
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.C)) {
            renderer.material.color = Color.green;
        }

        Color colorToUse = Color.green;
        bool hasUpdate = false;

        if (Input.anyKey) {
            //Debug.Log(Input.inputString);
            switch (Input.inputString) {
                case "1":
                    colorToUse = Color.blue;
                    hasUpdate = true;
                    break;
                case "2":
                    colorToUse = Color.red;
                    hasUpdate = true;
                    break;
                case "3":
                    colorToUse = Color.green;
                    hasUpdate = true;
                    break;
                case "4":
                    colorToUse = Color.black;
                    hasUpdate = true;
                    break;
                case "p":
                    changeColor(daCube, Color.cyan);
                    break;
            }

            if (hasUpdate) {
                renderer.material.color = colorToUse;
            }
        }
    }
}
