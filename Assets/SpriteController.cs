using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Sprite[] possibleSprites;
    private bool x_Flipped = false;

    // Update is called once per frame
    void Start(){
        int randomIndex = Random.Range(0, possibleSprites.Length);
        spriteRenderer.sprite = possibleSprites[randomIndex];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && !x_Flipped){
            x_Flipped = true;
            spriteRenderer.flipX = x_Flipped;
        }else if(Input.GetKeyDown(KeyCode.D)){
            x_Flipped = false;
            spriteRenderer.flipX = x_Flipped;
        }
    }
}
