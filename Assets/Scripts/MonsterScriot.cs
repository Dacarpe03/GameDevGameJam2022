using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScriot : MonoBehaviour
{
    private Transform playerPosition;
    [SerializeField] float speed;
    private bool follow = true;
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (follow){
            transform.position = Vector2.MoveTowards(transform.position, playerPosition.position, speed*Time.deltaTime);
        }
    }
}
