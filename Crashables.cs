using UnityEngine;
using System.Collections;

public class Crashables : MonoBehaviour {

    public static float barSpeed = -5f;
	
	// Update is called once per frame
	void Update () {

        transform.position += new Vector3(0,0, barSpeed) * Time.deltaTime; 
	
	}
}
