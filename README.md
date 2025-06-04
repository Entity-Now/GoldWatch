# GoldWatch

一款实时监控中国黄金价格的软件，轻量小巧。(支持Macos)

Real-Time monitoring software for gold price.

![GoldWatch](/Blog/preview.png)

## publish

```sh
dotnet publish -c Release -r osx-x64 --self-contained true -p:PublishSingleFile=true -p:UseAppHost=true -p:OutputType=WinExe
```