# CollectBlue

C# .NETのBluesky APIのラッパーライブラリです

自分で必要な部分しかまだ実装されていません

トークンの作成：
```csharp
var token = await Token.Create("handle", "password");
```

プロフィールの取得（app.bsky.actor.getProfile）：
```csharp
var profile = await token.GetProfile("actor");
```

ユーザーフィードの取得（app.bsky.feed.getAuthorFeed）：
```csharp
var feedCollection = await token.GetUserFeeds("actor");
```

ポスト検索（app.bsky.feed.searchPosts）：
```csharp
var postCollection = await token.SearchPosts("query");
```
