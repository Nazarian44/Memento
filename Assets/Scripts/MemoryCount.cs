using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCount : MonoBehaviour
{
    public int memories;
    public static MemoryCount instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        memories = 3;
    }

    public void AddMemory()
    {
        memories ++;
    }
}
