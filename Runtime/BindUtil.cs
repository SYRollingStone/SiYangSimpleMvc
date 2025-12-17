using System;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SiYangMVC.Runtime
{
    public static  class BindUtil
    {
        /// <summary>
        /// 订阅 Observable 变化并立即渲染一次；自动把解绑动作登记到 disposer。
        /// </summary>
        public static void Bind<T>(this SYMvcDisposer disposer, SYMvcObservable<T> obs, Action<T> render, bool renderImmediately = true)
        {
            if (obs == null || render == null) return;

            obs.Changed += render;
            disposer.Add(() => obs.Changed -= render);

            if (renderImmediately)
                render(obs.Value);
        }
        
        /// <summary>
        /// 绑定按钮点击，并在 disposer.Dispose() 时自动 RemoveListener。
        /// </summary>
        public static void OnClick(this SYMvcDisposer disposer, Button button, UnityAction action)
        {
            if (button == null || action == null) return;

            button.onClick.AddListener(action);
            disposer.Add(() => button.onClick.RemoveListener(action));
        }

        /// <summary>
        /// 可选：如果你希望“重新 Bind 时先清空旧监听”，用这个。
        /// （注意：会移除 Inspector 里手动绑的事件）
        /// </summary>
        public static void OnClickReplaceAll(this SYMvcDisposer disposer, Button button, UnityAction action)
        {
            if (button == null) return;

            button.onClick.RemoveAllListeners();
            if (action == null) return;

            button.onClick.AddListener(action);
            disposer.Add(() => button.onClick.RemoveListener(action));
        }
    }
}