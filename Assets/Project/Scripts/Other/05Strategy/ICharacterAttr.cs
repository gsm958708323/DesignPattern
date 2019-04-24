using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 角色数值类
/// </summary>
public abstract class ICharacterAttr
{
    protected string m_Name;
    protected int m_MaxHP;
    protected float m_MoveSpeed;
    protected int m_CurHP;
    protected string mIconSprite;
    protected int m_Lv;
    protected float m_CritRate;

    private IAttrStrategy m_IAttrStrategy;
}