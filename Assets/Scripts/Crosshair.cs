using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{

    private Vector2 mousePos;


    [SerializeField]
    public float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = Vector2.Lerp(transform.position, mousePos, moveSpeed);
        }
 
    }

    private void OnTriggerEnter2D(Collider2D other) {

        if (Input.GetMouseButton(0))
        {
            AstroidSpawner.currentNumOfAstroids--;
            Destroy(other.gameObject);
        }
    }
}
