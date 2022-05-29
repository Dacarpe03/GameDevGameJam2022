using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    [SerializeField] GameObject brokenGate;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "RollingRock"){
            Instantiate(brokenGate, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
