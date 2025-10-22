using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberController : MonoBehaviour
{
    public TMP_Text phoneTMP;
    public TMP_Text answerTMP;
    string[] answer = new string [3];
    string input;
    public int score;
    public int hp = 3;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        answer[0] = "222";
        answer[1] = "111";
        answer[2] = "3333";
    }

    // Update is called once per frame
    void Update()
    {
        string keysPressed = Input.inputString;
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
                if (answer[0] + answer[1] + answer[2] == input)
                {
                    Debug.Log("CORRECT");
                    score++;
                    randomizeNumber();
                }
                else
                {

                }
                input = "";

            }
        }
        phoneTMP.text = input;
        answerTMP.text = "(" + answer[0] + ") " + answer[1] + "-" + answer[2];
    }

    void randomizeNumber()
    {
        for (int i = 0; i < 3; i++)
        {
            answer[i] = "";
            
            int max = 3;
            if(i>= 2)
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
