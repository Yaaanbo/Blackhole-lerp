using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubseSpawner : MonoBehaviour
{
    public GameObject cube;
    public float spawnDelay;

    GameObject cb;
    // Update is called once per frame
    private void Start()
    {
        StartCoroutine(spawnCube());
        Destroy(cb, 15);
    }

    IEnumerator spawnCube()
    {       
        Vector3 pos = new Vector3(Random.Range(-93, 85), 0, Random.Range(-55, 40));
        cb = Instantiate(cube, pos, Quaternion.identity);
        yield return new WaitForSeconds(spawnDelay);
        StartCoroutine(spawnCube());
    }
}
