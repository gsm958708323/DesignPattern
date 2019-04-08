using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : IStateBase
{
    public void OnEnter()
    {
        UIManager.Instance.PushPanel(PanelType.MainPanel);
        Debugger.Instance.LogWarning("MainScene Enter !");
    }

    public void OnExit()
    {
        Debugger.Instance.LogWarning("MainScene Exit !");
        UIManager.Instance.Clear();
    }

    public void OnUpdate()
    {
    }
}
