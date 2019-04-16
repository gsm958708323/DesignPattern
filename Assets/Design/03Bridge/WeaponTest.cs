using UnityEngine;
using System.Collections;
using System;
using Design.Bridge;

public class WeaponTest : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        Test();
    }

    private void Test()
    {
        Enemy enemy = new Enemy();
        enemy.SetWeapon(new ShotGun());
        enemy.Shoot();

        Gun gun = new Gun();
        gun.SetPower(20, 20);//改装过后的gun
        Soldier soldier = new Soldier();
        soldier.SetWeapon(gun);
        soldier.Shoot();
    }
}
