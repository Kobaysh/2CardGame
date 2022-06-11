using UnityEngine;
using UnityEditor;
using System;

namespace EventManager
{
    // define delegate
    public delegate void EventDelegate();

    public class EventManager : MonoBehaviour
    {
        // define singleton class
        static EventManager instance;
        public static EventManager Instanse
        {
            get
            {
                if(instance == null)
                {
                    instance = new EventManager();
                }
                return instance;
            }
        }

        private EventManager() { }

        public static event EventDelegate SomeEvent = delegate () { };


        /// <summary>
        /// イベント実行
        /// </summary>
        public static void InvokeEvent()
        {
            SomeEvent();
        }

        /// <summary>
        /// イベント追加
        /// </summary>
        /// <param name="method">登録する関数</param>
        public static void AddEvent(EventDelegate method)
        {
            SomeEvent += method;
        }

        /// <summary>
        /// イベント削除
        /// </summary>
        /// <param name="method">登録済みの関数</param>
        public static void DeleteEvent(EventDelegate method)
        {
            SomeEvent -= method;
        }
    }
}