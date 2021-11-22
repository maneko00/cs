using ODDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ODDD.WinForm.ViewModels
{
    public class WeatherLatestViewModel
    {
        private IWeatherRepository weather_;

        // コンストラクタにリポジトリ変数を指定
        // テストコードにつながるかもしれないしCSVにつながるかもしれない
        public WeatherLatestViewModel(IWeatherRepository weather)
        {
            weather_ = weather;
        }

        public string AreaIdText { get; set; } = String.Empty;
        public string TempertureText { get; set; } = String.Empty;
        
        public void Search()
        {
            var entity = weather_.GetData();
            if(entity != null)
            {
                AreaIdText = entity.AreaIdText;
                TempertureText = entity.TempertureText;
            }
        }
    }
}
