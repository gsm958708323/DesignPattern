using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePanel : BasePanel
{
    public override void OnEnter()
    {
        Debug.Log("Battle panel Enter！");
        m_UIComponentBase.InitPanel(transform, gameObject);
    }

    public override void OnExit()
    {

    }
}
