using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 场景管理类
/// </summary>
public class GameLoop : MonoBehaviour
{
    private static GameLoop _instance;
    public static GameLoop Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameLoop();
                DontDestroyOnLoad(_instance);
            }

            return _instance;
        }
    }

    Fsm fsm;

    // Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        Init();
    }
    private void Start()
    {
        fsm.ChangeScene(StateType.MainScene);
    }
    // Update is called once per frame
    void Update()
    {
        fsm.OnUpdate();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            fsm.ChangeScene(StateType.LoginScene);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            fsm.ChangeScene(StateType.MainScene);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            fsm.ChangeScene(StateType.BattleScene);
        }
    }
    /// <summary>
    /// 状态机初始化
    /// </summary>
    private void Init()
    {
        fsm = new Fsm();
        fsm.Regist(StateType.BattleScene, new BattleScene());
        fsm.Regist(StateType.LoginScene, new LoginScene());
        fsm.Regist(StateType.MainScene, new MainScene());
    }
}
