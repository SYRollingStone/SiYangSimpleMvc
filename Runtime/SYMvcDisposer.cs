using System;
using System.Collections.Generic;

namespace SiYangMVC.Runtime
{
    // 缓存起来，在合适的时候统一释放
    public  sealed  class SYMvcDisposer : IDisposable
    {
        private readonly List<Action> _undos = new();

        public void Add(Action undo)
        {
            if (undo != null) _undos.Add(undo);
        }

        public void Dispose()
        {
            for (int i = _undos.Count - 1; i >= 0; i--)
                _undos[i]?.Invoke();
            _undos.Clear();
        }
    }
}