using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Noob
{
    public string m_name;
    public int m_Kor;
    public int m_Eng;
    public int m_Math;

    public int TotalSc()
    {
        int totalScore = m_Kor + m_Eng + m_Math;
        return totalScore;
    }

    public float Average()
    {
        float average = (float)TotalSc() / 3;
        return average;
    }
}

public class Test016Dlg : MonoBehaviour
{
    public InputField inputf_Name;
    public InputField inputf_Kor;
    public InputField inputf_Eng;
    public InputField inputf_Math;

    public Button btn_Start;
    public Button btn_Reset;
    public Button btn_Add;
    public Button btn_Save;
    public Button btn_Load;

    public Text txt_Queue = null;
    public Text txt_List = null;

    List<Noob> noobs = new List<Noob>();

    private void Start()
    {
        btn_Start.onClick.AddListener(OnClickStart);
        btn_Reset.onClick.AddListener(OnClickReset);
        btn_Add.onClick.AddListener(OnClickAdd);
        btn_Save.onClick.AddListener(OnClickSave);
        btn_Load.onClick.AddListener(OnClickLoad);
    }


    private void OnClickSave()
    {
        StreamWriter sw = new StreamWriter("Test016.txt");
        sw.WriteLine(noobs.Count);
        for (int i = 0; i < noobs.Count; i++)
        {
            Noob nob = noobs[i];
            sw.WriteLine(nob.m_name);
            sw.WriteLine(nob.m_Kor);
            sw.WriteLine(nob.m_Eng);
            sw.WriteLine(nob.m_Math);
        }
        sw.Close();
    }
    private void OnClickLoad()
    {
        noobs.Clear();
        StreamReader sr = new StreamReader("Test016.txt");
        int count = int.Parse(sr.ReadLine());
        
        for (int i = 0; i < count; i++)
        {
            Noob get = new Noob();
            get.m_name = sr.ReadLine();
            get.m_Kor = int.Parse(sr.ReadLine());
            get.m_Eng = int.Parse(sr.ReadLine());
            get.m_Math = int.Parse(sr.ReadLine());
            noobs.Add(get);
        }
        sr.Close();
        PrintList();
    }

    private void OnClickAdd()
    {
        int changeKor = int.Parse(inputf_Kor.text);
        int changeEng = int.Parse(inputf_Eng.text);
        int changeMath = int.Parse(inputf_Math.text);
        Noob add = new Noob();
        add.m_name = inputf_Name.text;
        add.m_Kor = changeKor;
        add.m_Eng = changeEng;
        add.m_Math = changeMath;


        noobs.Add(add);
        PrintList();
        inputf_Name.text = String.Empty;
        inputf_Kor.text = String.Empty;
        inputf_Eng.text = String.Empty;
        inputf_Math.text = String.Empty;
    }

    void PrintList()
    {
        txt_Queue.text = String.Empty;
        for (int i = 0; i < noobs.Count; i++)
        {
            Noob add = noobs[i];
            txt_Queue.text += $"닉{add.m_name}: {add.m_Kor}, {add.m_Eng}, {add.m_Math}\n";
        }
    }

    private void OnClickReset()
    {
        inputf_Name.text = String.Empty;
        inputf_Kor.text = String.Empty;
        inputf_Eng.text = String.Empty;
        inputf_Math.text = String.Empty;

        txt_Queue.text = String.Empty;
        txt_List.text = String.Empty;

        noobs.Clear();

    }
    private void OnClickStart()
    {
        
        if(noobs.Count == 0)
        {
            txt_List.text = "아무것도 없어요 님";
            return;
        }
        txt_List.text = string.Empty;
        int kor = 0;
        int eng = 0;
        int math = 0;
        int score = 1;
        txt_List.text += "[성적관리]\n";
        txt_List.text += "=============================\n";
        noobs.Sort((a, b) => a.Average() < b.Average() ? 1 : -1);
        for (int i = 0; i < noobs.Count; i++)
        {
            Noob sup = noobs[i];
            kor += sup.m_Kor;
            eng += sup.m_Eng;
            math += sup.m_Math;

            txt_List.text += $"{score}등 : {sup.m_name} {sup.m_Kor}  {sup.m_Eng} {sup.m_Math} :합계={sup.TotalSc()}  평균={sup.Average(): 0.00}\n";
            score++;
        }
        txt_List.text += "============================\n";
        float averKor = (float)kor / 3;
        float averEng = (float)eng / 3;
        float averMath = (float)math / 3;
        txt_List.text += $"과목별 합계-- 국어:({kor},{averKor : 0.00}), 영어:({eng},{averEng: 0.00}), 수학({math},{averMath : 0.00})";
    }
}
