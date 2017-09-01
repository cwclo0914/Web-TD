================使用しないファイルについて================

以下のファイルは今回のサーバー開発では使いませんでしたが、
MVC5テンプレの一部であるため、多数のファイルに関わっています。
削除後に必要なコード修正に時間がかかるとの見込みなので、
現在では削除しておりません。

Models：
・AccountModels
・IdentityModels
・ManageModels

Views：
・Accountフォルダ
・Manageフォルダ

Controllers：
・AccountController
・ManageController

また、Web.configに宣言しているDefaultConnectionのDBも使用しておりません。