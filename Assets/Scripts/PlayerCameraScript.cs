using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerCameraScript : MonoBehaviour
{
    
    [SerializeField] CinemachineVirtualCamera playerCamera;
    [SerializeField] float offset = 0.1f;
    [SerializeField] float normalPosition = 0.5f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)){
            playerCamera.GetCinemachineComponent<CinemachineFramingTransposer>().m_ScreenX = normalPosition + offset;
        } else if (Input.GetKey(KeyCode.D)){
            playerCamera.GetCinemachineComponent<CinemachineFramingTransposer>().m_ScreenX = normalPosition - offset;
        } else if (Input.GetKey(KeyCode.W)){
            playerCamera.GetCinemachineComponent<CinemachineFramingTransposer>().m_ScreenY = normalPosition + offset;
        } else if (Input.GetKey(KeyCode.S)){
            playerCamera.GetCinemachineComponent<CinemachineFramingTransposer>().m_ScreenY = normalPosition - offset;
        }
    }
}
