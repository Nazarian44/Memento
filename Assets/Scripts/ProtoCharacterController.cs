using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtoCharacterController : MonoBehaviour
{

    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Memory")
        {
            Debug.Log("Memoria reconocida");
        }
    }*/
}
