using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : IStateBase
{
    public void OnEnter()
    {
        UIManager.Instance.PushPanel(PanelType.MainPanel);
        Debugger.LogWarning("MainScene Enter !");
    }

    public void OnExit()
    {
        Debugger.LogWarning("MainScene Exit !");
        UIManager.Instance.Clear();
    }

    public void OnUpdate()
    {
    }
}
