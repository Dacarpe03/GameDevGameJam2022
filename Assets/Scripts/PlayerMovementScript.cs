using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    void Update()
    {
        int xDirection = CheckHztalDirection();
        int yDirection = CheckVtcalDirection();
        MovePlayer();
        transform.position += new Vector3(0.0001f * xDirection, 0f, 0f);
    }

    private void MovePlayer(){
        int xDirection = CheckHztalDirection();
        float xSpeed = Time.deltaTime * xDirection * speed;

        int yDirection = CheckVtcalDirection();
        float ySpeed = Time.deltaTime * yDirection * speed;

        Vector3 offset = new Vector3(xSpeed, ySpeed, 0);
        transform.Translate(offset);
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
