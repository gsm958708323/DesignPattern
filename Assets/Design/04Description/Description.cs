using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Design.Description
{
    /*
 * 设计咖啡的订单系统
 */
    public abstract class Coffer
    {
        public string description = "no coffer";
        public string GetDescription()
        {
            return description;
        }
        public abstract int Cost();
    }
    /// <summary>
    /// 咖啡实体类
    /// </summary>
    public class HouseBlend : Coffer
    {
        public HouseBlend()
        {
            description = "House Blend Coffer";
        }
        public override int Cost()
        {
            return 10;
        }
    }
    public class DarkRoast : Coffer
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffer";
        }
        public override int Cost()
        {
            return 20;
        }
    }
    //-----------------------------装饰者
    public abstract class CondimentDecorator : Coffer
    {
        public abstract string GetDescription();
    }
    public class Mocha : CondimentDecorator
    {
        Coffer coffer;//没有加装饰的咖啡
        public Mocha(Coffer coffer)
        {
            this.coffer = coffer;
        }
        public override int Cost()
        {
            return coffer.Cost() + 1;
        }

        public override string GetDescription()
        {
            return coffer.GetDescription() + ",Mocha";
        }
    }
    public class Whip : CondimentDecorator
    {
        Coffer coffer;
        public Whip(Coffer coffer)
        {
            this.coffer = coffer;
        }
        public override int Cost()
        {
            //原始咖啡加了调料，多花了2元
            return coffer.Cost() + 2;
        }

        public override string GetDescription()
        {
            return coffer.GetDescription() + ",Whip";
        }
    }
}
