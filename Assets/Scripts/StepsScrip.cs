using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepsScrip : MonoBehaviour
{
    private bool active = false;
    // Update is called once per frame
    void Update()
    {
        if (CheckHztalDirection() == 0 && CheckVtcalDirection() == 0){
            GetComponent<AudioSource>().Stop();
            active = false;
        }else{
            if (!active){
                GetComponent<AudioSource>().Play();
            }
            active = true;
        }
    }

    private int CheckHztalDirection(){
        if (Input.GetKey(KeyCode.A)){
            return -1;
        } else if (Input.GetKey(KeyCode.D)){
            return 1;
        }
        return 0;
    }

    private int CheckVtcalDirection(){
        if (Input.GetKey(KeyCode.S)){
            return -1;
        } else if (Input.GetKey(KeyCode.W)){
            return 1;
        }
        return 0;
    }
}
