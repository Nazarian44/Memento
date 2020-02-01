using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCount : MonoBehaviour
{
    public int memories;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            AddMemory();
        }
    }

    public void AddMemory()
    {
        memories = memories + 1;
    }
}
