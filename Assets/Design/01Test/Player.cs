using System;
using System.Collections.Generic;
/*
 * 角色有国王King，皇后Queen，骑士Knight，妖怪Troll
 * 任何角色可以自由切换武器
 */
namespace Design.Test01
{
    public class Character
    {
        IWeapon m_IWeapon;
        public Character(IWeapon weapon)
        {
            m_IWeapon = weapon ?? new Sword();
        }
        public void SetWeapon(IWeapon weapon)
        {
            m_IWeapon = weapon;
        }
        public virtual void Fight()
        {
            m_IWeapon.UseWeapon();
        }
    }
    public class King : Character
    {
        public King(IWeapon weapon) : base(weapon) { }
        public override void Fight()
        {
            base.Fight();
            Debugger.Log("力量强！");
        }
    }
    public class Queen : Character
    {
        public Queen(IWeapon weapon) : base(weapon) { }
        public override void Fight()
        {
            base.Fight();
            Debugger.Log("力量弱！");
        }
    }

    public interface IWeapon
    {
        void UseWeapon();
    }
    public class Sword : IWeapon
    {
        public void UseWeapon()
        {
            Debugger.Log("使用宝剑");
        }
    }
    public class Knife : IWeapon
    {
        public void UseWeapon()
        {
            Debugger.Log("使用匕首");
        }
    }
}


