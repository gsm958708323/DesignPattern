using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 设计一个渲染引擎，通过OpenGL和DirectX来绘制
/// </summary>
namespace Design.Bridge
{
    public interface RenderEngine
    {
        void Render();
    }
    public class DirectX : RenderEngine
    {
        public void Render()
        {
            Debugger.Log("DirectX 绘制");
        }
    }
    public class OpenGL : RenderEngine
    {
        public void Render()
        {
            Debugger.Log("OpenGL 绘制");
        }
    }
    public abstract class IEntity
    {
        protected RenderEngine m_RenderEngine;
        public IEntity(RenderEngine render)
        {
            m_RenderEngine = render;
        }
        public abstract void Draw();
        public abstract void SetRender(RenderEngine render);
    }

    public class CubeDrawer : IEntity
    {
        public CubeDrawer(RenderEngine render) : base(render) { }

        public override void Draw()
        {
            m_RenderEngine.Render();
            Debugger.Log("绘制Cube");
        }

        public override void SetRender(RenderEngine render)
        {
            m_RenderEngine = render;
        }
    }
    public class SphereDrawer : IEntity
    {
        public SphereDrawer(RenderEngine render) : base(render) { }

        public override void Draw()
        {
            m_RenderEngine.Render();
            Debugger.Log("绘制Sphere");
        }
        public override void SetRender(RenderEngine render)
        {
            m_RenderEngine = render;
        }
    }
}
