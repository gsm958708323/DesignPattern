using UnityEngine;
/// <summary>
/// 怪物的伤害策略
/// 怪物只有暴击加成
/// </summary>
public class EnemyStrtegy : IAttrStrategy
{
    public int GetCritDmg(int critRate)
    {
        int rand = Random.Range(0, 1);
        if (rand < critRate)
            return 0;
        else
            return rand * 10;
    }

    public int GetExtraHPValue(int lv)
    {
        return 0;
    }

    public int GetHurtDesc(int lv)
    {
        return 0;
    }
}