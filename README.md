
# SiYangUnityMVC - 简单的 Unity MVC 框架
[English](README_en.md)

SiYangUnityMVC 是一个轻量级的 Unity MVC 框架，旨在简化 Unity 项目中的 MVC 结构实现。它提供了最简单的模型（Model）、视图（View）和控制器（Controller）设计，便于开发者快速集成和使用。框架包括基本的绑定、订阅和事件通知机制，帮助你更好地管理数据和用户交互逻辑。

## 特性

- 简单易用的 MVC 结构
- 支持数据绑定和事件通知
- 轻量级的设计，适合快速开发
- 使用 C# 标准库和 Unity UI 组件

## 安装

1. 下载或克隆该项目。
2. 将 `SiYangUnityMVC` 文件夹放入你的 Unity 项目的 `Assets` 文件夹中。
3. 通过 `BindUtil`、`IMvcController`、`SYMvcDisposer` 等工具来开始使用 MVC 模式。

当然也可以直接使用Unity的Url安装到package。

## 使用方法
先下载Sample查看最简单使用例子。

### 绑定数据和视图
```csharp
using _02_Scripts._LikeBallBlast.SiYangMVC;

// 创建一个观察者
SYMvcObservable<int> observable = new SYMvcObservable<int>();

// 创建一个 Disposer 来管理绑定的生命周期
SYMvcDisposer disposer = new SYMvcDisposer();

// 绑定数据变化和视图渲染
disposer.Bind(observable, value => Debug.Log("数据变化: " + value));

// 更新数据，自动触发视图更新
observable.Value = 10;
```

### 绑定按钮事件
```csharp
using UnityEngine;
using UnityEngine.UI;
using _02_Scripts._LikeBallBlast.SiYangMVC;

public class ButtonHandler : MonoBehaviour
{
    public Button button;
    private SYMvcDisposer disposer = new SYMvcDisposer();

    void Start()
    {
        disposer.OnClick(button, () => Debug.Log("按钮点击!"));
    }
}
```

### 控制器接口实现
```csharp
public class MyController : MonoBehaviour, IMvcController
{
    public void Bind()
    {
        // 实现绑定逻辑
    }

    public void Unbind()
    {
        // 实现解绑逻辑
    }
}
```

## 贡献

欢迎提交 Issues 和 Pull Requests！

## 许可证

MIT 许可证。

