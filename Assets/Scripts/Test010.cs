using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal
{
    public string name;
    public int age;
}

public class Test010 : MonoBehaviour
{
    public Animal m_Anim0 = new Animal();
    public Animal m_Anim1 = new Animal();

    public int count = 0;

    public InputField inputF_0 = null;
    public InputField inputF_1 = null;

    public Button btn_Start = null;
    public Button btn_Reset = null;
    public Button btn_Add = null;

    public Text txt = null;

    private void Start()
    {
        btn_Start.onClick.AddListener(OnClickStart);
        btn_Reset.onClick.AddListener(OnClickReset);
        btn_Add.onClick.AddListener(OnClickAdd);
    }

    private void OnClickAdd()
    {
        int changeNum = int.Parse(inputF_1.text);
        if (changeNum > 2000 && changeNum < 0)
        {
            return;
        }

        if (count == 0)
        {
            m_Anim0.name = inputF_0.text;
            m_Anim0.age = changeNum;
            inputF_0.text = "";
            inputF_1.text = "";
        }
        else if(count == 1)
        {
            m_Anim1.name = inputF_0.text;
            m_Anim1.age = changeNum;
            inputF_0.text = "";
            inputF_1.text = "";
        }
        count++;
    }

    private void OnClickReset()
    {
        txt.text = "";
    }

    private void OnClickStart()
    {

        if( count == 1)
        {
            txt.text = $"{m_Anim0.name}의 몸무게는 {m_Anim0.age}입니다";
        }

        if(count == 2)
        {
            int num = AddHeight(m_Anim0.age, m_Anim1.age);

            txt.text = $"{m_Anim0.name}과 {m_Anim0.name}의 몸무게의 합은 {num}입니다";
        }
 
    }

    int AddHeight(int a, int b)
    {
        int num = 0;
        num = a + b;
        return num;
    }
}
