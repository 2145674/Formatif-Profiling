using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController
    : MonoBehaviour
{
    public GameObject spherePrefab;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("Spawn", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        Spawn();
    }

    private void Spawn()
    {
        for (int i = 0; i < 10; i++)
        {
            float spawnx = Random.Range(1, 25.5f);
            Vector3 spawnPos = new Vector3(spawnx, 0, 0);
            Instantiate(spherePrefab, spawnPos, transform.rotation);
        }
    }
}
