using UnityEngine;

public class PlayerPeakSpawner : MonoBehaviour
{
    // Update is called once per frame
    [SerializeField] GameObject pickaxe;
    private KeyCode lastPressedKey;
    [SerializeField] float xSpawnOffset = 20f;
    private float xMultiplier = 0f;
    [SerializeField] float ySpawnOffset = 20f;
    private float yMultiplier = 0f;
    
    void Update()
    {
        UpdateSpawningoffsets();
        ProcessPickaxe();
    }

    private void ProcessPickaxe(){
        if (Input.GetKeyDown(KeyCode.J)){
            SpawnPickaxe();
        }
    }

    private void SpawnPickaxe(){
        Vector3 spawnPosition = transform.position + new Vector3(xMultiplier*xSpawnOffset, yMultiplier*ySpawnOffset, 0f);
        float yRotation = 0;
        if (yMultiplier == -1){
            yRotation = 180;
        }else if (yMultiplier == 1){
            yRotation = 0;
        }
        Quaternion spawnRotation = Quaternion.Euler(0, 0, -xMultiplier*90 + yRotation);
        Instantiate(pickaxe, spawnPosition, spawnRotation);
    }

    private void UpdateSpawningoffsets(){
        if (Input.GetKey(KeyCode.A)){
            xMultiplier = -1;
            yMultiplier = 0; 
        }

        if (Input.GetKey(KeyCode.D)){
            xMultiplier = 1;
            yMultiplier = 0; 
        }

        
        if (Input.GetKey(KeyCode.W)){
            xMultiplier = 0;
            yMultiplier = 1; 
        }
        
        if (Input.GetKey(KeyCode.S)){
            xMultiplier = 0;
            yMultiplier = -1; 
        }
    }
}
