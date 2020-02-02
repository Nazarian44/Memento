using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomController : MonoBehaviour
{
    [SerializeField] EnemyCollision enemyCollision;
    [SerializeField] CameraController camera;

    private void Start()
    {
        camera = gameObject.GetComponent <CameraController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.enemyCollision = collision.GetComponent<EnemyCollision>();

        if (collision.gameObject.name == "Enemy")
        {
            camera.Zoom();
        }
    }
    private void Update()
    {
        {

        }
        //Camera.main.orthographicSize += 1f;
        Debug.Log("ZoomWithCollision working");
    }
}
