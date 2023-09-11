using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score
{
    public string m_name = "";
    public int m_Kor = 0;
    public int m_Eng = 0;
    public int m_Math = 0;

    public int AllAdd()
    {
        int answer = m_Kor + m_Eng + m_Math;
        return answer;
    }

    public float Average()
    {
        float average = (float)AllAdd() / 3;
        return average;
    }

}

public class Test013 : MonoBehaviour
{
    public InputField m_inputName = null;
    public InputField m_inputKor = null;
    public InputField m_inputEng = null;
    public InputField m_inputMath = null;

    public Button m_btnStart = null;
    public Button m_btnReset = null;
    public Button m_btnAdd = null;

    public Text m_txt_Answer = null;
    public Text m_txt_List = null;

    List<Score> m_people = new List<Score>();

    private void Start()
    {
        m_btnStart.onClick.AddListener(OnClickStart);
        m_btnReset.onClick.AddListener(OnClickReset);
        m_btnAdd.onClick.AddListener(OnClickAdd);
    }

    private void OnClickAdd()
    {
        Score add = new Score();
        int changeKor = int.Parse(m_inputKor.text);
        int chagneEng = int.Parse(m_inputEng.text);
        int changeMath = int.Parse(m_inputMath.text);

        add.m_name = m_inputName.text;
        add.m_Kor = changeKor;
        add.m_Eng = chagneEng;
        add.m_Math = changeMath;

        m_people.Add(add);

        m_txt_List.text += $"{add.m_name}: {add.m_Kor}, {add.m_Eng}, {add.m_Math}\n";
        m_inputName.text = string.Empty;
        m_inputKor.text = string.Empty;
        m_inputEng.text = string.Empty;
        m_inputMath.text = string.Empty;
    }

    private void OnClickReset()
    {
        m_people.Clear();
        m_inputName.text = string.Empty;
        m_inputKor.text = string.Empty;
        m_inputEng.text = string.Empty;
        m_inputMath.text = string.Empty;

        m_txt_Answer.text = string.Empty;
        m_txt_List.text = string.Empty;
    }

    private void OnClickStart()
    {
        for (int i = 0; i < m_people.Count; i++)
        {
            Score score = m_people[i];
            m_txt_Answer.text += $"{score.m_name} : {score.m_Kor}, {score.m_Eng}, {score.m_Math}: ÇÕ°è={score.AllAdd()} Æò±Õ={score.Average():0.00}\n";
        }
    }
}
