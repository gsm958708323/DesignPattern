using UnityEngine;
/// <summary>
/// 士兵伤害策略
/// 士兵有伤害加成和防御加成，根据等级提升
/// </summary>
public class SoldierStrategy : IAttrStrategy
{
    public int GetCritDmg(int critRate)
    {
        return 0;
    }

    public int GetExtraHPValue(int lv)
    {
        return (lv - 1) * 10;
    }

    public int GetHurtDesc(int lv)
    {
        return (lv - 1) * 5;
    }
}