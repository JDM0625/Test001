using UnityEngine;
using UnityEngine.UI;


public class TestIf : MonoBehaviour
{
    public InputField m_InputField = null;
    public Button m_BtnSt = null;
    public Button m_BtnRes = null;
    public Text m_Text = null;

    private void Start()
    {
        m_BtnSt.onClick.AddListener(OnClicked_St);
        m_BtnRes.onClick.AddListener(Onclicked_Res);


    }
    private void Onclicked_Res()
    {
        m_Text.text = "";
        m_InputField.text = "";
    }
    private void OnClicked_St()
    {
        if (m_InputField.text == string.Empty)
            return;

        int number = int.Parse(m_InputField.text);
        if(100 < number || 0 > number)
        {
            return;
        }
        string score = ReturnScore(number);
        m_Text.text = $"{score}";
    }


    string ReturnScore(int num)
    {

        switch (num)
        {
            case >= 90:
                return "A";
                break;
            case >= 80:
                return "B";
                break;
            case >= 70:
                return "C";
                break;
            case >= 60:
                return "D";
                break;
            default:
                {
                    return "F";
                    break;
                }
        }

    }

}
