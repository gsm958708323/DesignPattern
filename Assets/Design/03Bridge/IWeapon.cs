using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Design.Bridge
{
    public interface IWeapon
    {
        void Fire();
    }
    public class Gun : IWeapon
    {
        private int m_Power;
        private int m_Distance;

        public Gun()
        {
            m_Power = 10;
            m_Distance = 10;
        }
        public void Fire()
        {
            FireSound();
            HitTarget();
            Display();
        }
        /// <summary>
        /// 武器发射的声音
        /// </summary>
        private void FireSound()
        {
            Debugger.Log("<color=yellow>手枪声！</color>");
        }
        /// <summary>
        /// 击中目标
        /// </summary>
        private void HitTarget()
        {
            Debugger.Log("<color=purple>手枪击中特效！</color>");
        }
        private void Display()
        {
            Debugger.LogFormat("当前威力：{0}  ，攻击范围：{1}", m_Power, m_Distance);
        }
        public void SetPower(int power, int distance)
        {
            m_Power = power;
            m_Distance = distance;
        }
    }
    /// <summary>
    /// 散弹枪
    /// </summary>
    public class ShotGun : IWeapon
    {
        private int m_Power;
        private int m_Distance;

        public ShotGun()
        {
            m_Power = 50;
            m_Distance = 50;
        }
        public void Fire()
        {
            FireSound();
            HitTarget();
            Display();
        }
        /// <summary>
        /// 武器发射的声音
        /// </summary>
        private void FireSound()
        {
            Debugger.Log("<color=yellow>散弹枪声！</color>");
        }
        /// <summary>
        /// 击中目标
        /// </summary>
        private void HitTarget()
        {
            Debugger.Log("<color=purple>散弹枪击中特效！</color>");
        }
        private void Display()
        {
            Debugger.LogFormat("当前威力：{0}  ，攻击范围：{1}", m_Power, m_Distance);
        }
        public void SetPower(int power, int distance)
        {
            m_Power = power;
            m_Distance = distance;
        }
    }

    public abstract class ICharacter
    {
        protected IWeapon m_Weapon;
        public abstract void Shoot();
        public abstract void SetWeapon(IWeapon weapon);
    }
    public class Enemy : ICharacter
    {
        public override void SetWeapon(IWeapon weapon)
        {
            m_Weapon = weapon;
        }

        public override void Shoot()
        {
            if (m_Weapon == null)
                m_Weapon = new Gun();
            m_Weapon.Fire();
        }
    }
    public class Soldier : ICharacter
    {
        public override void SetWeapon(IWeapon weapon)
        {
            m_Weapon = weapon;
        }

        public override void Shoot()
        {
            if (m_Weapon == null)
                m_Weapon = new Gun();
            m_Weapon.Fire();
        }
    }
}
