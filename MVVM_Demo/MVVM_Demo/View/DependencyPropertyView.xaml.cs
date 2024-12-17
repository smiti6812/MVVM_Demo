using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVM_Demo.View
{
    /// <summary>
    /// Interaction logic for DependencyProperty.xaml
    /// </summary>
    public partial class DependencyPropertyView : UserControl
    {
        public DependencyPropertyView()
        {
            InitializeComponent();
        }
        public static readonly DependencyProperty SetTextProperty =
          DependencyProperty.Register("SetText", typeof(string), typeof(DependencyPropertyView), new
             PropertyMetadata("", new PropertyChangedCallback(OnSetTextChanged)));

        public string SetText
        {
            get { return (string)GetValue(SetTextProperty); }
            set { SetValue(SetTextProperty, value); }
        }

        private static void OnSetTextChanged(DependencyObject d,
           DependencyPropertyChangedEventArgs e)
        {
            DependencyPropertyView UserControl1Control = d as DependencyPropertyView;
            UserControl1Control.OnSetTextChanged(e);
        }

        private void OnSetTextChanged(DependencyPropertyChangedEventArgs e)
        {
            tbTest.Text = e.NewValue.ToString();
        }
    }
}
