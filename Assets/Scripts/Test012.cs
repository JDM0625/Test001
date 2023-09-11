using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScore
{
    public string m_name = "";
    public int m_Kor = 0;
    public int m_Eng = 0;
    public int m_Math = 0;

    public int AllPlus()
    {
        return( m_Kor + m_Eng + m_Math);
 
    }

    public float Average()
    {
        float answer = (float)AllPlus() / 3;
        return answer;
    }
}

public class Test012 : MonoBehaviour
{
    public InputField m_inputName = null;
    public InputField m_inputKor = null;
    public InputField m_inputEng = null;
    public InputField m_inputMath = null;

    public Button m_btnStart = null;
    public Button m_btnReset = null;

    public Text m_txtResult = null;

    int Score = 0;

    private void Start()
    {
        m_btnStart.onClick.AddListener(OnClickStart);
        m_btnReset.onClick.AddListener(OnClickReset);
    }

    private void OnClickReset()
    {
        m_inputName.text = "";
        m_inputKor.text = "";
        m_inputEng.text = "";
        m_inputMath.text = "";
        m_txtResult.text = "";
    }

    private void OnClickStart()
    {
        int changeNumKor = int.Parse(m_inputKor.text);
        int changeNumEng = int.Parse(m_inputEng.text);
        int changeNumMath = int.Parse(m_inputMath.text);
        TestScore testSco = new TestScore();
        testSco.m_name = m_inputName.text;
        testSco.m_Kor = changeNumKor;
        testSco.m_Eng = changeNumEng;
        testSco.m_Math = changeNumMath;

        testSco.AllPlus();

        testSco.Average();

        m_txtResult.text = $"시험본사람 이름 :{testSco.m_name}\n";
        m_txtResult.text += $"국어 :{testSco.m_Kor}\n";
        m_txtResult.text += $"영어 :{testSco.m_Eng}\n";
        m_txtResult.text += $"수학 :{testSco.m_Math}\n";
        m_txtResult.text += $"합계 :{testSco.AllPlus()}\n";
        m_txtResult.text += $"평균 : {string.Format("{0:0.00}", testSco.Average())}";
    }
}
