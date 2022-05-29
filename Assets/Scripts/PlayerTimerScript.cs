using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTimerScript : MonoBehaviour
{
    [SerializeField] float time = 50f;
    private float endtime;
    // Start is called before the first frame update
    void Start()
    {
        endtime = Time.time + time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > endtime){
            gameObject.GetComponent<PlayerMovementScript>().Die();
        }
    }

    public void RestartTime(){
        endtime = Time.time + time;
    }
}
