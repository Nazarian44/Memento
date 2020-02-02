using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXmanager : MonoBehaviour
{

    public static AudioClip enemySound;
    static AudioSource source;

    void Start()
    {
        enemySound = Resources.Load<AudioClip>("enemyfx");

        source = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        source.PlayOneShot(enemySound);
    }

}
