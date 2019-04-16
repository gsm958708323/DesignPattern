using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Duck2
{
    public IFlyBehavior FlyBehavior { private get; set; }
    public IQuackBehavior QuackBehavior { private get; set; }

    protected Duck2(IFlyBehavior flyBehavior = null, IQuackBehavior quackBehavior = null)
    {
        FlyBehavior = flyBehavior ?? new FlyNoWay();
        QuackBehavior = quackBehavior ?? new MuteQuack();
    }

    public abstract void Display();

    public void PerformFly()
    {
        FlyBehavior.Fly();
    }

    public void PerformQuack()
    {
        QuackBehavior.Quack();
    }

    public void Swim()
    {
        Debug.Log("所有的鸭子都会游泳");
    }
}

