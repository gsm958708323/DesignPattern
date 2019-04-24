using UnityEngine;
using System.Collections;

public class WeaponRifle : IWeapon
{
    protected override void SetEffectDisplayTime()
    {
        DoSetEffectDisplayTime(3);
    }
    protected override void PlayBulletEffect(Vector3 targetPos)
    {
        DoPlayBulletEffect(targetPos, 3);
    }
}
