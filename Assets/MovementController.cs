using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public GameObject cameraA;
    public GameObject cameraS;
    public GameObject cameraW;
    public GameObject phone;
    public Vector3 phoneEngaged;
    public Vector3 phoneDisengaged;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A)){
            TurnOnCamera(cameraA);
        }

        if (Input.GetKeyDown(KeyCode.D)){
            if(phone.transform.position == phoneEngaged)
            {
                phone.transform.position = phoneDisengaged;
            }
            else
            {
                phone.transform.position = phoneEngaged;
            }
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
        camera.SetActive(true);
    }
}
