using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class DistractionsController : MonoBehaviour
{
    [Header("Point System")]
    [SerializeField] NumberController numberController;

    [Header("Rat Plug")]
    public GameObject[] ratPlug = new GameObject[2];

    [Header("Rat Channel")]
    public GameObject[] ratChannel = new GameObject[2];

    [Header("Antenna Blown")]
    public GameObject[] antennaBlown = new GameObject[2];


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(numberController.score >= 10)
        {

        }
    }
}
