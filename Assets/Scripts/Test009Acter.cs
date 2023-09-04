using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test009Acter
{
    public int m_Hp = 0;
    public int m_Attack = 0;

    public Test009Acter(int hp, int attack)
    {
        m_Hp = hp;
        m_Attack = attack;
    }
    public void MinusHP(int dmg)
    {
        m_Hp -= dmg;
    }

    public void PlusHP(int heal)
    {
        m_Hp += heal;
    }
}
