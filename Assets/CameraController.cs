using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class CameraController : MonoBehaviour
{
    public Camera CurrCam;
    public CameraNeighbours neighbours;

    bool IsMoving = false;
    [SerializeField] private float timeToTransition = 0.3f;

    public static event Action OnMoveButtonPressed;
    public static event Action<CameraNeighbours> OnCameraChange;
    // Update is called once per frame
    void Update()
    {
        if(IsMoving)
        {
            return;
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.Space))
        {
            OnMoveButtonPressed?.Invoke();
            if(neighbours.getCamW() != null)
                MoveToCamW();
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.Space))
        {
            OnMoveButtonPressed?.Invoke();
            if (neighbours.getCamA() != null)
                MoveToCamA();
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKeyDown(KeyCode.Space))
        {
            OnMoveButtonPressed?.Invoke();
            if (neighbours.getCamS() != null)
                MoveToCamS();
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKeyDown(KeyCode.Space))
        {
            OnMoveButtonPressed?.Invoke();
            if (neighbours.getCamD() != null)
                MoveToCamD();
        }
    }

    //Get neighbouring cameras from new camera
    void setNeighbours(Camera newCam)
    {
        this.neighbours = newCam.GetComponent<CameraNeighbours>();
    }
    //Callback to when movement is completed
    void OnMoveFinish(Camera newCam)
    {
        setNeighbours(newCam);
        IsMoving = false;
        OnCameraChange?.Invoke(this.neighbours);
    }

    void MoveToCamW()
    {
        IsMoving = true;
        Camera camW = neighbours.getCamW();
        CurrCam.transform.DOMove(camW.transform.position, timeToTransition)
            .OnComplete(()=>OnMoveFinish(camW));
    }

    void MoveToCamA()
    {
        IsMoving = true;
        Camera camA = neighbours.getCamA();
        CurrCam.transform.DOMove(camA.transform.position, timeToTransition)
            .OnComplete(() => OnMoveFinish(camA));
    }

    void MoveToCamS()
    {
        IsMoving = true;
        Camera camS = neighbours.getCamS();
        CurrCam.transform.DOMove(camS.transform.position, timeToTransition)
            .OnComplete(() => OnMoveFinish(camS));
    }

    void MoveToCamD()
    {
        IsMoving = true;
        Camera camD = neighbours.getCamD();
        CurrCam.transform.DOMove(camD.transform.position, timeToTransition)
            .OnComplete(() => OnMoveFinish(camD));
    }
}
