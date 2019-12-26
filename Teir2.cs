using UnityEngine;
using System.Collections;

public class Teir2 : MonoBehaviour {

    public float tierSpeed = 0.1f;
    private float currentZ;

    void Start()
    {
        currentZ = transform.position.z;
    }

    void Update () {

        transform.position -= new Vector3(0, 0,tierSpeed * Time.deltaTime);
	
	}
}
