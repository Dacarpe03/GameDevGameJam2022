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
        Instantiate(pickaxe, spawnPosition, Quaternion.identity);
    }

    private void UpdateSpawningoffsets(){
        if (Input.GetKeyDown(KeyCode.A)){
            xMultiplier = 1;
            yMultiplier = 0; 
        }

        if (Input.GetKeyDown(KeyCode.D)){
            xMultiplier = -1;
            yMultiplier = 0; 
        }

        
        if (Input.GetKeyDown(KeyCode.W)){
            xMultiplier = 0;
            yMultiplier = 1; 
        }
        
        if (Input.GetKeyDown(KeyCode.S)){
            xMultiplier = 0;
            yMultiplier = -1; 
        }
    }
}
