using UnityEngine;
using System.Collections;

public class DDMMCar : MonoBehaviour {

    public Camera cam;
    public float speed = 1f;
    public float leftLock;
    public float rightLock;
    public float dieCount;
    private float pressTime;

    public GameObject smokePuff;

    public AudioClip crashNoise;
    private bool leftKeys = false;
    private bool rightKeys = false;

    Vector3 lastMouseCoordinate = Vector3.zero;

	// Use this for initialization
	void Start () {
	if(cam == null)
        {
            cam = Camera.main;
        }
	}

    void Update()
    {
        pressTime -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            
            leftKeys = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {

            rightKeys = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
        {
            pressTime = 1f;
            leftKeys = false;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
        {
            pressTime = 1f;
            rightKeys = false;
        }
        Debug.Log(pressTime);
    }

    // Update is called once per frame
    void FixedUpdate() {


            if (leftKeys)
            {
                Vector3 position = this.transform.position;
                position.x -= 1 * speed * Time.deltaTime;
                this.transform.position = new Vector3(Mathf.Clamp(position.x, -leftLock, rightLock), transform.position.y, transform.position.z);
            }
            if (rightKeys)
            {
            Vector3 position = this.transform.position;
            position.x += 1 * speed * Time.deltaTime;
            this.transform.position = new Vector3(Mathf.Clamp(position.x, -leftLock, rightLock), transform.position.y, transform.position.z);
        }
        }

    void OnCollisionEnter(Collision hitBrick)
    {
        Crashables crasher = hitBrick.gameObject.GetComponent<Crashables>();
        if (crasher)
        {
            GameObject crashSmoke = Instantiate(smokePuff, transform.position, Quaternion.identity) as GameObject;
            AudioSource.PlayClipAtPoint(crashNoise, Camera.main.transform.position, 1f);
            Destroy(gameObject.GetComponent<SpriteRenderer>());
            Destroy(gameObject.GetComponent<BoxCollider>());
            Invoke("Die", dieCount);
            Destroy(crashSmoke, 2f);
        } 
}
        void Die()
    {
        RoadBehavior.roadSpeed = -10f;
        Crashables.barSpeed = -5f;
        CatchBehaviour.speed = -5f;
        ScoreTrackering.scoreNum = 0;
        Application.LoadLevel(1);
    }
    }

