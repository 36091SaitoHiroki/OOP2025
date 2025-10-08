﻿using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PrismObservesSample {
    class MainWindowViewModel : BindingBase {
        private string _input1 = "";
        public string Input1 {
            get => _input1;
            set => SetProperty(ref _input1, value);
        }

        private string _input2 = "";
        public string Input2 {
            get => _input2;
            set => SetProperty(ref _input2, value);
        }

        private string _result = "";
        public string Result {
            get => _result;
            set => SetProperty(ref _result, value);
        }

        public DelegateCommand SumCommand { get; }

        public MainWindowViewModel() {
            SumCommand = new DelegateCommand(ExcuteSum, canExcuteSum)
                .ObservesProperty(()=>Input1)
                .ObservesProperty(()=>Input2);
        }

        //足し算の処理
        private void ExcuteSum() {
            Result = int.Parse(Input1) + int.Parse(Input2).ToString();

        }

        private bool canExcuteSum() {
            return (int.TryParse(Input1, out _) && (int.TryParse(Input2, out _)));
        }
    }
}
