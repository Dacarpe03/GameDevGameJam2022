using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScriot : MonoBehaviour
{
    private Transform playerPosition;
    [SerializeField] float speed = 4f;
    [SerializeField] float activateDistance = 3f;
    [SerializeField] GameObject deadMonster;
    private Vector3 startPosition;
    private bool follow = false;
    private Rigidbody2D rb;
    private bool stopFollowingCalled = false;

    private float nextTime;
    private float wait = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        startPosition = rb.position;
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime){
            
            if (!stopFollowingCalled && Vector2.Distance(transform.position, playerPosition.position) <= activateDistance){
                follow=true;
            }

            if (follow){
                transform.position = Vector2.MoveTowards(rb.position, playerPosition.position, speed*Time.deltaTime);
            }

            stopFollowingCalled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "RollingRock"){
            Instantiate(deadMonster, this.gameObject.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    public void StopFollowing(){
        Debug.Log("matao");
        stopFollowingCalled = true;
        nextTime = Time.time + wait;
        this.follow = false;
        rb.position = startPosition;
        transform.position = startPosition;
    }

}
