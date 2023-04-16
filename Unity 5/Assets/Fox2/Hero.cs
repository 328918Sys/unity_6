using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
   public Text text;
   private int score = 0;
   public GameObject winText;
   Animator ani;
   //public AudioSource eggBGM;


    void Start()
    {
        ani = GetComponent<Animator>();
        //eggBGM.Stop();
    }
    void Update()
    {

        float vertical = Input.GetAxis("Vertical");
	    float horizontal =Input.GetAxis("Horizontal");
	    Vector3 dir = new Vector3(vertical,0,-horizontal);
	    if (dir != Vector3.zero){
		    transform.rotation = Quaternion.LookRotation(dir);
		    transform.Translate(Vector3.forward*5*Time.deltaTime);
		    ani.SetBool("WalkForwardBattle",false);
	    }else{
		    ani.SetBool("WalkForwardBattle",true);
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
        if(collider.tag == "PickUp"){
            //eggBGM.Play();
            score++;
            text.text = score.ToString();
            if(score == 1){
                winText.SetActive(true);
            }
            Destroy(collider.gameObject);
        }
    }
}
