using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PhoneAnimator : MonoBehaviour
{
    public GameObject Phone;
    private void OnEnable()
    {
        NumberController.OnNumberPressed += ShowPhone;
        CameraController.OnMoveButtonPressed += HidePhone;
    }

    private void OnDisable()
    {
        NumberController.OnNumberPressed -= ShowPhone;
        CameraController.OnMoveButtonPressed -= HidePhone;
    }

    private void ShowPhone(char number)
    {
        Debug.Log("SHOWING PHONE");
        Phone.transform.DOLocalMoveY(0f,.2f);
    }

    private void HidePhone() 
    {
        Debug.Log("HIDING PHONE");
        Phone.transform.DOLocalMoveY(-1f, .2f);
    }
}
