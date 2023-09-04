using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test006 : MonoBehaviour
{
    public Text txt = null;
    public Button btn_Start = null;
    public Button btn_Reset = null;

    List<int> numbers = new List<int>();
    private void Start()
    {
        btn_Start.onClick.AddListener(OnClickStart);
        btn_Reset.onClick.AddListener(OnClickReset);
    }

    private void OnClickReset()
    {
        txt.text = "";
        numbers.Clear();
    }

    private void OnClickStart()
    {
        OnClickReset();
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        TestList(numbers);
        numbers.Add(40);
        numbers.Add(50);
        TestListForeach(numbers);
        numbers.Remove(10);
        numbers.Remove(40);
        TestListForeach(numbers);
    }

    void TestList(List<int> nums)
    {
        txt.text += "[List : for¹®]__________________\n";
        for (int i = 0; i < 3; i++)
        {
            txt.text += $"[{i}]: {nums[i]}";
        }
    }

    void TestListForeach(List<int> nums)
    {
        txt.text += "\n\n[List :foreach ¹®]--------------\n";
        foreach(int i in nums)
        {
            txt.text += $"{i}, ";
        }
    }
}
