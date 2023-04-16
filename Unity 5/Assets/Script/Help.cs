using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour
{
    public GameObject helpList;
    //[SerializeField] private bool helpKeys = true;
    [SerializeField] private AudioSource bgmSound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    public void HelpAct()
    {
        helpList.SetActive(true);
        //helpKeys = false;
        Time.timeScale = 0;// ±º‰Õ£÷π
        bgmSound.Pause();//“Ù¿÷‘›Õ£
    }

    public void HelpClose()
    {
        helpList.SetActive(false);
        //helpKeys = true;
        Time.timeScale = 1;// ±º‰ºÃ–¯
        bgmSound.Play();//“Ù¿÷≤•∑≈
    }
}
