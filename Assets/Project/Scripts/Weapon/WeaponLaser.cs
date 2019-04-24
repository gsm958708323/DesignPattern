using UnityEngine;
using System.Collections;

public class WeaponLaser : IWeapon
{
    protected override void SetEffectDisplayTime()
    {
        DoSetEffectDisplayTime(2);
    }
    protected override void PlayBulletEffect(Vector3 targetPos)
    {
        DoPlayBulletEffect(targetPos, 2);
    }
}
