using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fox : MonoBehaviour
{

   public Text text;
   private int score = 0;
   public GameObject winText;
   Animator ani;
   public AudioSource eggBGM;


    void Start()
    {
        ani = GetComponent<Animator>();
        eggBGM.Stop();
    }
    void Update()
    {

        float vertical = Input.GetAxis("Vertical");
	    float horizontal =Input.GetAxis("Horizontal");
	    Vector3 dir = new Vector3(vertical,0,horizontal);
	    if (dir != Vector3.zero){
		    transform.rotation = Quaternion.LookRotation(dir);
		    transform.Translate(Vector3.forward*2*Time.deltaTime);
		    ani.SetBool("Run_Fox",false);
	    }else{
		    ani.SetBool("Run_Fox",true);
	    }

    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "PickUp"){
            Destroy(collision.collider.gameObject);
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("OnTriggerEnter"+collider.tag);
        if(collider.tag == "PickUp"){
            eggBGM.Play();
            score++;
            text.text = score.ToString();
            if(score == 5){
                winText.SetActive(true);
            }
            Destroy(collider.gameObject);
        }
    }

}

