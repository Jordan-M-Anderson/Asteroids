using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public Rigidbody2D rBody;

    // Start is called before the first frame update
    void Start() { 
        rBody.AddForce(new Vector2(Random.Range(-200, -500), 0));
    }

}
