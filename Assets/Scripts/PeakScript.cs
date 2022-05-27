using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeakScript : MonoBehaviour
{
    private float aliveTime = 0.5f;
    private float endTime;

    void Start() {
        endTime = Time.time + aliveTime;
    }

    void Update(){
        if (Time.time > endTime){
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "FallenRock"){
            Destroy(other.gameObject);
        }
    }
}
