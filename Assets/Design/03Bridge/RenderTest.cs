using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Design.Bridge;
using System;

public class RenderTest : MonoBehaviour
{
    private void Start()
    {
        Test();
    }

    private void Test()
    {
        CubeDrawer cube = new CubeDrawer(new OpenGL());
        SphereDrawer sphere = new SphereDrawer(new DirectX());
        cube.Draw();
        sphere.Draw();
    }
}
