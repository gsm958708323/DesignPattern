using System;
using System.Collections.Generic;

public class SystemMananger
{
    private static SystemMananger _instance;
    public static SystemMananger Instance
    {
        get
        {
            if (_instance == null)
                _instance = new SystemMananger();
            return _instance;
        }
    }

    private SystemMananger()
    {
        m_PlayerSystem = new PlayerSystem(this);
        m_AchievementSystem = new AchievementSystem(this);
        m_GameEventSystem = new GameEventSystem(this);
    }

    private PlayerSystem m_PlayerSystem;
    private AchievementSystem m_AchievementSystem;
    private GameEventSystem m_GameEventSystem;

    public void Init()
    {
        m_PlayerSystem.Init();
        m_AchievementSystem.Init();
        m_GameEventSystem.Init();
    }

    public void Release()
    {
        m_PlayerSystem.Release();
        m_AchievementSystem.Release();
        m_GameEventSystem.Release();
    }

    public void Update()
    {
        m_PlayerSystem.Update();
        m_AchievementSystem.Update();
        m_GameEventSystem.Update();
    }

    //——————————————————————————————————————————————————————————————
    public void GameEventRegist(string str)
    {
        m_GameEventSystem.RegistEvent(str);
    }
    public void GameEventRemove(string str)
    {
        m_GameEventSystem.RemoveEvent(str);
    }
}

