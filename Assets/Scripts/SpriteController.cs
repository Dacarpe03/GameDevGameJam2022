using UnityEngine;

public class SpriteController : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Sprite[] possibleSprites;
    private bool xFlipped = false;

    // Update is called once per frame
    void Start(){
        int randomIndex = Random.Range(0, possibleSprites.Length);
        spriteRenderer.sprite = possibleSprites[randomIndex];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && !xFlipped){
            xFlipped = true;
            spriteRenderer.flipX = xFlipped;
        }else if(Input.GetKeyDown(KeyCode.D)){
            xFlipped = false;
            spriteRenderer.flipX = xFlipped;
        }
    }

    public void ChangeSprite(){
        int randomIndex = Random.Range(0, possibleSprites.Length);
        spriteRenderer.sprite = possibleSprites[randomIndex];
    }
}
