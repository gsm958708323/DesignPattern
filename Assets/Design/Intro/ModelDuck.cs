using System;
using System.Collections.Generic;

public class ModelDuck : Duck2
{
    public ModelDuck(IFlyBehavior flyBehavior = null, IQuackBehavior quackBehavior = null) : base(flyBehavior, quackBehavior)
    {
    }
    public override void Display()
    {
        UnityEngine.Debug.Log("我是模型鸭");
    }
}
