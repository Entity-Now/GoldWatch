#!/bin/bash

APP_NAME="./publish/GoldWatch.app"
PUBLISH_OUTPUT_DIRECTORY="./bin/Release/net8.0/osx-arm64/publish"
INFO_PLIST="./Info.plist"
ICON_FILE="./Logo.icns"

# 清理旧的 .app 包
if [ -d "$APP_NAME" ]; then
    rm -rf "$APP_NAME"
fi

# 创建目录结构
mkdir -p "$APP_NAME/Contents/MacOS"
mkdir -p "$APP_NAME/Contents/Resources"

# 拷贝 Info.plist 和图标
cp "$INFO_PLIST" "$APP_NAME/Contents/Info.plist"
cp "$ICON_FILE" "$APP_NAME/Contents/Resources/$(basename "$ICON_FILE")"

# 拷贝发布输出文件
cp -a "$PUBLISH_OUTPUT_DIRECTORY"/* "$APP_NAME/Contents/MacOS/"

# 设置执行权限（可选但推荐）
chmod +x "$APP_NAME/Contents/MacOS/GoldWatch"

echo "✅ App bundle created at: $APP_NAME"
