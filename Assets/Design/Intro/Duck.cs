using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 鸭子基类
/// </summary>
public abstract class Duck
{
    //我想要的能力
    private readonly IFlyBehavior _flyBehavior;
    private readonly IQuackBehavior _quackBehavior;

    protected Duck(IFlyBehavior flyBehavior = null, IQuackBehavior quackBehavior = null)
    {
        _flyBehavior = flyBehavior ?? new FlyNoWay();
        _quackBehavior = quackBehavior ?? new MuteQuack();
    }

    public abstract void Display();

    public void PerformFly()
    {
        _flyBehavior.Fly();
    }

    public void PerformQuack()
    {
        _quackBehavior.Quack();
    }

    public void Swim()
    {
        Debug.Log("所有的鸭子都会游泳");
    }
}

