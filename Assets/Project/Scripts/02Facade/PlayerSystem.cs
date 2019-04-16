using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSystem : IGameSystem
{
    public PlayerSystem(SystemMananger system) : base(system)
    {
    }
    public override void Init()
    {
        Debugger.Log("<color=green> PlayerSystem Init !</color> ");
    }

    public override void Release()
    {
        Debugger.Log("<color=green> PlayerSystem Release !</color> ");
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            m_SystemMananger.GameEventRegist("PlayerSystem");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            m_SystemMananger.GameEventRemove("PlayerSystem");
        }

        m_SystemMananger.UIUpdate();
    }
}

