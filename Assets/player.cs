using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce;
    public float moveSpeed;

    public enum moveType {cube, sphere}
    public moveType type;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(type == moveType.cube)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector3 move = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
            this.transform.position += move;
        }
        else if(type == moveType.sphere)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            rb.AddForce(new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime, ForceMode.Acceleration);
        }
        //jump();
        
    }

    void jump()
    {
        //bool isGrounded = Physics.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Vector3 jump = new Vector
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
