using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestIf1 : MonoBehaviour
{
    [SerializeField]
    Button btn_Str = null;
    [SerializeField]
    Button btn_Res = null;
    [SerializeField]
    InputField inp_Text = null;
    [SerializeField]
    Text txt = null;

    private void Start()
    {
        btn_Str.onClick.AddListener(OnClicked_Str);
        btn_Res.onClick.AddListener(OnClicked_Res);
    }


    private void OnClicked_Str()
    {
        int changeNum = int.Parse(inp_Text.text);
        string score = YourScore(changeNum);
        if (inp_Text.text == string.Empty)
            return;
        

        if (100 < changeNum || 0 > changeNum)
        {
            return;
        }

        txt.text = $"{score}";

    }
    private void OnClicked_Res()
    {
        inp_Text.text = "";
        txt.text = "";
    }

    string YourScore(int num)
    {
        if(num >= 90)
        {
            return "A";
        }
        else if (num >= 80)
        {
            return "B";
        }
        else if (num >= 70)
        {
            return "C";
        }
        else if (num >= 60)
        {
            return "D";
        }
        else
        {
            return "E";
        }
    }
}
