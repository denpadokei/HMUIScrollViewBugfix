# HMUIScrollViewBugfix

[![Build and Release](https://github.com/denpadokei/HMUIScrollViewBugfix/actions/workflows/build-and-release.yml/badge.svg)](https://github.com/denpadokei/HMUIScrollViewBugfix/actions/workflows/build-and-release.yml)

スクロール操作をしたときに、別の画面まで一緒にスクロールしてしまう問題を修正する MOD です。

## 機能

- `ScrollView.contentSize` の getter に Prefix パッチを適用する
- `ScrollView.scrollPageSize` の getter に Prefix パッチを適用する
- `contentRectTransform` / `viewport` が null、または rect を取得できない場合は 0 を返して元の処理を止める
- rect の取得中に例外が出た場合もログに記録して 0 を返し、スクロール状態が壊れるのを防ぐ
- プラグインの無効化時にパッチを解除する

## 動作環境

| 項目 | 内容 |
| --- | --- |
| Beat Saber | 1.21.0 |
| 依存 MOD | BSIPA ^4.2.0 |

## インストール

1. Beat Saber を 1.21.0 に合わせる (BSManager などのバージョン管理ツールを推奨)
2. BSIPA と上記の依存 MOD をインストールする
3. [Releases](https://github.com/denpadokei/HMUIScrollViewBugfix/releases) から `HMUIScrollViewBugfix-1.0.1-bs1.21.0.zip` をダウンロードし、`Plugins` フォルダをゲームフォルダへ上書きコピーする

## 使い方

ゲーム内に UI や設定はありません。インストールするだけで適用されます。

## ビルド

```powershell
git clone https://github.com/denpadokei/HMUIScrollViewBugfix.git
cd HMUIScrollViewBugfix
dotnet build .\HMUIScrollViewBugfix\HMUIScrollViewBugfix.csproj -c Release
```

`BeatSaberDir` (または `GameDirectory`) に Beat Saber のインストール先を設定すると、ゲームの参照アセンブリを解決できます。

GitHub Actions の `build-and-release.yml` が push ごとにビルドし、`X.X.X` 形式のタグを push するとリリースを作成します。

## ライセンス

MIT ライセンスです。詳細は [LICENSE](LICENSE) を参照してください。
