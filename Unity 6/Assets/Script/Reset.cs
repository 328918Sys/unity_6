using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //���س���

public class Reset : MonoBehaviour
{
    public void Restart() //���¼��س���
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
