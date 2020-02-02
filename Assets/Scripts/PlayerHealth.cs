using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private GameObject counter;


    void Awake()
    {
        counter = GameObject.FindGameObjectWithTag("Counter");
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player Hit");
            SFXmanager.PlaySound("enemySound");
            counter.GetComponent<MemoryCount>().memories--;
        }
    }

}
