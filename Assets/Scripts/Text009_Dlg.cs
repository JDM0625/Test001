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
        txt.text = "[기본 체력=5000,Attack = 100]\n";
        hp = 5000;
        dmg = 100;
        txt.text += $"MasterHP = {hp}\n";
        txt.text += "[데미지 50 생김]\n";
        MinusHP(50);
        txt.text += $"MasterHP = {hp}\n";
        txt.text += "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ\n";
        txt.text += "[적 체력=2000,Attack = 200으로 설정]\n";
        Test009Acter mob = new Test009Acter(2000, 200);
        txt.text += $"Enemy Hp = {mob.m_Hp}\n";
        txt.text += "[적이 마스터에게 공격당함]\n";
        mob.MinusHP(dmg);
        txt.text += $"Enemy Hp = {mob.m_Hp}\n";
        txt.text += "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ\n";
        txt.text += "[마스터가 HP 100만큼 회복함]\n";
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
