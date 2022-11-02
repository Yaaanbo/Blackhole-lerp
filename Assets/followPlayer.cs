using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    GameObject player;
    public float Speed;
    public Rigidbody rb;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {       
        //Vector3 direction = player.transform.position - this.transform.position;
        Vector3 direction = this.transform.position - player.transform.position;
        Vector3 velocity = direction.normalized * Speed * Time.deltaTime;
        this.transform.position += velocity;
        //rb.AddForce(velocity, ForceMode.Acceleration);
        //if (Vector3.Dot(transform.position, player.transform.position) > 5f)
        //{
        //    rb.AddForce(velocity, ForceMode.Acceleration);
        //}
    }
}
