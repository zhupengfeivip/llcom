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

namespace llcom.Pages {
    /// <summary>
    /// BaseConversion.xaml 的交互逻辑
    /// </summary>
    public partial class BaseConversion : Page {
        public BaseConversion() {
            InitializeComponent();
        }

        private void DecConvertButton_OnClick(object sender, RoutedEventArgs e) {
            if (DecTextBox.Text.Trim().Length <= 0)
                return;

            try {
                long dec = System.Convert.ToInt64(DecTextBox.Text.Trim());
                HexTextBox.Text = dec.ToString("X");

                SecTextBox.Text = System.Convert.ToString(dec, 2);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void HexConvertButton_OnClick(object sender, RoutedEventArgs e) {
            if (HexTextBox.Text.Trim().Length <= 0)
                return;

            try {
                long dec = System.Convert.ToInt64(HexTextBox.Text.Trim(), 16);
                DecTextBox.Text = dec.ToString();

                SecTextBox.Text = System.Convert.ToString(dec, 2);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void SecConvertButton_OnClick(object sender, RoutedEventArgs e) {
            if (SecTextBox.Text.Trim().Length <= 0)
                return;

            try {
                long dec = System.Convert.ToInt64(SecTextBox.Text.Trim(), 2);
                HexTextBox.Text = dec.ToString("X");
                DecTextBox.Text = dec.ToString();

                SecTextBox.Text = System.Convert.ToString(dec, 2);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
