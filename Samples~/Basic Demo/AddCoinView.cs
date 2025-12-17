using System;
using TMPro;
using UnityEngine.UI;


[Serializable]
public class AddCoinView
{
    public TextMeshProUGUI coinText;

    public Button addCoinBtn;
    // 调用方法修改view
    public void RenderCoinText(int currentCoint)
    {
        if (coinText!= null)
        {
            coinText.text = $"{currentCoint}";
        }
    }
}
