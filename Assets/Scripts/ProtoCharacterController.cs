using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtoCharacterController : MonoBehaviour
{

  //  [SerializeField] private CameraController camera;
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    //    this.camera = gameObject.GetComponent<CameraController>();
    }


    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.deltaTime);
    }


    /*private void OnTriggerEnter(Collider other)
    {
        EnemyMovement enemyMovement = other.GetComponent<EnemyMovement>();

        if (enemyMovement != null)
        {
            this.camera.Zoom();
        }
        else
        {
            Debug.LogError("ProtoCharacter not found at all");
        }
    }*/
}
