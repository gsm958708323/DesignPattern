using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Design.Strategy
{
    /// <summary>
    /// 对外界使用的方法
    /// </summary>
    public interface Strategy
    {
        void Interface();
    }

    public class Context
    {
        Strategy m_Strategy;
        public Context(Strategy strategy)
        {
            m_Strategy = strategy;
        }
        public void ContextInterface()
        {
            m_Strategy.Interface();
        }
    }
    public class StrategyA : Strategy
    {
        public void Interface()
        {
            Debugger.Log("StrategyA 功能");
        }
    }
    public class StrategyB : Strategy
    {
        public void Interface()
        {
            Debugger.Log("StrategyB 功能");
        }
    }
}
