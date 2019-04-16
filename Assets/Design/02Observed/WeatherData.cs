using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Design.Observer1
{
    /// <summary>
    /// 主题：主要负责通知观察者
    /// </summary>
    public interface Subject
    {
        /// <summary>
        /// 注册观察者
        /// </summary>
        /// <param name="o"></param>
        void registObserver(Observer o);
        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="o"></param>
        void removeObserver(Observer o);
        /// <summary>
        /// 通知观察者
        /// </summary>
        void notifyObservers();
    }
    public interface Observer
    {
        void Update(float tmmp, float humidity, float pressure);
    }
    public interface DisplayElement
    {
        void Display();
    }
    public class WeatherData : Subject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;
        public WeatherData()
        {
            observers = new ArrayList();
        }
        /// <summary>
        /// 测量结果改变
        /// </summary>
        public void MeasurementsChanged()
        {
            notifyObservers();
        }
        public void SetMeasurements(float temprature, float humidity, float pressure)
        {
            this.temperature = temprature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }

        public void registObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void notifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                Observer observer = (Observer)observers[i];
                observer.Update(temperature, humidity, pressure);
            }
        }
    }
    /// <summary>
    /// 气象显示面板
    /// </summary>
    public class CurConditionsDisplay : Observer, DisplayElement
    {
        private float temprature;
        private float humidity;
        private float pressure;
        private Subject weatherData;
        public CurConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registObserver(this);
        }

        public void Display()
        {
            Debugger.LogFormat("<color=green>CurConditionsDisplay</color>:{0} ,{1}, {2}", temprature, humidity, pressure);
        }

        public void Update(float temprature, float humidity, float pressure)
        {
            this.temprature = temprature;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }
    }
    public class ForecastDisplay : Observer, DisplayElement
    {
        private float temprature;
        private float humidity;
        private float pressure;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registObserver(this);
        }

        public void Display()
        {
            Debugger.LogFormat("<color=blue>ForecastDisplay</color>:{0} ,{1}, {2}", temprature, humidity, pressure);
        }

        public void Update(float temprature, float humidity, float pressure)
        {
            this.temprature = temprature;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }
    }
}

