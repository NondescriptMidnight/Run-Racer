using UnityEngine;
using System.Collections;

public class FingerSwipe : MonoBehaviour {


    public float delta = 1.5f;  // Amount to move left and right from the start point
    public float speed = 2.5f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
        Destroy(gameObject, 5.5f);
    }
}