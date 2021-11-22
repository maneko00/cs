using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.Infrastructure.SQLite;
using System;

//データバインド
using System.ComponentModel;

namespace DDD.WinForm.ViewModels
{
    //データバインド
    public class WeatherLatestViewModel : INotifyPropertyChanged
    {
        private IWeatherRepository _weather;
        IAreasRepository _areas;

        public WeatherLatestViewModel()
            : this(new WeatherSQLite(), new AreasSQLite())
        {
        }

        // public WeatherLatestViewModel(
        //     IWeatherRepository weather,
        //     IAreasRepository areas)
        // {
        //     _weather = weather;
        //     _areas = areas;

        //     foreach(var area in _areas.GetData())
        //     {
        //         Areas.Add(new AreaEntity(area.AreaId, area.AreaName));
        //     }
        // }

        // データバインド
        private string aredId_ = string.Empty;
        public string AreaId
        {
            get { return aredId_; }
            set
            {
                if(aredId_ == value)
                {
                    return;
                }

                aredId_ = value;
                OnPropertyChanged("AreaIdTextBox");
                // SetProperty(ref aredId_, value);
            }
        }

        // private string _dataDateText = string.Empty;
        // public string DataDateText
        // {
        //     get { return _dataDateText; }
        //     set
        //     {
        //         SetProperty(ref _dataDateText, value);
        //     }
        // }

        // private string _conditionText = string.Empty;
        // public string ConditionText
        // {
        //     get { return _conditionText; }
        //     set
        //     {
        //         SetProperty(ref _conditionText, value);
        //     }
        // }

        // private string _temperatureText = string.Empty;
        // public string TemperatureText
        // {
        //     get { return _temperatureText; }
        //     set
        //     {
        //         SetProperty(ref _temperatureText, value);
        //     }
        // }

        // public BindingList<AreaEntity> Areas { get; set; }
        // = new BindingList<AreaEntity>();
        
        //データバインド
        public　event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property_name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property_name));
        }


        // public void Search()
        // {
        //     var entity = _weather.GetLatest(Convert.ToInt32(_selectedAredId));
        //     if (entity == null)
        //     {
        //         DataDateText = string.Empty;
        //         ConditionText = string.Empty;
        //         TemperatureText = string.Empty;
        //     }
        //     else
        //     {
        //         DataDateText = entity.DataDate.ToString();
        //         ConditionText = entity.Condition.DisplayValue;
        //         TemperatureText = entity.Temperature.DisplayValueWithUnitSpace;
        //     }
        // }
    }
}