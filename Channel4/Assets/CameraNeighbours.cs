using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraNeighbours : MonoBehaviour 
{
    [SerializeField] private Camera CamNeighbourW;
    [SerializeField] private Camera CamNeighbourA;
    [SerializeField] private Camera CamNeighbourS;
    [SerializeField] private Camera CamNeighbourD;

    public Camera getCamW()
    {
        return CamNeighbourW;
    }
    public Camera getCamA()
    {
        return CamNeighbourA;
    }
    public Camera getCamS()
    {
        return CamNeighbourS;
    }
    public Camera getCamD()
    {
        return CamNeighbourD;
    }
}
