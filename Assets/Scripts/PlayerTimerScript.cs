using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTimerScript : MonoBehaviour
{
    [SerializeField] float time = 50f;
    [SerializeField] AudioSource backgroundSource;
    [SerializeField] AudioClip exploringAudio;
    [SerializeField] AudioClip outOfLigthAudio;

    private float endtime;
    private bool wait = false;
    // Start is called before the first frame update
    void Start()
    {
        endtime = Time.time + time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > endtime && !wait){
            gameObject.GetComponent<PlayerMovementScript>().WaitForDeath();
        }
    }

    public void RestartTime(){
        endtime = Time.time + time;
        wait = false;
        backgroundSource.Stop();
        backgroundSource.PlayOneShot(exploringAudio);
    }

    public float GetTimeLeft(){
        float timeLeft = (endtime - Time.time)/time;
        return timeLeft;
    }

    public void WaitPls(){
        backgroundSource.Stop();
        backgroundSource.PlayOneShot(outOfLigthAudio);
        wait = true;
    }
}
