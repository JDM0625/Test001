using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Student
{
    public string m_name;
    public int m_kor;
    public int m_eng;
    public int m_math;

    public int TotalS()
    {
        int totalScore = m_kor + m_eng + m_math;
        return totalScore;
    }

    public float Average()
    {
        float average = (float)TotalS() / 3;
        return average;
    }
    
}

public class Test015Dlg : MonoBehaviour
{
    public Button m_btnStart;
    public Button m_btnReset;
    public Button m_btnAdd;

    public InputField m_InputName;
    public InputField m_InputKor;
    public InputField m_InputEng;
    public InputField m_InputMath;

    public Text m_txtRecord = null;
    public Text m_txtList = null;

    List<Student> addStd = new List<Student>();

    private void Start()
    {
        m_btnStart.onClick.AddListener(OnClickStart);
        m_btnReset.onClick.AddListener(OnClickReset);
        m_btnAdd.onClick.AddListener(OnClickAdd);
    }

    private void OnClickAdd()
    {
        int changeKor = int.Parse(m_InputKor.text);
        int changeEng = int.Parse(m_InputEng.text);
        int changeMath = int.Parse(m_InputMath.text);

        Student std = new Student();

        std.m_name = m_InputName.text;
        std.m_kor = changeKor;
        std.m_eng = changeEng;
        std.m_math = changeMath;
        addStd.Add(std);

        m_txtRecord.text += $"{std.m_name}: ����_{std.m_kor} ����_{std.m_eng} ����_{std.m_math} �հ�{std.TotalS()} ���{std.Average() : 0.00}\n";

        m_InputName.text = string.Empty;
        m_InputKor.text = string.Empty;
        m_InputEng.text = string.Empty;
        m_InputMath.text = string.Empty;
    }

    private void OnClickReset()
    {
        m_InputName.text = string.Empty;
        m_InputKor.text = string.Empty;
        m_InputEng.text = string.Empty;
        m_InputMath.text = string.Empty;
    }

    private void OnClickStart()
    {
        int ranking = 1;
        float korSum = 0;
        float engSum = 0;
        float mathSum = 0;
        // �Ʒ��� �����̴�
        addStd.Sort((a, b) => a.Average() < b.Average() ? 1 : -1);
        for (int i = 0; i < addStd.Count; i++)
        {
            Student std = addStd[i];
            m_txtList.text += $"{ranking}{std.m_name}: ����_{std.m_kor} ����_{std.m_eng} ����_{std.m_math} �հ�{std.TotalS()} ���{std.Average() :0.00}\n";
            korSum += std.m_kor;
            engSum += std.m_eng;
            mathSum += std.m_math;
            ranking++;
        }
        float averKor = (float)korSum / addStd.Count;
        float averEng = (float)engSum / addStd.Count;
        float averMath = (float)mathSum / addStd.Count;
        m_txtList.text += $"���� �հ�{korSum} ���� �հ�{engSum} ���� �հ�{mathSum}\n";
        m_txtList.text += $"���� ���{averKor:0.00} ���� ���{averEng:0.00} ���� ���{averMath:0.00}";
    }
}
