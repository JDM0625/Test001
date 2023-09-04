using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text009_Dlg : MonoBehaviour
{

    public Button btn_Start = null;
    public Button btn_Reset = null;
    public Text txt = null;

    public int hp = 0;
    public int dmg = 0;


    private void Start()
    {
        btn_Start.onClick.AddListener(onClickStart);
        btn_Reset.onClick.AddListener(OnClockReset);
    }

    private void OnClockReset()
    {
        txt.text = "";
    }

    private void onClickStart()
    {
        Test1();
    }

    void Test1()
    {
        txt.text = "[�⺻ ü��=5000,Attack = 100]\n";
        hp = 5000;
        dmg = 100;
        txt.text += $"MasterHP = {hp}\n";
        txt.text += "[������ 50 ����]\n";
        MinusHP(50);
        txt.text += $"MasterHP = {hp}\n";
        txt.text += "�ѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤ�\n";
        txt.text += "[�� ü��=2000,Attack = 200���� ����]\n";
        Test009Acter mob = new Test009Acter(2000, 200);
        txt.text += $"Enemy Hp = {mob.m_Hp}\n";
        txt.text += "[���� �����Ϳ��� ���ݴ���]\n";
        mob.MinusHP(dmg);
        txt.text += $"Enemy Hp = {mob.m_Hp}\n";
        txt.text += "�ѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤ�\n";
        txt.text += "[�����Ͱ� HP 100��ŭ ȸ����]\n";
        PlusHP(100);
        txt.text += $"MasterHP = {hp}\n";
        mob.PlusHP(200);
        txt.text += $"Enemy Hp = {mob.m_Hp}\n";
    }

    void MinusHP(int dmg)
    {
        hp -= dmg;
    }

    void PlusHP(int heal)
    {
        hp += heal;
    }


}
