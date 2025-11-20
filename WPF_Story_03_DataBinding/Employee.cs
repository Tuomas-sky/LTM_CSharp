using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Story_03_DataBinding
{
    public class Employee:INotifyPropertyChanged
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { 
				_name = value;
				//属性值变更后，激发ProrertyChanged事件，arg1 事件来源，args2 属性变更事件参数
				//判断有无订阅，避免空事件异常
				if(PropertyChanged != null)
				{
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
			}
		}


		public event PropertyChangedEventHandler PropertyChanged;
    }
}
