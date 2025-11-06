using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberMovementController : MonoBehaviour
{
    [Header("Difficulty Speeds")]
    public float speedX = 0.001f;
    public float speedY = 0.001f;
    public float speedR = 3.0f;
    Quaternion target;

    [Header("Difficulty Starts")]
    public int verticalMovmentStart = 3;
    public int horizontalMovmentStart = 6;
    public int rotationMovmentStart = 9;

    [Header("Changed Objects")]
    [SerializeField] NumberController numberController;
    public GameObject text;
    private Vector3 transformOG;
    public GameObject boundUL;
    private Transform transformUL;
    public GameObject boundLR;
    private Transform transformLR;
    private Vector3 current;

    // Start is called before the first frame update
    void Start()
    {
        current = text.transform.position;
        transformOG = text.transform.position;
        transformUL = boundUL.transform;
        transformLR = boundLR.transform;
        boundLR.SetActive(false);
        boundUL.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(numberController.score >= verticalMovmentStart)
        {
            current.x += speedX;
            if(current.x >= transformLR.position.x)
            {
                speedX = -speedX;
            }
            if (current.x <= transformUL.position.x)
            {
                speedX = -speedX;
            }
        }

        if (numberController.score >= horizontalMovmentStart)
        {
            current.y += speedY;
            if (current.y >= transformUL.position.y)
            {
                speedY = -speedY;
            }
            if (current.y <= transformLR.position.y)
            {
                speedY = -speedY;
            }
        }

        if (numberController.score >= rotationMovmentStart)
        {
            //verticalMovmentStart = 1000;
            //current.y = transform.position.y;

            float startRotation = text.transform.eulerAngles.z;
            float endRotation = startRotation + 360.0f;
            float t = 0.0f;

            t += Time.deltaTime;
            float zRotation = Mathf.Lerp(startRotation, endRotation, t / speedR) % 360.0f;
            text.transform.eulerAngles = new Vector3(text.transform.eulerAngles.x, text.transform.eulerAngles.y, zRotation);
        }

        text.transform.position = current;

        if (numberController.hp <= 0)
        {
            text.transform.position = transformOG;
        }
    }
}
