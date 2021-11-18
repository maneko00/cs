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
    public partial class UserListForm : Form
    {
        private BindingList<UserInfoDTO> _dtos = new BindingList<UserInfoDTO>();
        public UserListForm()
        {
            InitializeComponent();

            if (System.IO.File.Exists("save.csv"))
            {
                string[] lines =
               System.IO.File.ReadAllLines(
                   "save.csv",
                   Encoding.GetEncoding("shift_jis"));

                foreach (string line in lines)
                {
                    string[] row = line.Split(',');
                    UserInfoDTO dto = new UserInfoDTO(
                        row[0],
                        row[1],
                        row[2],
                        row[3],
                        row[4]);
                    _dtos.Add(dto);
                }

                UserDataGrid.DataSource = _dtos;

                UserDataGrid.Columns[0].HeaderText = "ID";
                UserDataGrid.Columns[1].HeaderText = "メール送信";
                UserDataGrid.Columns[2].HeaderText = "メールアドレス";
                UserDataGrid.Columns[3].HeaderText = "プラン";
                UserDataGrid.Columns[4].HeaderText = "有効／無効";
            }
        }
    }
}
