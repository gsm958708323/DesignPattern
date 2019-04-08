using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginScene : IStateBase
{

    public void OnEnter()
    {
        Debugger.Instance.Log("LoginScene Enter !");
    }

    public void OnExit()
    {
        Debugger.Instance.LogWarning("LoginScene Exit !");
    }

    public void OnUpdate()
    {

    }
}
