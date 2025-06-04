# GoldWatch

一款实时监控中国黄金价格的软件，轻量小巧。(支持Macos)

Real-Time monitoring software for gold price.

![GoldWatch](/Blog/preview.png)

## 发布

```sh
dotnet publish -c Release -r osx-x64 --self-contained true -p:PublishSingleFile=true -p:UseAppHost=true -p:OutputType=WinExe
```

## 生成为app

- 项目发布后，执行`AutoMakeApp.sh`脚本，会自动在`publish`目录下生成app文件
