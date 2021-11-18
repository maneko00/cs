画面間の値の受け渡しはコンストラクタでおこなう
渡す方
```
var f = new AForm(string)
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
