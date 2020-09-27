using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Covid_19.DAL;
using Covid_19.DataModels;
using Covid_19.ServiceModels;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;

namespace Covid_19
{
    public partial class Dashboard : Form
    {
        private DateTime timer;
        private Dictionary<string, DailyReading> userReadings = new Dictionary<string, DailyReading>(); 
        private List<string> parameters = new List<string>();
        public Dashboard()
        {
            InitializeComponent();
            parameters.Add("Temperature");
            parameters.Add("Oximeter");
            parameters.Add("Heartrate");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.userTableAdapter.Fill(this._Covid_19DataSet.User);
            listBoxChartUsers.DataSource = UsersData.Get();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var users =UsersData.Get();
            string user = users[listBoxUsers.SelectedIndex];
            DateTime time = DateTime.Now;
            float temperature = float.Parse(numericUpDownTemperature.Value.ToString(CultureInfo.InvariantCulture));
            int oximeter = int.Parse(numericUpDownOximeter.Value.ToString());
            int heartrate = int.Parse(numericUpDownHeartrate.Value.ToString());
            UpdateUserReadings(user, temperature, oximeter, heartrate);
            UpdateDataGridView();
        }

        void UpdateUserReadings(string user, float temperature, int oximeter, int heartrate)
        {
            if (userReadings.ContainsKey(user))
            {
                userReadings.Remove(user);
                userReadings.Add(user, new DailyReading() { Temperature = temperature, Oximeter = oximeter, Heartrate = heartrate });
            }
            else
            {
                userReadings.Add(user, new DailyReading() { Temperature = temperature, Oximeter = oximeter, Heartrate = heartrate });
            }
        }

