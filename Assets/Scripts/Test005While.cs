using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test005While : MonoBehaviour
{
    public Text txt = null;

    public Button btn_Start = null;
    public Button btn_Reset = null;

    private void Start()
    {
        btn_Start.onClick.AddListener(OnClickStart);
        btn_Reset.onClick.AddListener(OnClickReset);
    }

    private void OnClickReset()
    {
        txt.text = "";
    }

    private void OnClickStart()
    {
        int[,] num = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        num[0, 0] = 1;
        num[0, 1] = 2;
        num[1, 0] = 3;
        num[1, 1] = 4;
        num[2, 0] = 5;
        num[2, 1] = 6;
        TestArray(num);
    }

    void TestWhile()
    {
        int howMuch = 0;
        int[] nums = new int[3] {100, 200, 300};
        while(howMuch < nums.Length)
        {
            txt.text += $"Temp{howMuch} = {nums[howMuch]}\n";
            howMuch++;
        }
    }

    void TestDoWhile()
    {
        int howMuch = 0;
        int[] nums = new int[3] { 100, 200, 300 };
        do
        {
            txt.text += $"Temp{howMuch} = {nums[howMuch]}\n";
            howMuch++;
        }
        while (howMuch < nums.Length);
    }

    void TestArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                txt.text += $"array{i},{j} = {arr[i, j]}\n";
            }
        }

    }
}
