using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    [SerializeField] Image timerSprite;
    PlayerTimerScript playerTimerScript;

    void Awake(){
        playerTimerScript = FindObjectOfType<PlayerTimerScript>();
    }

    void Update(){
        float fillAmount = playerTimerScript.GetTimeLeft();
        if (fillAmount > 0){
            timerSprite.fillAmount = fillAmount;
        }
    }
}
