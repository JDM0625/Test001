using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Test001Dlg : MonoBehaviour
{
    public Text m_Result = null;
    public Button m_BtnOk = null;
    public Button m_btnClear = null;
    // Start is called before the first frame update
    void Start()
    {
        m_BtnOk.onClick.AddListener(OnClicked_OK);
        m_btnClear.onClick.AddListener(OnClicked_Clear);

    }

    int Sum(int a, int b)
    {
        return a + b;
    }

    void Swap(ref int a, ref int b)
    {
        int c = a;
        a = b;
        b = c;
    }

    private void OnClicked_Clear()
    {
        m_Result.text = "";
    }

    private void OnClicked_OK()
    {
        m_Result.text = "";
        int a = 30;
        int b = 60;
        int c = Sum(a, b);

        m_Result.text += ($"sum = {c}\n");
        m_Result.text += ("-----------------------------\n\n");
        m_Result.text += ($"a = {a}, b = {b}\n");

        m_Result.text += ($"a = {a}, b = {b}\n");
        Swap(ref a, ref b);
        m_Result.text += ($"a = {a}, b = {b}\n");
        m_Result.text += ("-----------------------------\n\n");
    }
}
