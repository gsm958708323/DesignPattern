
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanelBase : MonoBehaviour
{
    /*
     * 往所有面板下组件添加UIBehaviour
     * 添加脚本到指定物体
     * 获取脚本到指定物体
     */
    private string m_PanelName;

    /// <summary>
    /// 对外界提供的方法，生成panel并且添加管理脚本
    /// </summary>
    /// <param name="panel"></param>
    public void InitPanel(Transform panel)
    {
        m_PanelName = panel.name;
        AddBehaviourToChild();

        UIComponentManager.Instance.RegistUIComponent(m_PanelName, m_PanelName, gameObject);
    }

    /// <summary>
    /// 往组件添加管理脚本
    /// </summary>
    private void AddBehaviourToChild()
    {
        AddBehaviour(transform);
    }
    private void AddBehaviour(Transform panel)
    {
        //panel -- button -- text
        for (int i = 0; i < panel.childCount; i++)
        {
            Transform child = panel.GetChild(i);
            UIBehaviours behaviours = child.GetComponent<UIBehaviours>();
            if (behaviours == null)//处理子节点
                child.gameObject.AddComponent<UIBehaviours>();
            if (child.childCount > 0)//处理孙节点
            {
                AddBehaviour(child);
            }
        }
    }
    /// <summary>
    /// 添加脚本到指定组件
    /// </summary>
    public T AddBehavioursToComponent<T>(string componentName) where T : Component
    {
        GameObject obj = UIComponentManager.Instance.GetUIComponent(m_PanelName, componentName);
        if (obj == null)
            return default(T);
        else
            return obj.AddComponent<T>();
    }
    /// <summary>
    /// 获取指定脚本
    /// </summary>
    public T GetUICompenent<T>(string componentName) where T : Component
    {
        GameObject obj = UIComponentManager.Instance.GetUIComponent(m_PanelName, componentName);
        if (obj == null)
        {
            Debug.Log("请检查找对象：" + componentName);
            return default(T);
        }
        return obj.GetComponent<T>();
    }

}

