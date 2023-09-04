using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Test005 : MonoBehaviour
{
    public Text text = null;

    public Button btn_Start = null;
    public Button btn_Reset = null;

    int[] number = new int[3] {100, 200, 300};

    private void Start()
    {
        btn_Start.onClick.AddListener(OnClickStart);
        btn_Reset.onClick.AddListener(OnClickReset);
    }

    private void OnClickReset()
    {
        text.text = "";
    }

    private void OnClickStart()
    {
        TestFor();
    }

    void TestFor()
    {
        for (int i = 0; i < number.Length; i++)
        {
            text.text += $"Temp{i} = {number[i]}\n";
        }
    }
}
