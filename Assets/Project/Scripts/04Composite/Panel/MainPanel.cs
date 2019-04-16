using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPanel : BasePanel
{
    public override void OnEnter()
    {
        Debug.Log("Main panel Enter！");
        m_UIComponentBase.InitPanel(transform, gameObject);

        UIBehaviours startButton = m_UIComponentBase.GetUICompenent<UIBehaviours>("StartButton");
        startButton.AddButtonLisenter(StartButton);
    }

    void StartButton()
    {
        GameLoop.Instance.fsm.ChangeScene(StateType.BattleScene);
        Debug.Log("Start Button Click !");
    }


}
