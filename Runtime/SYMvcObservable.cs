using System;

namespace SiYangMVC.Runtime
{
    // 数据变化通知
    [Serializable]
    public sealed  class SYMvcObservable<T>
    {
        private T _value;
        public event Action<T> Changed;

        public SYMvcObservable(T initial = default) => _value = initial;

        public T Value
        {
            get => _value;
            set
            {
                if (Equals(_value, value)) return;
                _value = value;
                Changed?.Invoke(_value);
            }
        }

     
    }
}