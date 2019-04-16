using System;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 唐老鸭
/// </summary>
public class MallardDuck : Duck
{
    public MallardDuck(IFlyBehavior flyBehavior = null, IQuackBehavior quackBehavior = null) : base(flyBehavior, quackBehavior)
    {
    }

    public override void Display()
    {
        Debug.Log("我是唐老鸭！");
    }
}

