using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleScene : IStateBase
{
    public void OnEnter()
    {
        UIManager.Instance.PushPanel(PanelType.BattlePanel);
        SystemMananger.Instance.Init();
        Debugger.Instance.Log("BattleScene Enter !");
    }

    public void OnExit()
    {
        Debugger.Instance.LogWarning("BattleScene Exit !");
        UIManager.Instance.Clear();

        SystemMananger.Instance.Release();
    }

    public void OnUpdate()
    {
        SystemMananger.Instance.Update();
    }
}
