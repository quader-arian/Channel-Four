using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public GameObject cameraMain;
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
            cameraMain.transform.position = cameraA.transform.position;
            cameraMain.transform.rotation = cameraA.transform.rotation;
        }

        if (Input.GetKeyDown(KeyCode.D)){
            cameraMain.transform.position = cameraS.transform.position;
            cameraMain.transform.rotation = cameraS.transform.rotation;
            if (phone.transform.position == phoneEngaged)
            {
                phone.transform.position = phoneDisengaged;
            }
            else
            {
                phone.transform.position = phoneEngaged;
            }
        }

        if (Input.GetKey(KeyCode.W)){
            cameraMain.transform.position = cameraW.transform.position;
            cameraMain.transform.rotation = cameraW.transform.rotation;
        }

        if (Input.GetKey(KeyCode.S)){
            cameraMain.transform.position = cameraS.transform.position;
            cameraMain.transform.rotation = cameraS.transform.rotation;
        }
    }
}
