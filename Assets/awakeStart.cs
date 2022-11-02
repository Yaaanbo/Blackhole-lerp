using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awakeStart : MonoBehaviour
{
    public float speed;
    private void Awake()
    {
        this.transform.position += Vector3.left * speed * Time.deltaTime;
    }
    // Start is called before the first frame update
    void Start()
    {
        //this.transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
