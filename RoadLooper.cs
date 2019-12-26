using UnityEngine;
using System.Collections;

public class RoadLooper : MonoBehaviour {

    int numBGPanels = 77;
    void OnTriggerEnter(Collider loopCol)
    {
        float widthOfBGObject = ((BoxCollider)loopCol).size.z;

        Vector3 pos = loopCol.transform.position;
        pos.z += widthOfBGObject * numBGPanels;
        loopCol.transform.position = pos;
    }
}
