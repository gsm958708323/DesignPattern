using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePanel : MonoBehaviour
{
    /// <summary>
    /// 界面显示出来
    /// </summary>
    public virtual void OnEnter() { }

    /// <summary>
    /// 界面暂停(弹出了其他界面)
    /// </summary>
    public virtual void OnPause() { }

    /// <summary>
    /// 界面继续(其他界面移除，回复本来的界面交互)
    /// </summary>
    public virtual void OnResume() { }

    /// <summary>
    /// 界面不显示,退出这个界面，界面被关闭
    /// </summary>
    public virtual void OnExit() { }
}
public enum PanelType
{
    MainPanel,
    BattlePanel
}
public class PathModel
{
    public string panelType { get; set; }
    public string path { get; set; }
}

