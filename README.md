画面間の値の受け渡しはコンストラクタでおこなう
渡す方
```
var f = new AForm(100)
f.ShowDialog();
```

受け取る方
```
public partial class AForm : Form
{
  private int value_
  public AForm(int value)
  {
    InitializeComponent();
    
    _value = value;
  }
}
```
