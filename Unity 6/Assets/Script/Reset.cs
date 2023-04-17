using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //加载场景

public class Reset : MonoBehaviour
{
    public void Restart() //重新加载场景
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
