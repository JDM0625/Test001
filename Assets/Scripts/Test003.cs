using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test003 : MonoBehaviour
{
    public InputField inpField_0 = null;
    public InputField inpField_1 = null;
    public InputField inpField_2 = null;
    public Text txt = null;

    public Button btn_Start = null;
    public Button btn_Restat = null;

    int[] int_Score = new int[3];


    // Start is called before the first frame update
    void Start()
    {
        btn_Start.onClick.AddListener(OnClickStart);
        btn_Restat.onClick.AddListener(OnclickRestart);
    }

    private void OnclickRestart()
    {
        txt.text = "";
    }

    private void OnClickStart()
    {
        int num0 = int.Parse(inpField_0.text);
        int num1 = int.Parse(inpField_1.text);
        int num2 = int.Parse(inpField_2.text);

        int_Score[0] = num0;
        int_Score[1] = num1;
        int_Score[2] = num2;

        WhoIsBig();


        txt.text = $"{int_Score[0]} , {int_Score[1]} , {int_Score[2]}";
    }

    void WhoIsBig()
    {

        for (int i = 0; i < int_Score.Length-1; i++)
        {
            for (int j = 1; j < int_Score.Length; j++)
            {
                if(int_Score[i] > int_Score[j])
                {
                    Swap(ref int_Score[i], ref int_Score[j]);
                }
            }
        }

    }

    void Swap(ref int a, ref int b)
    {
        int c = a;
        a = b;
        b = c;
    }
}
