using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemey
{
    public string name;
    public int dmg;

    public void GetDmg(int damage)
    {
        dmg -= damage;
        if(dmg < 0)
        {
            dmg = 0;
        }
    }
}

public class Test011 : MonoBehaviour
{
    public InputField inputF_Name = null;
    public InputField inputF_MobName = null;

    public Button btn_Start = null;
    public Button btn_Reset = null;
    public Button btn_Add = null;

    public Text txt = null;
    public Text txt_List = null;

    List<Enemey> enemyList = new List<Enemey>();

    private void Start()
    {
        btn_Start.onClick.AddListener(OnClickStart);
        btn_Reset.onClick.AddListener(OnClickReset);
        btn_Add.onClick.AddListener(OnClickAdd);
    }

    private void OnClickAdd()
    {
        int num = int.Parse(inputF_MobName.text);
        Enemey e = new Enemey();
        e.name = inputF_Name.text;
        e.dmg = num;
        enemyList.Add(e);
        txt_List.text += $"{e.name}: {e.dmg}  ";
        inputF_Name.text = "";
        inputF_MobName.text = "";
    }

    private void OnClickReset()
    {
        txt.text = "";
        txt_List.text = "";
        inputF_Name.text = "";
        inputF_MobName.text = "";
    }

    private void OnClickStart()
    {
        for (int i = 0; i < enemyList.Count; i++)
        {
            enemyList[i].GetDmg(80);
            txt.text += $"Name = {enemyList[i].name}, HP = {enemyList[i].dmg}\n";
        }
    }
}
