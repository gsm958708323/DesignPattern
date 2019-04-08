using System;
using System.Collections.Generic;
using UnityEngine;

public class Debugger
{
    public static Debugger Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Debugger();
            return _instance;
        }
    }
    private static Debugger _instance;

    public void Log(string str)
    {
        UnityEngine.Debug.Log(str);
    }

    public void LogWarning(string str)
    {
        UnityEngine.Debug.LogWarning(str);
    }
}
