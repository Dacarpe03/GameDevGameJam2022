using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    private float nextScene;

    void Start(){
        nextScene = Time.time + 15f;
    }

    void Update(){
        if (nextScene < Time.time){
            SceneManager.LoadScene(1);
        }
    }
}
