using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleScene : IStateBase
{
    public void OnEnter()
    {
        SystemMananger.Instance.Init();
        Debug.Log("BattleScene Enter !");
    }

    public void OnExit()
    {
        Debug.LogWarning("BattleScene Exit !");
        UIManager.Instance.Clear();
    }

    public void OnUpdate()
    {
        SystemMananger.Instance.Update();
    }
}
