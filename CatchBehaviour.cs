using UnityEngine;
using System.Collections;

public class CatchBehaviour : MonoBehaviour
{

    public static float speed = -5.0f;
    private Vector3 currPos;

    public AudioClip popSound;
    public AudioClip itemDescript;

    public GameObject popAni;

    public int scoreValue = 1;

    void Start()
    {
        currPos = transform.position;
    }

    void Update()
    {
            transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
    }

    void OnCollisionEnter(Collision objCol)
    {
        DDMMCar player = objCol.gameObject.GetComponent<DDMMCar>();
        if (player)
        {
            Die();
        }
    }
        void Die()
    {
        RoadBehavior.roadSpeed -= 0.5f;
        Crashables.barSpeed -= 0.5f;
        speed -= 0.5f;
        ScoreTrackering.scoreNum += 1;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        GameObject pop = Instantiate(popAni, transform.position, Quaternion.identity) as GameObject;
        AudioSource audio = GetComponent<AudioSource>();
        audio.PlayOneShot(popSound);
        audio.PlayOneShot(itemDescript);
        Destroy(pop, 0.5f);
        Destroy(gameObject, itemDescript.length);
    }
    }
