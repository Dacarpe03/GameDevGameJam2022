using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScriot : MonoBehaviour
{
    private Transform playerPosition;
    [SerializeField] float speed = 4f;
    [SerializeField] float activateDistance = 3f;
    [SerializeField] Vector3 startPosition;
    private bool follow = false;
    private bool stopFollowingCalled = false;
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!stopFollowingCalled && Vector2.Distance(transform.position, playerPosition.position) <= activateDistance){
            follow=true;
        }

        if (follow){
            transform.position = Vector2.MoveTowards(transform.position, playerPosition.position, speed*Time.deltaTime);
        }

        stopFollowingCalled = false;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "FallenRock"){
            Destroy(this.gameObject);
        }
    }

    public void StopFollowing(){
        stopFollowingCalled = true;
        this.follow = false;
        this.transform.position = startPosition;
    }

}
