using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public Rigidbody duckPrefab;
    public int forceToSpawn = 100;
    public GameManager gameManager;

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Invoke("spawnDucks", .5f);
        }
        if (gameManager.numberOfBounces == 10)
        {
            callFunctionXtimes(2);
        }
        if (gameManager.numberOfBounces == 50)
        {
            callFunctionXtimes(4);
        }
        if (gameManager.numberOfBounces == 100)
        {
            callFunctionXtimes(10);
        }
        if (gameManager.numberOfBounces == 500)
        {
            callFunctionXtimes(20);
        }
        if (gameManager.numberOfBounces == 1000)
        {
            callFunctionXtimes(50);
        }
        if (gameManager.numberOfBounces == 2500)
        {
            callFunctionXtimes(75);
        }
        if (gameManager.numberOfBounces == 10000)
        {
            callFunctionXtimes(10);
        }
        if (gameManager.numberOfBounces == 100000)
        {
            InvokeRepeating("spawnDucks",0,3f);
        }
    }

    private void spawnDucks()
    {
        Debug.Log("INICIO spawnDucks");
        Rigidbody elementInstance;
        elementInstance = Instantiate(duckPrefab, transform.position, transform.rotation) as Rigidbody;
        elementInstance.AddForce(transform.forward * forceToSpawn);
        Debug.Log("FIN spawnDucks");

    }

    private void callFunctionXtimes(int times)
    {
        for (int i = 0; i < times; i++)
        {
            spawnDucks();
        }
    }
}
