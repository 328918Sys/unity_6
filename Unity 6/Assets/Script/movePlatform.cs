using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlatform : MonoBehaviour
{
    public float speed = 20.0f;
    public float waitTime;
    public Transform[] movePos;
    private int i;

    void Start()
    {
        i = 1;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePos[i].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, movePos[i].position) < 0.1f)
        {
            if (waitTime < 0.0f)
            {
                if (i == 0)
                {
                    i = 1;
                }
                else
                {
                    i = 0;
                }
                waitTime = 0.5f;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}