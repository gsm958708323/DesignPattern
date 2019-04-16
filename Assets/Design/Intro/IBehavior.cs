using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//对于变化的封装
public interface IFlyBehavior
{
    void Fly();
}
public interface IQuackBehavior
{
    void Quack();
}
/// <summary>
/// 吱吱叫
/// </summary>
public class Squeak : IQuackBehavior
{
    public void Quack()
    {
        Debug.Log("吱吱");
    }
}
/// <summary>
/// 呱呱叫
/// </summary>
public class NormalQuack : IQuackBehavior
{
    public void Quack()
    {
        Debug.Log("呱呱");
    }
}
public class Speak : IQuackBehavior
{
    public void Quack()
    {
        Debug.Log("我会说人话！~");
    }
}
/// <summary>
/// 哑巴
/// </summary>
public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Debug.Log("---------");
    }
}
public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Debug.Log("我不会飞");
    }
}
public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Debug.Log("我用翅膀飞");
    }
}
public class FlyRockPowered : IFlyBehavior
{
    public void Fly()
    {
        Debug.Log("火箭带我飞");
    }
}