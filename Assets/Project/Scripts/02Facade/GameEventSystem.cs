using System;
using System.Collections.Generic;

public class GameEventSystem : IGameSystem
{
    public GameEventSystem(SystemMananger system):base(system)
    {

    }

    public override void Init()
    {
        Debugger.Log("<color=green> GameEventSystem Init !</color>");
    }

    public override void Release()
    {
        Debugger.Log("<color=green> GameEventSystem Release !</color>");
    }

    public override void Update()
    {

    }

    /// <summary>
    /// 注册事件
    /// </summary>
    public void RegistEvent(string str)
    {
        Debugger.Log(str+",注册事件！");
    }

    public void RemoveEvent(string str)
    {
        Debugger.Log(str + ",移除事件！");
    }
}

