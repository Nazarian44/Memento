using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIshadowsManager : MonoBehaviour
{
    private MemoryCount memCount;
    public Sprite[] shadows;
    public Sprite currentShadowSprite;
    public Image currentShadow;


    void Start()
    {
        memCount = GameObject.FindGameObjectWithTag("Counter").GetComponent<MemoryCount>();
        
    }

    void Update()
    {
        
    }
}
