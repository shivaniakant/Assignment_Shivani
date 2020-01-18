using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Snake : MonoBehaviour {
    // Current Movement Direction
    // (by default it moves to the right)
    Vector2 dir = Vector2.right;

    // Use this for initialization
    void Start () {
        // Move the Snake every 300ms
        InvokeRepeating("Move", 0.3f, 0.3f);    
    }
   
    // Update is called once per frame
    void Update () {
   
    }
   
    void Move() {
        // Move head into new direction
        transform.Translate(dir);
    }
}

