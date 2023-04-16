using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    public void Click1(){
    UnityEngine.Debug.Log("Environment_Free");
    SceneManager.LoadScene("home page");
    }

    public void Click2(){
    UnityEngine.Debug.Log("home page");
    SceneManager.LoadScene("Environment_Free");
    }
      public void Click3(){
            UnityEngine.Debug.Log("hong");
            SceneManager.LoadScene("home page");
            }
    public void Click4(){
                        UnityEngine.Debug.Log("selina");
                        SceneManager.LoadScene("home page");
                        }
    public void Click5(){
    UnityEngine.Debug.Log("home page");
    SceneManager.LoadScene("hong");
    }
    public void Click6(){
    UnityEngine.Debug.Log("home page");
    SceneManager.LoadScene("selina");
    }
        public void Click7(){
        UnityEngine.Debug.Log("home page");
        SceneManager.LoadScene("Demo");
        }
}
