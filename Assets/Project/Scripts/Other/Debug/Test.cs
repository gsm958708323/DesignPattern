//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Test : MonoBehaviour
//{

//    // Use this for initialization
//    void Start()
//    {
//        //InitPanelToCanvas(Resources.Load("Panel"));
//        //UIManager.Instance.ToString();
//        UIManager.Instance.PushPanel(PanelType.MainPanel);
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }

//    /// <summary>
//    /// 生成panel到canvas
//    /// </summary>
//    /// <param name="obj"></param>
//    /// <returns></returns>
//    private GameObject InitPanelToCanvas(Object obj)
//    {
//        GameObject panel = Instantiate(obj) as GameObject;
//        Transform canvas = GameObject.FindGameObjectWithTag("MainCanvas").transform;
//        //if (canvas == null)
//        {
//            Debug.LogError("this canvase  not find");
//            return null;
//        }
//        else
//        {
//            panel.transform.SetParent(canvas);

//            panel.transform.GetComponent<RectTransform>().offsetMax = Vector2.zero;
//            panel.transform.GetComponent<RectTransform>().offsetMin = Vector2.zero;
//            return panel;
//        }
//    }
//}
