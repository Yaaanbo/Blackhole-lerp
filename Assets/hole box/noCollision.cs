using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noCollision : MonoBehaviour
{
    public float moveSpeed;
    //public AnimationCurve anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
        this.transform.position += movement;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.layer = LayerMask.NameToLayer("noColl");
            //other.gameObject.layer = 6;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.layer = LayerMask.NameToLayer("Default");
            //other.gameObject.layer = 0;
        }
    }
}
