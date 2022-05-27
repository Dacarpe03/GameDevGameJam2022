using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRockScript : MonoBehaviour
{
    private bool shake = false;
    private float amount = 1.5f;
    private float nextTime;
    private float time = 0.05f;
    [SerializeField] float aliveTime = 1f;
    private float destroyTime;

    [SerializeField] GameObject fallenRock;
    [SerializeField] float xOffset;
    [SerializeField] float yOffset;
    void Update(){
        if (shake){
            if (Time.time > destroyTime){
                AutoDestroy();
            }
            
            if (Time.time > nextTime){
                amount = -1 * amount;
                gameObject.transform.Rotate(new Vector3(0, 0, 2 * amount));
                nextTime = Time.time + time;
            }
        }
    }

    public void Activate(){
        Debug.Log("Se cae");
        shake = true;
        nextTime = Time.time + time;
        destroyTime = Time.time + aliveTime;
    }

    private void AutoDestroy(){
        Vector3 spawnPosition = this.transform.position;
        Debug.Log(spawnPosition);
        spawnPosition.x += xOffset;
        spawnPosition.y += yOffset;
        Instantiate(fallenRock, spawnPosition, Quaternion.identity);
        Destroy(this.gameObject);
    }

}
