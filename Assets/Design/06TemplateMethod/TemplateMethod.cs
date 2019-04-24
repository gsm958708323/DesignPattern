using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 模板方法：
/// 把一些公用的方法或者流程封装起来，方便其他地方使用
/// </summary>
public class TemplateMethod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IPeople people = new SouthPeople();
        people.Eat();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
///实现不同国家的人去饭店吃东西
public abstract class IPeople
{
    public void Eat()
    {
        //一般流程：下单，吃饭，付钱
        Order();
        EatSomething();
        Pay();
    }

    private void Order()
    {
        Debugger.Log("下单");
    }
    protected virtual void EatSomething() { }
    private void Pay()
    {
        Debugger.Log("付钱");
    }
}
public class NorthPeople : IPeople
{
    protected override void EatSomething()
    {
        Debugger.Log("我爱吃馒头");
    }
}
public class SouthPeople : IPeople
{
    protected override void EatSomething()
    {
        Debugger.Log("我爱吃米饭");
    }
}