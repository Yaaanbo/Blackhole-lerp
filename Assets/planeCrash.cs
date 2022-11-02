using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeCrash : MonoBehaviour
{
    public GameObject tower;
    public float Speed;
    public GameObject cameraPlane;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = tower.transform.position - this.transform.position;
        Vector3 velocity = direction.normalized * Speed * Time.deltaTime;
        if (Vector3.Distance(this.transform.position, tower.transform.position) > 0)
        {
            this.transform.position += velocity;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("tower"))
        {
            cameraPlane.transform.SetParent(null);
            Destroy(this.gameObject, 0.5f);        
        }
    }
}
