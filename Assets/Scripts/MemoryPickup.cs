using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryPickup : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            MemoryCount.instance.AddMemory();
        }
    }
}
