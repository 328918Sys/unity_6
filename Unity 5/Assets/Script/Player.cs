using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody rd;
    public int score = 0;
    public Text scoreText;
    public GameObject winText;

    public float speed = 5.0f;
    private float horizontalInput;
    private float verticalInput;

    private AudioSource audios;
    public AudioClip collectCoin;
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        audios = GetComponent<AudioSource>();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * speed * verticalInput);
        transform.Translate(Vector3.back * Time.deltaTime * speed * horizontalInput);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        MyInput();
    }
    /*void Update()
    {
        //rd.AddForce(Vector3.right);
        //rd.AddForce(new Vector3(5,0,0));
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Debug.Log(h);
        Debug.Log(v);
        rd.AddForce(new Vector3(h, 0, v));
    }*/
    /*private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter" + collision.tag);
        if(collision.gameObject.tag == "Food")
        {
            Destroy(collision.gameObject);
        }
    }*/
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("OnTriggerEnter" + other.tag);
        if (other.tag == "Food")
        {
            audios.clip = collectCoin;
            audios.Play();
            Destroy(other.gameObject);
            score++;
            scoreText.text = "Score: " + score;
        }
        if(other.tag == "Gold")
        {
            audios.clip = collectCoin;
            audios.Play();
            Destroy(other.gameObject);
            score+=2;
            scoreText.text = "Score: " + score;
        }
        if (score >= 10)
                    {
                        winText.SetActive(true);
                        Invoke("ReMenu", 1.5f);
                    }
    }

    private void ReMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

}