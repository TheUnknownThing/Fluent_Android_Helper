# Fluent Android Helper 开发文档

> A Developer Guideline for who wants to contribute to this project.

## #1 开发环境
你需要准备：
- Visual Studio 2019
- .Net Framework 4.5开发环境
- Git bash使用

下载项目并在本地打开，修改软件功能、修复bug，修改之后,首先push到你的库,然后登录GitHub,在你的库的首页可以看到一个 pull request 按钮,点击它,填写一些说明信息,然后提交即可。

## #2 开发须知
软件依赖库：FluentWPF,ModernWPFUI

软件窗口大小：
- 小窗口 Height=470 Width=450
- 中窗口 Height=600 Width=700
- 大窗口（仅限主页面） Height=800 Width=1300

与每个窗口大小中NavigationView配套的Page大小：
- 小窗口 Height=443 Width=410
- 中窗口 Height=693 Width=500

其中，小窗口的NavigationView的PaneDisplayMode为LeftMinimal，中窗口的NavigationView的PaneDisplayMode为Top。

软件全局定义了一个类为ADBExecutor，其中input为执行的adb命令内容，output为输出，CommandExecutor为执行命令。
基本使用如下：
```cs
ADBExecutor.input = "adb devices";
ADBExecutor.CommandExecutor();
string k=ADBExecutor.output;
```

后续会加入小米专属工具箱，OPPO工具箱，三星工具箱（或许），敬请各位大佬帮助开发。

软件开发的公告以及更新日志均通过Gitee上的文件读取，请在Pull Requests是同时附上此次更新内容以及日志。

目前软件分支只有main分支，后续可能会加入dev分支（看心情）。

## 最后，Happy Coding!
