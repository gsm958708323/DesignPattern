using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
/// <summary>
/// 场景状态管理类
/// </summary>
public class Fsm
{
    private bool m_IsRun = false;
    private string m_SceneName;

    private IStateBase m_CurScene;
    private Dictionary<StateType, IStateBase> m_StateDic;


    public Fsm()
    {
        m_StateDic = new Dictionary<StateType, IStateBase>();
    }

    /// <summary>
    /// 注册场景
    /// </summary>
    /// <param name="state"></param>
    /// <param name="type"></param>
    public void Regist(StateType type, IStateBase state)
    {
        if (!m_StateDic.ContainsKey(type))
        {
            m_StateDic.Add(type, state);
        }
    }
    /// <summary>
    /// 注销场景
    /// </summary>
    /// <param name="state"></param>
    public void UnRegist(StateType type)
    {
        if (!m_StateDic.ContainsKey(type))
            return;
        m_StateDic.Remove(type);
    }
    /// <summary>
    /// 切换场景
    /// </summary>
    /// <param name="type"></param>
    public void ChangeScene(StateType type)
    {
        if (!m_StateDic.ContainsKey(type))
        {
            Debugger.LogWarning("场景类型未注册：" + type);
        }
        IStateBase state;
        m_StateDic.TryGetValue(type, out state);

        /*
         * 先判断state，MaxxValue？ ，重复？ , curscene OnExit,OnEnter
          */
        if (state != null)
        {
            if (state != m_CurScene)
            {
                if (m_CurScene != null)
                    m_CurScene.OnExit();
                m_IsRun = true;
                m_CurScene = state;
                async = SceneManager.LoadSceneAsync((int)type);
            }
        }
    }
    AsyncOperation async;
    /// <summary>
    /// 场景更新
    /// </summary>
    public void OnUpdate()
    {
        //if (Application.isLoadingLevel)
        //    return;

        //Debug.LogFormat("SceneName:{0} ,SceneState:{1}", m_SceneName, m_CurScene);

        if (!async.isDone)
        {
            Debug.Log("加载进度：" + async.progress);
            return;
        }

        if (m_IsRun && m_CurScene != null)
        {
            m_CurScene.OnEnter();
            m_IsRun = false;
        }

        if (m_CurScene != null)
            m_CurScene.OnUpdate();
    }
    /*
     * 注意事项：
     * 1.当上一个场景完全加载完毕，再操作下一个场景
     * 2.场景的切换逻辑尽量写到主线程里面，不然会出现异常
     */
}

