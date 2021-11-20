画面間の値の受け渡しはコンストラクタでおこなう
渡す方
```
var f = new AForm(textBox.Text)
f.ShowDialog();
```

受け取る方
```
public partial class AForm : Form
{
  private string a_string_
  public AForm(string value)
  {
    InitializeComponent();
    
    a_string_ = value;
  }
}
```
## ファイル整理
project
archive
　format
shortcut
カテゴリ＋年月日＋〇〇

## カバレッジツール
カバレッジとは、テストコードがどれくらい書けているか調べること
- Fine code coverage
  表示＞その他のウィンドウ＞Fine code coverage

- AxoCover
  ツール＞AxoCover
