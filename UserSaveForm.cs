using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class UserSaveForm : Form
    {
        public UserSaveForm()
        {
            InitializeComponent();

            StatusLabel.Text = "必要事項を入力して保存してください";

            EnableComboBox.Items.Add("有効"); 
            EnableComboBox.Items.Add("無効");
            EnableComboBox.SelectedIndex = 0;
            EnableComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            MailCheckBox.Checked = false;
            FreeRadioButton.Checked = true;

            SetMailAddressTextBox();
            PlanChange();
        }

        private void MailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetMailAddressTextBox();
        }

        private void SetMailAddressTextBox()
        {
            MailAddressTextBox.Enabled = MailCheckBox.Checked;
            MailAddressLabel.Enabled = MailCheckBox.Checked;
        }

        private void BusinessRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PlanChange();
        }

        private void PlanChange()
        {
            NoteLabel.Visible = BusinessRadioButton.Checked;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("IDを入力してください",
                    "警告",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                IdTextBox.Focus();
                return;
            }

            if (IdTextBox.Text.Contains(","))
            {
                MessageBox.Show("IDにカンマは入力できません",
                    "警告",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                IdTextBox.Focus();
                return;
            }

            if (MailAddressTextBox.Text.Contains(","))
            {
                MessageBox.Show("メールアドレスにカンマは入力できません",
                   "警告",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                MailAddressTextBox.Focus();
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                  "保存しますか？",
                  "確認",
                  MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                using (var sw = new
                    System.IO.StreamWriter(
                    "save.csv",
                    true, 
                    Encoding.GetEncoding("shift_jis")))
                {
                    sw.Write(IdTextBox.Text);
                    sw.Write(",");
                    sw.Write(MailCheckBox.Checked);
                    sw.Write(",");
                    sw.Write(MailAddressTextBox.Text);
                    sw.Write(",");
                    if (BusinessRadioButton.Checked)
                    {
                        sw.Write("1");
                    }
                    else
                    {
                        sw.Write("0");
                    }

                    sw.Write(",");

                    sw.Write(EnableComboBox.Text);
                    sw.WriteLine("");
                }

                StatusLabel.Text = "保存しました";
            }
            else
            {
                StatusLabel.Text = "キャンセルしました";
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
