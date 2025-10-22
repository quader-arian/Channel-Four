using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class NumberMovementController : MonoBehaviour
{
    [SerializeField] NumberController numberController;
    public GameObject text;
    public GameObject boundUL;
    public GameObject boundLR;
    private Vector3 current;
    public float speedX = 0.001f;
    public float speedY = 0.001f;
    public float speedR = 3.0f;
    Quaternion target;
    public int verticalMovmentStart = 3;
    public int horizontalMovmentStart = 6;
    public int rotationMovmentStart = 9;

    // Start is called before the first frame update
    void Start()
    {
        current = text.transform.position;
        boundLR.SetActive(false);
        boundUL.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(numberController.score >= verticalMovmentStart)
        {
            current.x += speedX;
            if(current.x >= boundLR.transform.position.x)
            {
                speedX = -speedX;
            }
            if (current.x <= boundUL.transform.position.x)
            {
                speedX = -speedX;
            }
        }

        if (numberController.score >= horizontalMovmentStart)
        {
            current.y += speedY;
            if (current.y >= boundUL.transform.position.y)
            {
                speedY = -speedY;
            }
            if (current.y <= boundLR.transform.position.y)
            {
                speedY = -speedY;
            }
        }

        if (numberController.score >= rotationMovmentStart)
        {
            if (text.transform.rotation.z < -180f)
            {
                text.transform.rotation = Quaternion.Slerp(text.transform.rotation, Quaternion.Euler(0, 0, -180.0f), Time.deltaTime * speedR);
            }
            else
            {
                text.transform.rotation = Quaternion.Slerp(text.transform.rotation, Quaternion.Euler(0, 0, -360f), Time.deltaTime * speedR);
            }
                
        }

        text.transform.position = current;
    }
}
