using System.Collections;
using System.Collections.Generic;
using SiYangMVC.Runtime;
using UnityEngine;

public class AddCointController : MonoBehaviour,IMvcController
{
    private AddCoinModel _data = new();

    [SerializeField] private AddCoinView _view;
    // 暂时存储绑定关系，方便在某个时刻释放。
    private SYMvcDisposer _disposer;
    
    private void OnEnable()
    {
        Bind();
    }

    private void OnDisable()
    {
        Unbind();
    }

    public void Bind()
    {
        _disposer = new SYMvcDisposer();
        
        _disposer.Bind(_data.coin , _view.RenderCoinText);
        
        // 对Button的绑定
        _disposer.OnClick(_view.addCoinBtn,()=>SetTouchTipVisible(5));
    }

    public void Unbind()
    {
        _disposer?.Dispose();
        _disposer = null;
    }
    
    //----------api-------------
    public void SetTouchTipVisible(int addCoint)
    {
        _data.AddCoint(addCoint);
    }
}
