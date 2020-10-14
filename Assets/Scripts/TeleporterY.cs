using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterY : MonoBehaviour
{
    public Transform teleportTarget;
    private void OnTriggerEnter2D(Collider2D other)
    {
        var pos = other.transform.position;
        pos.y = teleportTarget.position.y;
        other.transform.position = pos;
    }

}
