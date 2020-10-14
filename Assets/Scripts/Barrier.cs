﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{ 
    private void OnTriggerEnter2D(Collider2D other)
    {
        AstroidSpawner.currentNumOfAstroids--;
        Destroy(other.gameObject);
    }
}
