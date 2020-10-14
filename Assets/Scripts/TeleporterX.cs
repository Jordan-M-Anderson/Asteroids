using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterX : MonoBehaviour
{
    public Transform teleportTarget;
    private void OnTriggerEnter2D(Collider2D other)
    {
        var pos = other.transform.position;
        pos.x = teleportTarget.position.x;
        other.transform.position = pos;
    }

}
