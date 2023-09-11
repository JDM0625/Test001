using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score1
{
    public string m_name = string.Empty;
    public int m_kor = 0;
    public int m_eng = 0;
    public int m_math = 0;

    public int AllAdd()
    {
        int answer = m_kor + m_eng + m_math;
        return answer;
    }

    public float Average()
    {
        float average = (float)AllAdd() / 3;
        return average;
    }
}

public class Test014 : MonoBehaviour
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

    List<Score1> m_people = new List<Score1>();

    private void Start()
    {
        m_btnStart.onClick.AddListener(OnClickStart);
        m_btnReset.onClick.AddListener(OnClickReset);
        m_btnAdd.onClick.AddListener(OnClickAdd);
    }

    private void OnClickAdd()
    {
        int changeKor = int.Parse(m_inputKor.text);
        int changeEng = int.Parse(m_inputEng.text);
        int changeMath = int.Parse(m_inputMath.text);

        Score1 add = new Score1();
        add.m_name = m_inputName.text;
        add.m_kor = changeKor;
        add.m_eng = changeEng;
        add.m_math = changeMath;

        m_people.Add(add);

        m_txt_List.text += $"{add.m_name}: {add.m_kor}, {add.m_eng},{add.m_math}\n";

        m_inputName.text = string.Empty;
        m_inputKor.text = string.Empty;
        m_inputEng.text = string.Empty;
        m_inputMath.text = string.Empty;

    }

    private void OnClickReset()
    {
        m_txt_Answer.text = string.Empty;
        m_txt_List.text = string.Empty;

        m_inputName.text = string.Empty;
        m_inputKor.text = string.Empty;
        m_inputEng.text = string.Empty;
        m_inputMath.text = string.Empty;
        m_people.Clear();
    }

    private void OnClickStart()
    {
        m_txt_Answer.text = "[성적관리]\n";
        m_txt_Answer.text += "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ\n";
        float korSum = 0;
        float engSum = 0;
        float mathSum = 0;
        m_people.Sort((a, b) => a.Average() < b.Average() ? 1:-1);
        for (int i = 0; i < m_people.Count; i++)
        {
            Score1 score = m_people[i];
            m_txt_Answer.text += $"{i+1}. {score.m_name} : {score.m_kor}, {score.m_eng}, {score.m_math} : 합계={score.AllAdd()} 평균={score.Average():0.00}\n";
            korSum += score.m_kor;
            engSum += score.m_eng;
            mathSum += score.m_math;
        }
        float korAver = (float)korSum / 3;
        float engAver = (float)engSum / 3;
        float mathAver = (float)mathSum / 3;
        m_txt_Answer.text += "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ\n";
        m_txt_Answer.text += $"국어합계{korSum}, 영어합계{engSum}, 수학합계{mathSum}\n";
        m_txt_Answer.text += $"국어평균{korAver}, 영어평균{engAver}, 수학평균{mathAver}";
    }
}
