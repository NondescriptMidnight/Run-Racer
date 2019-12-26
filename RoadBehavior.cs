using UnityEngine;
using System.Collections;

public class RoadBehavior : MonoBehaviour
{
    public static float roadSpeed = -10f;

    void Start()
    {

    }

    void Update()
    {       
        transform.position += new Vector3 (0,0,roadSpeed) * Time.deltaTime;
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
