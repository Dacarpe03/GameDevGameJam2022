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
                this.transform.Translate(new Vector3(0f, speed*Time.deltaTime, 0f));
            }
        }
        
    }

    public void Reset(){
        nextTime = Time.time + wait;
        follow = false;
        this.transform.position = startPosition;
    }
}
