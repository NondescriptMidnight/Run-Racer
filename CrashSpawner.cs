using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashSpawner : MonoBehaviour
{

    public GameObject crashPrefabs;
    public float maxPos = 0f;
    public float increase = 10f;
    public float startTime = 10f;


    // Use this for initialization
    void Start()
    {
        Invoke("CarSpawner", startTime);


    }
    void CarSpawner()
    {
        increase -= 0.3f;
        Invoke("CarSpawner", Mathf.Clamp(increase, 1f, increase));
        Instantiate(crashPrefabs, transform.position, transform.rotation);
    }
}