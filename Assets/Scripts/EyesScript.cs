using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesScript : MonoBehaviour
{
    private Transform playerTransform;
    private float endTime = 3f;
    private float speed = 2f;
    // Start is called before the first frame update
    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Start(){
        endTime = Time.time + 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
       if (Time.time < endTime){
           transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, speed*Time.deltaTime);
       }else{
           Destroy(this.gameObject);
       }
    }
}
