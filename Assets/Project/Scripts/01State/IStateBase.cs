﻿using System;
using System.Collections.Generic;

public interface IStateBase
{
    void OnEnter();
    void OnExit();
    void OnUpdate();
}

public enum StateType
{
    LoginScene,
    MainScene,
    BattleScene,
}