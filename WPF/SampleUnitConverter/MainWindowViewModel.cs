using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter{
    internal class MainWindowViewModel : ViewModel{

        //フィールド
        private double metricValue;
        private double imperiaValue;

        public ICommand ImperialUnitToMetric { get;private set; }

        public ICommand MetricToImperialUnit { get; private set; }

        public MetricUnit CurrentMetricUnit { get; set; }

        public ImperialUnit CurrentImperialUnit { get; set; }

        //プロパティ
        public double MetricValue {
            get => metricValue;
            set => SettingsProperty(ref metricValue,value);

        }

        public double ImperiaValue {
            get => imperiaValue;
            set => SettingsProperty(ref imperiaValue, value);
        
        }

        public MainWindowViewModel() {
            CurrentMetricUnit = MetricUnit.Units.First();
            CurrentImperialUnit = ImperialUnit.Units.First();


            ImperialUnitToMetric = new DelegateCommand(
                () => MetricValue = CurrentMetricUnit.FromImperialUnit(
                    CurrentImperialUnit,ImperiaValue));

            MetricToImperialUnit = new DelegateCommand(
                () => ImperiaValue = CurrentImperialUnit.FromMetriclUnit(
                    CurrentMetricUnit,MetricValue));
        }
    }
}