using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_004 : MonoBehaviour
{
    public Button btn_Start = null;
    public Button btn_Restart = null;
    public InputField inpField_text = null;
    public Text txt = null;
    // Start is called before the first frame update
    void Start()
    {
        btn_Start.onClick.AddListener(OnClickStart);
        btn_Restart.onClick.AddListener(OnClickRestart);
    }

    private void OnClickRestart()
    {
        txt.text = "";
    }

    private void OnClickStart()
    {
        int num = int.Parse(inpField_text.text);
        Factorial(num);
    }

    void Factorial(int num)
    {
        int answer = 1;
        for (int i = num; i >= 1; i--)
        {
            answer *= i;
            if(i > 1)
            {
                txt.text += $"{i} x";

            }
            else if(i == 1)
            {   
                txt.text += "1";
            }

        }
        txt.text += $"= {answer}";
    }
}
