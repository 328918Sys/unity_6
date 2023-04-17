using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //加载场景

public class playerDeath : MonoBehaviour
{
    AudioSource audioS;
    public AudioClip die;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        audioS = GetComponent<AudioSource>();
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Death();
        }
    }*/

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            audioS.clip = die;
            audioS.Play();
            Invoke("Restart", 1f);
        }
    }

    /* private void Death()
     {
         audioS.clip = die;
         audioS.Play();
         Destroy(playerEffect, 1f);

     }*/

    private void Restart() //重新加载场景
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
