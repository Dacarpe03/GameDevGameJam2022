using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingRockScript : MonoBehaviour
{
    private float speed = 7f;
    private Transform playerPosition;
    private bool follow=false;
    private float activateDistance = 4f;
    private Vector3 startPosition;
    private float nextTime = 0f;
    private float wait = 0.5f;
    private bool played = false;
    private float offset = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime){

            if (Vector2.Distance(transform.position, playerPosition.position) <= activateDistance){
                follow=true;
            }
            if (follow){
                offset = offset * -1f;
                this.transform.Translate(new Vector3(offset, speed*Time.deltaTime, 0f));
                StartSound();
            }
        }
        
    }

    public void Reset(){
        nextTime = Time.time + wait;
        follow = false;
        this.transform.position = startPosition;
        StoSound();
    }

    public void StartSound(){
        if (!played){
            GetComponent<AudioSource>().Play();    
        }
        played = true;
    }

    public void StoSound(){
        GetComponent<AudioSource>().Stop(); 
    }
}
