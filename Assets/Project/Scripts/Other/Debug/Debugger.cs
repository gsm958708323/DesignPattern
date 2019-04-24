using System;
using System.Collections.Generic;
using UnityEngine;

public class Debugger
{
    public static void Log(string str)
    {
        UnityEngine.Debug.Log(str);
    }
    public static void LogWarning(string str)
    {
        UnityEngine.Debug.LogWarning(str);
    }
    public static void LogFormat(string format, params object[] args)
    {
        UnityEngine.Debug.LogFormat(format,args);
    }
}
