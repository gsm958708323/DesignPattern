using System;
using System.Collections.Generic;

public class GameEventSystem : IGameSystem
{
    public GameEventSystem(SystemMananger system):base(system)
    {

    }

    public override void Init()
    {
        Debugger.Instance.Log("<color=green> GameEventSystem Init !</color>");
    }

    public override void Release()
    {
        Debugger.Instance.Log("<color=green> GameEventSystem Release !</color>");
    }

    public override void Update()
    {

    }

    /// <summary>
    /// 注册事件
    /// </summary>
    public void RegistEvent(string str)
    {
        Debugger.Instance.Log(str+",注册事件！");
    }

    public void RemoveEvent(string str)
    {
        Debugger.Instance.Log(str + ",移除事件！");
    }
}

