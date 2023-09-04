using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Test008 : MonoBehaviour
{
    public Button btn_Start = null;
    public Button btn_Reset = null;
    public Text txt = null;

    Dictionary<int, string> dic = new Dictionary<int, string>()
    {
        {1, "������" },{2, "����"}, {3, "���"}
    };

    // Start is called before the first frame update
    void Start()
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

        Print();

        dic[1] = "���ִ� ������";
        dic[2] = "���ִ� ����";

        Print();
        dic.Remove(1);
        Print();
    }

    void Print()
    {

        foreach (KeyValuePair<int, string> a in dic)
        {
            string answer = a.Value;
            int getkey = a.Key;
            txt.text += $"{getkey}:{answer},";
        }
        txt.text += "\n";
        txt.text += "�ѤѤѤѤѤѤѤѤѤѤѤ�";
        txt.text += "\n";
    }
    
}
