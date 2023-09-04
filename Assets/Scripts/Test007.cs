using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test007 : MonoBehaviour
{
    public Button btn_Add = null;
    public Button btn_Start = null;
    public Button btn_Reset = null;

    public InputField inpField = null;

    public Text txt = null;

    List<int> nums = new List<int>();

    private void Start()
    {
        btn_Add.onClick.AddListener(OnClickAdd);
        btn_Start.onClick.AddListener(OnClickStart);
        btn_Reset.onClick.AddListener(OnClickReset);
    }

    private void OnClickReset()
    {
        txt.text = "";
    }

    private void OnClickStart()
    {
        int changeInt = int.Parse(inpField.text);
        txt.text = "";

        nums.Sort();
        for (int i = 0; i < nums.Count; i++)
        {
            txt.text += $"{nums[i]},";
        }
    }

    private void OnClickAdd()
    {
        int changeInt = int.Parse(inpField.text);
        if (changeInt < 0 || changeInt >100)
            return;

        nums.Add(changeInt);

        txt.text = "";


        for (int i = 0; i < nums.Count; i++)
        {
            txt.text += $"{nums[i]},";
        }
    }
}
