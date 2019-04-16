using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Design.Observer2
{
    /// <summary>
    /// 主题
    /// </summary>
    public interface Subject
    {
        /// <summary>
        /// 注册
        /// </summary>
        void Regist(Observer o);
        /// <summary>
        /// 移除
        /// </summary>
        void Remove(Observer o);
        /// <summary>
        /// 通知
        /// </summary>
        void Notify();
    }
    public interface Observer
    {
        /// <summary>
        /// 观察者通过此方法更新数据
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        void Update(float temprature, float humidity, float pressure);
    }

    public class WeatherData : Subject
    {
        private float m_Temprature, m_Humidity, m_Pressure;
        private List<Observer> m_Observers;

        public void Regist(Observer o)
        {
            if (m_Observers == null)
                m_Observers = new List<Observer>();
            if (!m_Observers.Contains(o))
                m_Observers.Add(o);
        }
        public void Remove(Observer o)
        {
            if (m_Observers.Contains(o))
                m_Observers.Remove(o);
        }
        public void Notify()
        {
            for (int i = 0; i < m_Observers.Count; i++)
            {
                m_Observers[i].Update(m_Temprature, m_Humidity, m_Pressure);
            }
        }
        public void SetData(float temprature, float humidity, float pressure)
        {
            m_Temprature = temprature;
            m_Humidity = humidity;
            m_Pressure = pressure;
            Notify();
        }
    }

    public class DisplayDevice1 : Observer
    {
        private float m_Temprature, m_Humidity, m_Pressure;

        public DisplayDevice1(Subject weatherData)
        {
            weatherData.Regist(this);
        }
        public void Update(float temprature, float humidity, float pressure)
        {
            m_Temprature = temprature;
            m_Humidity = humidity;
            m_Pressure = pressure;
            Display();
        }

        public void Display()
        {
            Debugger.LogFormat("<color=green>DisplayDevice1:负责显示气象指数</color>:{0} ,{1}, {2}", m_Temprature, m_Humidity, m_Pressure);
        }
    }
    public class DisplayDevice2 : Observer
    {
        private Subject m_Subject;
        private float m_Temprature, m_Humidity, m_Pressure;

        public DisplayDevice2(Subject weatherData)
        {
            m_Subject = weatherData;
            weatherData.Regist(this);
        }
        public void Update(float temprature, float humidity, float pressure)
        {
            m_Temprature = temprature;
            m_Humidity = humidity;
            m_Pressure = pressure;
            Display();
        }

        public void Display()
        {
            Debugger.LogFormat("<color=blue>DisplayDevice2:负责整合气象指数</color>:{0}", m_Temprature + m_Humidity + m_Pressure);
        }

        /// <summary>
        /// 注销观察者
        /// </summary>
        public void UnRegist()
        {
            if (m_Subject != null)
                m_Subject.Remove(this);
        }
    }
}
