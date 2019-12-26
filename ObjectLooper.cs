using UnityEngine;
using System.Collections;

public class ObjectLooper : MonoBehaviour {

    int numBGPanels = 1000;
    void OnTriggerEnter(Collider loopCol)
    {
        float widthOfBGObject = ((BoxCollider)loopCol).size.z;

        Vector3 pos = loopCol.transform.position;
        pos.z += widthOfBGObject * numBGPanels;
        loopCol.transform.position = pos;
    }
}
