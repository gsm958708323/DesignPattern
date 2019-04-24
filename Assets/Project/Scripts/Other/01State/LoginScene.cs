using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginScene : IStateBase
{

    public void OnEnter()
    {
        Debugger.Log("LoginScene Enter !");
    }

    public void OnExit()
    {
        Debugger.LogWarning("LoginScene Exit !");
    }

    public void OnUpdate()
    {

    }
}
