using System.Collections;
using System.Collections.Generic;
using SiYangMVC.Runtime;
using UnityEngine;

public class AddCoinModel
{
    public SYMvcObservable<int> coin = new();
    
    public void AddCoint(int addCoinCount)
    {
        coin.Value  += addCoinCount;
    }
}