        void UpdateDataGridView()
        {
            var dt = new DataTable();
            var datarows = new List<DataRow>();
            foreach (var item in userReadings)
            {
                dt.Columns.Add(item.Key);
            }
            var dr1 = dt.NewRow();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dr1[i] = userReadings[dt.Columns[i].ColumnName].Temperature;
            }
            dt.Rows.Add(dr1);
            var dr2 = dt.NewRow();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dr2[i] = userReadings[dt.Columns[i].ColumnName].Oximeter;
            }
            dt.Rows.Add(dr2);
            var dr3 = dt.NewRow();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dr3[i] = userReadings[dt.Columns[i].ColumnName].Heartrate;
            }
            dt.Rows.Add(dr3);
            dataGridViewUserReadings.DataSource = dt;
            for (int i = 0; i < parameters.Count; i++)
            {
                dataGridViewUserReadings.Rows[i].HeaderCell.Value = parameters[i];
                //dataGridViewUserReadings.Rows[i].HeaderCell.Value
            }
            foreach (DataGridViewColumn column in dataGridViewUserReadings.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void buttonSave2DB_Click(object sender, EventArgs e)
        {
            var time = DateTime.Now;
            time = DateTime.ParseExact(dateTimePickerReadingTime.Text, "yyyy-MM-dd hh:mm tt", CultureInfo.InvariantCulture);
            //if(timer == time)
            var messageBoxResponse = MessageBox.Show($"{time} Are you sure you want to save data?", "Confirmation",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            if (messageBoxResponse == DialogResult.Yes)
            {
                foreach (var userStats in userReadings)
                {
                    UserStatsData.Insert(new UserStats()
                    {
                        Time = time,
                        User = userStats.Key,
                        Temperature = userStats.Value.Temperature,
                        Oximeter = userStats.Value.Oximeter,
                        Heartrate = userStats.Value.Heartrate
                    });
                }
                MessageBox.Show("Data saved to DB");
            }
            pictureBoxRefresh_Click(null, null);
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            var usersData = UserStatsData.Get();
            var users = usersData.Select(x => x.User).Distinct();

            LineSeries lsTemperature = null;
            LineSeries lsOximeter = null;
            LineSeries lsHeartrate = null;

            var dayConfig = Mappers.Xy<DateModel>()
                .X(dateModel => dateModel.Time.Ticks / TimeSpan.FromSeconds(1).Ticks)
                .Y(dateModel => dateModel.Value);

            var seriesCollectionTemperature = new LiveCharts.SeriesCollection(dayConfig);
            var seriesCollectionOximeter = new LiveCharts.SeriesCollection(dayConfig);
            var seriesCollectionHeartrate = new LiveCharts.SeriesCollection(dayConfig);



            foreach (var user in users)
            {
                var temperatureChartValues = new ChartValues<DateModel>();
                var oximeterChartValues = new ChartValues<DateModel>();
                var heartrateChartValues = new ChartValues<DateModel>();

                var userDetails = usersData.Where(x => x.User == user);
                foreach (var ud in userDetails)
                {
                    temperatureChartValues.Add(new DateModel()
                    {
                        Time = ud.Time,
                        Value = ud.Temperature
                    });

                    oximeterChartValues.Add(new DateModel()
                    {
                        Time = ud.Time,
                        Value = ud.Oximeter
                    });

                    heartrateChartValues.Add(new DateModel()
                    {
                        Time = ud.Time,
                        Value = ud.Heartrate
                    });
                }

                lsTemperature = new LineSeries()
                {
                    Title = user,
                    PointGeometrySize = 5,
                    Values = temperatureChartValues,
                    Fill = new LinearGradientBrush()
                };
                lsOximeter = new LineSeries()
                {
                    Title = user,
                    PointGeometrySize = 5,
                    Values = oximeterChartValues,
                    Fill = new LinearGradientBrush()
                };
                lsHeartrate = new LineSeries()
                {
                    Title = user,
                    PointGeometrySize = 5,
                    Values = heartrateChartValues,
                    Fill = new LinearGradientBrush()
                };

                seriesCollectionTemperature.Add(lsTemperature);
                seriesCollectionOximeter.Add(lsOximeter);
                seriesCollectionHeartrate.Add(lsHeartrate);

            }

            if (seriesCollectionTemperature.Any())
            {
                TemperatureCartesianChart.Series.Clear();
                TemperatureCartesianChart.Series = seriesCollectionTemperature;
                TemperatureCartesianChart.LegendLocation = LegendLocation.Right;
                TemperatureCartesianChart.AxisX.Clear();
                TemperatureCartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    LabelFormatter = value => new DateTime((long)(value * TimeSpan.FromSeconds(1).Ticks)).ToString("MMM-dd HH:mm")
                });
            }
            if (seriesCollectionOximeter.Any())
            {
                oximeterCartesianChart.Series.Clear();
                oximeterCartesianChart.Series = seriesCollectionOximeter;
                oximeterCartesianChart.LegendLocation = LegendLocation.Right;
                oximeterCartesianChart.AxisX.Clear();
                oximeterCartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    LabelFormatter = value => new DateTime((long)(value * TimeSpan.FromSeconds(1).Ticks)).ToString("MMM-dd HH:mm")
                });
            }
            if (seriesCollectionHeartrate.Any())
            {
                heartrateCartesianChart.Series.Clear();
                heartrateCartesianChart.Series = seriesCollectionHeartrate;
                heartrateCartesianChart.LegendLocation = LegendLocation.Right;
                heartrateCartesianChart.AxisX.Clear();
                heartrateCartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    LabelFormatter = value => new DateTime((long)(value * TimeSpan.FromSeconds(1).Ticks)).ToString("MMM-dd HH:mm")
                });
            }
        }

        private void PictureBoxRefresh(List<string> chartUsers = null)
        {
            var usersData = UserStatsData.Get();
            var users = chartUsers;

            LineSeries lsTemperature = null;
            LineSeries lsOximeter = null;
            LineSeries lsHeartrate = null;

            var dayConfig = Mappers.Xy<DateModel>()
                .X(dateModel => dateModel.Time.Ticks / TimeSpan.FromSeconds(1).Ticks)
                .Y(dateModel => dateModel.Value);

            var seriesCollectionTemperature = new LiveCharts.SeriesCollection(dayConfig);
            var seriesCollectionOximeter = new LiveCharts.SeriesCollection(dayConfig);
            var seriesCollectionHeartrate = new LiveCharts.SeriesCollection(dayConfig);



            foreach (var user in users)
            {
                var temperatureChartValues = new ChartValues<DateModel>();
                var oximeterChartValues = new ChartValues<DateModel>();
                var heartrateChartValues = new ChartValues<DateModel>();

                var userDetails = usersData.Where(x => x.User == user);
                foreach (var ud in userDetails)
                {
                    temperatureChartValues.Add(new DateModel()
                    {
                        Time = ud.Time,
                        Value = ud.Temperature
                    });

                    oximeterChartValues.Add(new DateModel()
                    {
                        Time = ud.Time,
                        Value = ud.Oximeter
                    });

                    heartrateChartValues.Add(new DateModel()
                    {
                        Time = ud.Time,
                        Value = ud.Heartrate
                    });
                }

                lsTemperature = new LineSeries()
                {
                    Title = user,
                    PointGeometrySize = 5,
                    Values = temperatureChartValues,
                    Fill = new LinearGradientBrush()
                };
                lsOximeter = new LineSeries()
                {
                    Title = user,
                    PointGeometrySize = 5,
                    Values = oximeterChartValues,
                    Fill = new LinearGradientBrush()
                };
                lsHeartrate = new LineSeries()
                {
                    Title = user,
                    PointGeometrySize = 5,
                    Values = heartrateChartValues,
                    Fill = new LinearGradientBrush()
                };

                seriesCollectionTemperature.Add(lsTemperature);
                seriesCollectionOximeter.Add(lsOximeter);
                seriesCollectionHeartrate.Add(lsHeartrate);

            }

            if (seriesCollectionTemperature.Any())
            {
                TemperatureCartesianChart.Series.Clear();
                TemperatureCartesianChart.Series = seriesCollectionTemperature;
                TemperatureCartesianChart.LegendLocation = LegendLocation.Right;
                TemperatureCartesianChart.AxisX.Clear();
                TemperatureCartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    LabelFormatter = value => new DateTime((long)(value * TimeSpan.FromSeconds(1).Ticks)).ToString("MMM-dd HH:mm")
                });
            }
            if (seriesCollectionOximeter.Any())
            {
                oximeterCartesianChart.Series.Clear();
                oximeterCartesianChart.Series = seriesCollectionOximeter;
                oximeterCartesianChart.LegendLocation = LegendLocation.Right;
                oximeterCartesianChart.AxisX.Clear();
                oximeterCartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    LabelFormatter = value => new DateTime((long)(value * TimeSpan.FromSeconds(1).Ticks)).ToString("MMM-dd HH:mm")
                });
            }
            if (seriesCollectionHeartrate.Any())
            {
                heartrateCartesianChart.Series.Clear();
                heartrateCartesianChart.Series = seriesCollectionHeartrate;
                heartrateCartesianChart.LegendLocation = LegendLocation.Right;
                heartrateCartesianChart.AxisX.Clear();
                heartrateCartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    LabelFormatter = value => new DateTime((long)(value * TimeSpan.FromSeconds(1).Ticks)).ToString("MMM-dd HH:mm")
                });
            }
        }

        private void buttonRefreshUser_Click(object sender, EventArgs e)
        {
            List<string> userList = new List<string>();
            foreach (var item in listBoxChartUsers.SelectedItems)
            {
                userList.Add((string)(item));
            }
            PictureBoxRefresh(userList);
        }

        private void buttonDB_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.Show();
        }
    }
}
