using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float boostMultiplier = 1.5f;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Vector3 startPosition;
    [SerializeField] GameObject deadPlayer;

    void Update()
    {
        int xDirection = CheckHztalDirection();
        int yDirection = CheckVtcalDirection();
        MovePlayer();
    }

    private void MovePlayer(){
        float currentMultiplier = CheckBoostPressed();

        int xDirection = CheckHztalDirection();
        float xSpeed = Time.deltaTime * xDirection * speed * currentMultiplier;

        int yDirection = CheckVtcalDirection();
        float ySpeed = Time.deltaTime * yDirection * speed * currentMultiplier;

        Vector3 offset = new Vector3(xSpeed, ySpeed, 0);
        rb.velocity = new Vector2(xSpeed/Time.deltaTime, ySpeed/Time.deltaTime);
        //transform.Translate(offset);
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

    private float CheckBoostPressed(){
        if (Input.GetKey("space")){
            return boostMultiplier;
        }
        return 1f;
    }

     private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "FallingRock"){
            other.gameObject.GetComponent<FallingRockScript>().Activate();
        }else if (other.tag == "FallenRock"){
            Die();
        }else if (other.tag == "Monster"){
            Die();
            other.gameObject.GetComponent<MonsterScriot>().StopFollowing();
        }else if (other.tag == "RollingRock"){
            Die();
        }
    }

    private void Die(){
        Instantiate(deadPlayer, this.transform.position, Quaternion.identity);
        rb.position = startPosition;
    }

}
