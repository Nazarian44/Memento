using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memoryPickup : MonoBehaviour
{
    public int count;
    public MemoryCount mem;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Memoria recuperada");
            Destroy(this.gameObject);
            mem.GetComponent<MemoryCount>().AddMemory();

            
        }
    }
}
