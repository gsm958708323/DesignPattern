using UnityEngine;
using System.Collections;

public class WeaponRocket : IWeapon
{
    protected override void SetEffectDisplayTime()
    {
        DoSetEffectDisplayTime(10);
    }
    protected override void PlayBulletEffect(Vector3 targetPos)
    {
        DoPlayBulletEffect(targetPos, 10);
    }
}
