using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace SleepCalculator
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void PropertyChangedInvoker(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _wakeUpTime;
        public string WakeUpTime 
        {
            get { return _wakeUpTime; }
            set 
            { 
                _wakeUpTime = value;
                PropertyChangedInvoker("GoSleepTime");
            }
        }

        public string GoSleepTime
        {
            get { return SleepCyclesCalculator.GetGoSleepTime(WakeUpTime); }
            set
            {
                _wakeUpTime = value;
                PropertyChangedInvoker("GoSleepTime");
            }
        }
    }
}
