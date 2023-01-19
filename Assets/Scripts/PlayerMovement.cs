using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 3.5f;
    public float playerJumpHeight = 225.0f;
    public Rigidbody rb;
    Vector3 playerMovement;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;

        if (Input.GetKeyDown(KeyCode.Space) && rb.position.y == 0.5)
        {
            rb.AddForce(Vector3.up * playerJumpHeight);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + playerMovement * playerSpeed * Time.deltaTime);
    }
}
