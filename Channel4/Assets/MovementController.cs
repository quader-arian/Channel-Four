using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public GameObject cameraA;
    public GameObject cameraS;
    public GameObject cameraD;
    public GameObject cameraW;
    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A)){
            TurnOnCamera(cameraA);
        }

        if (Input.GetKey(KeyCode.D)){
            TurnOnCamera(cameraD);
        }

        if (Input.GetKey(KeyCode.W)){
            TurnOnCamera(cameraW);
        }

        if (Input.GetKey(KeyCode.S)){
            TurnOnCamera(cameraS);
        }
    }

    private void TurnOnCamera(GameObject camera)
    {
        cameraA.SetActive(false);
        cameraS.SetActive(false);
        cameraW.SetActive(false);
        cameraD.SetActive(false);
        camera.SetActive(true);
    }
}
