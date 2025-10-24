using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberController : MonoBehaviour
{
    [Header("Game Settings")]
    public int score;
    public int hp = 3;
    public float timeLimit = 5f;
    private float currentTime;
    [Header("Game Visibility")]
    public TMP_Text phoneTMP;
    public TMP_Text answerTMP;
    public TMP_Text scoreTMP;
    string[] answer = new string[2];
    string input;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        currentTime = 1000;
        answer[0] = "111";
        answer[1] = "3333";
        answerTMP.text = answer[0] + "-" + answer[1];
    }

    // Update is called once per frame
    void Update()
    {
        string keysPressed = Input.inputString;
        currentTime -= Time.deltaTime;
        answerTMP.alpha = currentTime / timeLimit;


        if(currentTime <= 0)
        {
            Debug.Log("MISSED");
            currentTime = timeLimit;
            hp--;
        }

        foreach (char c in keysPressed)
        {
            if (c >= '0' && c <= '9')
            {
                input += c;
                //source.PlayOneShot(type);
                //StartCoroutine(sh.Shake(.05f, .05f));
                //Instantiate(effect, transform.position, Quaternion.identity);
            }else if (c == '\b')
            {
                Debug.Log("RESET");
                input = "";
            }
            else if ((c == '\n') || (c == ' ') || (c == '\r'))
            {
                if (answer[0] + answer[1] == input)
                {
                    Debug.Log("CORRECT");
                    score++;
                    randomizeNumber();
                    currentTime = timeLimit;
                    answerTMP.text = answer[0] + "-" + answer[1];
                }
                else
                {
                    Debug.Log("INCORRECT");
                    hp--;
                }
                input = "";

            }
        }
        

        if(hp <= 0)
        {
            hp = 3;
            score = 0;
            currentTime = 1000f;
            answer[0] = "111";
            answer[1] = "3333";
            answerTMP.text = "CALL\n" + answer[0] + "-" + answer[1] + "\nTO TRY AGAIN";

        }
        phoneTMP.text = input;
    }

    void randomizeNumber()
    {
        for (int i = 0; i < 2; i++)
        {
            answer[i] = "";
            
            int max = 3;
            if(i>= 1)
            {
                max = 4;
            }

            for (int j = 0; j < max; j++)
            {
                answer[i] += Random.Range(0, 10);
            }
        }
    }
}
