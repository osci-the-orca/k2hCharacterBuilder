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

namespace k2hCharacterBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        public MainWindow()
        {
            InitializeComponent();
        }

        private int strength = 0;
        private int endurance = 0;
        private int agility = 0;
        private int wisdom = 0;
        private int intelligence = 0;

        private int statpoint = 25;

        private void ClickPlusStr(object sender, MouseButtonEventArgs e)
        {
            strength++;
            statpoint--;
            strTextBox.Text = strength.ToString();
            AvailableStatPts.Text = statpoint.ToString();
        }

        private void ClickMinusStr(object sender, MouseButtonEventArgs e)
        {
            strength--;
            statpoint++;
            strTextBox.Text = strength.ToString();
            AvailableStatPts.Text = statpoint.ToString();
        }

        private void ClickPlusEnd(object sender, MouseButtonEventArgs e)
        {
            endurance++;
            statpoint--;
            endTextBox.Text = endurance.ToString();
            AvailableStatPts.Text = statpoint.ToString();
        }

        private void ClickMinusEnd(object sender, MouseButtonEventArgs e)
        {
            endurance--;
            statpoint++;
            endTextBox.Text = endurance.ToString();
            AvailableStatPts.Text = statpoint.ToString();
        }

        private void ClickPlusAgi(object sender, MouseButtonEventArgs e)
        {
            agility++;
            statpoint--;
            agiTextBox.Text = agility.ToString();
            AvailableStatPts.Text = statpoint.ToString();
        }

        private void ClickMinusAgi(object sender, MouseButtonEventArgs e)
        {
            agility--;
            statpoint++;
            agiTextBox.Text = agility.ToString();
            AvailableStatPts.Text = statpoint.ToString();
        }

        private void ClickPlusWis(object sender, MouseButtonEventArgs e)
        {
            wisdom++;
            statpoint--;
            wisTextBox.Text = wisdom.ToString();
            AvailableStatPts.Text = statpoint.ToString();
        }

        private void ClickMinusWis(object sender, MouseButtonEventArgs e)
        {
            wisdom--;
            statpoint++;
            wisTextBox.Text = wisdom.ToString();
            AvailableStatPts.Text = statpoint.ToString();
        }

        private void ClickPlusInt(object sender, MouseButtonEventArgs e)
        {
            intelligence++;
            statpoint--;
            intTextBox.Text = intelligence.ToString();
            AvailableStatPts.Text = statpoint.ToString();
        }

        private void ClickMinusInt(object sender, MouseButtonEventArgs e)
        {
            intelligence--;
            statpoint++;
            intTextBox.Text = intelligence.ToString();
            AvailableStatPts.Text = statpoint.ToString();
        }

        private decimal currentLevel = 0;

        private void UpdateLevel(object sender, TextChangedEventArgs e)
        {
           decimal sumOfStats = strength + endurance + agility + wisdom + intelligence;

            if (sumOfStats <= 25)
            {
                currentLevel = 1;
                CurrentLevelTextBlock.Text = currentLevel.ToString();
            }

            else if (sumOfStats > 25)
            {
                currentLevel = Math.Ceiling(1 + (sumOfStats - 25) / 3);
                CurrentLevelTextBlock.Text = currentLevel.ToString();
                AvailableStatPts.Text = statpoint.ToString();
            }

            statpoint = (((Convert.ToInt32(currentLevel - 1)) * 3)+25) - Convert.ToInt32(sumOfStats);
            AvailableStatPts.Text = statpoint.ToString();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                strength = Convert.ToInt32(strTextBox.Text);
                endurance = Convert.ToInt32(endTextBox.Text);
                agility = Convert.ToInt32(agiTextBox.Text);
                wisdom = Convert.ToInt32(wisTextBox.Text);
                intelligence = Convert.ToInt32(intTextBox.Text);
            }
        }
    }
}
