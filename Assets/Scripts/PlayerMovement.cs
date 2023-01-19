using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 3.0f;

    public Rigidbody rb;

    Vector3 playerMovement;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement.x = Input.GetAxisRaw("Horizontal");
        playerMovement.z = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + playerMovement * playerSpeed * Time.deltaTime);
    }
}
