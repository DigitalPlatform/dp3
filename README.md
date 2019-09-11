# dp3
Integrated Library System, 2018


## 如何编译

1) 应使用 Visual Studio 2017 或 2019

2) 确保安装过 .NET Core SDK 2.6 以上版本
下载地址：
https://dotnet.microsoft.com/download/visual-studio-sdks

3) dp3 Solution 中引用了一个名为 dp-library 的submodule。需要用 Git 命令行执行（先安装一个Git桌面工具，例如GitHub Desktop，然后启动Git Shell）：

```
git submodule init
git submodule update
```

以确保获得最新的 dp-library 代码。

Git 命令执行以后，需要重新打开 dp2 Solution 变动才能生效
