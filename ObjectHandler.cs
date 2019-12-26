using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHandler : MonoBehaviour
{

    public GameObject[] carPrefabs;
    public float maxPos = 0f;
    public float increase = 10f;
    public float startTime = 10f;


    // Use this for initialization
    void Start()
    {
        increase = 10f;
        Invoke("CarSpawner", startTime);


    }
    void CarSpawner()
    {
        increase -= 0.3f;
        Invoke("CarSpawner", Mathf.Clamp(increase, 1f, increase));
        Instantiate(carPrefabs[Random.Range(0, carPrefabs.Length)], transform.position, transform.rotation);
    }
}
