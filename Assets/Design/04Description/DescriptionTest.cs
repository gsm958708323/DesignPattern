using UnityEngine;
using System.Collections;
using System;
using Design.Description;

public class DescriptionTest : MonoBehaviour
{
    private void Start()
    {
        Test();
    }

    private void Test()
    {
        Coffer coffer = new DarkRoast();
        coffer = new Whip(coffer);
        coffer = new Mocha(coffer);
        Debugger.Log(coffer.GetDescription() + "  " + coffer.Cost());
    }
}
