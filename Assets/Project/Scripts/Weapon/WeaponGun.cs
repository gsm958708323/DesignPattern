using UnityEngine;
using System.Collections;

public class WeaponGun : IWeapon
{
    protected override void SetEffectDisplayTime()
    {
        DoSetEffectDisplayTime(1);
    }
    protected override void PlayBulletEffect(Vector3 targetPos)
    {
        DoPlayBulletEffect(targetPos, 1);
    }
}
