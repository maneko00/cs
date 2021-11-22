namespace ODDD.Domain.Entities
{
    public sealed class WeatherEntity
    {
        public WeatherEntity(string areaid_text, string temperture_text)
        {
            AreaIdText = areaid_text;
            TempertureText = temperture_text;
        }

        //プロパティ
        public string AreaIdText { get; }
        public string TempertureText { get; }
        

    }
}
