using UnityEngine;

public class PlayerPeakSpawner : MonoBehaviour
{
    // Update is called once per frame
    [SerializeField] GameObject pickaxe;
    private KeyCode lastPressedKey;
    private float xSpawnOffset = 0;
    private float ySpawnOffset = 0;
    
    void Update()
    {
        ProcessPickaxe();
    }

    private void ProcessPickaxe(){
        if (Input.GetKeyDown(KeyCode.J)){
            SpawnPickaxe();
        }
    }

    private void SpawnPickaxe(){
        Instantiate(pickaxe, transform.position, Quaternion.identity);
    }

    private void UpdateLastDirection(){

    }
}
