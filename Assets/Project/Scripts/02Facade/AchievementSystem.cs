using System;
using System.Collections.Generic;

public class AchievementSystem : IGameSystem
{

    public AchievementSystem(SystemMananger system):base(system)
    {

    }
    
    public override void Init()
    {
        Debugger.Instance.Log("<color=green> AchievementSystem Init !</color> ");
    }

    public override void Release()
    {
        Debugger.Instance.Log("<color=green> AchievementSystem Release !</color> ");
    }


    public override void Update()
    {

    }

}

