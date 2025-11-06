using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationGuideVisualEventHandler : MonoBehaviour
{
    [SerializeField] private GameObject W;
    [SerializeField] private GameObject A;
    [SerializeField] private GameObject S;
    [SerializeField] private GameObject D;

    private void OnEnable()
    {
        CameraController.OnCameraChange += updateUI;
    }

    private void OnDisable()
    {
        CameraController.OnCameraChange -= updateUI;
    }

    private void Start()
    {
        //W.SetActive(false);
        A.SetActive(false);
        S.SetActive(false);
        D.SetActive(false);
    }

    void updateUI(CameraNeighbours camera)
    {
        W.SetActive(false);
        A.SetActive(false);
        S.SetActive(false);
        D.SetActive(false);

        if(camera.getCamW() != null)
        {
            W.SetActive(true);
        }
        if (camera.getCamA() != null)
        {
            A.SetActive(true);
        }
        if (camera.getCamS() != null)
        {
            S.SetActive(true);
        }
        if (camera.getCamD() != null)
        {
            D.SetActive(true);
        }
    }
}
