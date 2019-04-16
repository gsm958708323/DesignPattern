using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDuck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Test();
        Test2();
    }

    /// <summary>
    /// 我想要一个唐老鸭
    /// </summary>
    void Test()
    {
        Duck duck = new MallardDuck(new FlyNoWay(), new Speak());
        duck.PerformFly();
        duck.PerformQuack();
        duck.Display();
    }

    /// <summary>
    /// 我想要一个模型鸭拥有火箭的动力，而且会叫
    /// </summary>
    void Test2()
    {
        var duck = new ModelDuck();
        duck.PerformFly();
        duck.PerformQuack();
        duck.Display();
        duck.FlyBehavior = new FlyRockPowered();
        duck.QuackBehavior = new Squeak();
        duck.PerformFly();
        duck.PerformQuack();
        duck.Display();
    }
}
