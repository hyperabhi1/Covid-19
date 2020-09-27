using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Covid_19.DAL;
using Covid_19.DataModels;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;

namespace Covid_19
{
    class Common
    {
        public static UserStatsPair ConvertToUserStatsPair(List<UserStats> dailyStatuses)
        {
            var userStatsPair = new UserStatsPair();

            var temperatureCollection = new List<KeyValuePair<DateTime, double>>();
            var oximeterCollection = new List<KeyValuePair<DateTime, int>>();
            var heartrateCollection = new List<KeyValuePair<DateTime, int>>();

            foreach (var dailyStatus in dailyStatuses)
            {
                var time = dailyStatus.Time;
                var temperature = dailyStatus.Temperature;
                var oximeter = dailyStatus.Oximeter;
                var heartrate = dailyStatus.Heartrate;

                temperatureCollection.Add(new KeyValuePair<DateTime, double>(time, temperature));
                oximeterCollection.Add(new KeyValuePair<DateTime, int>(time, oximeter));
                heartrateCollection.Add(new KeyValuePair<DateTime, int>(time, heartrate));

            }

            userStatsPair.TemperatureCollection = temperatureCollection;
            userStatsPair.OximeterCollection = oximeterCollection;
            userStatsPair.HeartrateCollection = heartrateCollection;

            return userStatsPair;
        }
        public static ChartValues<DateModel> GetChartValues(List<KeyValuePair<DateTime, double>> list)
        {
            var chartValues = new ChartValues<DateModel>();
            if (list != null && list.Any())
            {
                list.ForEach(x => chartValues.Add(new DateModel()
                {
                    Time = x.Key,
                    Value = x.Value
                }));
            }
            return chartValues;
        }
        public static ChartValues<DateModel> GetChartValues(List<KeyValuePair<DateTime, int>> list)
        {
            var chartValues = new ChartValues<DateModel>();
            if (list != null && list.Any())
            {
                list.ForEach(x => chartValues.Add(new DateModel()
                {
                    Time = x.Key,
                    Value = x.Value
                }));
            }
            return chartValues;
        }

        public static LineSeries GetLineSeries(string fullName, ChartValues<DateModel> chartValues)
        {
            return new LineSeries()
            {
                Title = fullName,
                PointGeometrySize = 5,
                Values = chartValues,
                ScalesYAt = 0
            };
        }
        public static SeriesCollection GetSeriesCollection()
        {
            var dayConfig = Mappers.Xy<DateModel>()
                .X(dateModel => dateModel.Time.Ticks / TimeSpan.FromSeconds(1).Ticks)
                .Y(dateModel => dateModel.Value);
            return new LiveCharts.SeriesCollection(dayConfig);
        }

        public static Axis GetDateTimeAxis()
        {
            return new LiveCharts.Wpf.Axis
            {
                LabelFormatter = value =>
                    new DateTime((long)(value * TimeSpan.FromSeconds(1).Ticks)).ToString("dd/MM/yy")
            };
        }
    }
}
