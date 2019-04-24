using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttrStrategy
{
    /// <summary>
    /// 获得攻击加成
    /// </summary>
    int GetExtraHPValue(int lv);
    /// <summary>
    /// 受到的攻击
    /// </summary>
    int GetHurtDesc(int lv);
    /// <summary>
    /// 暴击伤害
    /// </summary>
    /// <param name="critRate"></param>
    int GetCritDmg(int critRate);
}