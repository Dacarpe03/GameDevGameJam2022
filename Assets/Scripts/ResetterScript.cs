using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetterScript : MonoBehaviour
{
    public void Reset(){
        GameObject[] monsters = GameObject.FindGameObjectsWithTag("Monster");
        for (int i=0; i<monsters.Length; i++){
            monsters[i].GetComponent<MonsterScriot>().StopFollowing();
        }
    }
}
