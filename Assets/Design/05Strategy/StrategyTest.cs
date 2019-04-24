using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Design.Strategy;
using System;

public class StrategyTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Test();
    }

    private void Test()
    {
        Context context = new Context(new StrategyA());
        context.ContextInterface();
    }
}
