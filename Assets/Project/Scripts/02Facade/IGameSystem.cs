using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IGameSystem
{
    //子类可以通过SystemMananger来使用其它子系统的功能
    protected SystemMananger m_SystemMananger;
    public IGameSystem(SystemMananger system)
    {
        m_SystemMananger = system;
    }

    public abstract void Init();
    public abstract void Release();
    public abstract void Update();
}
