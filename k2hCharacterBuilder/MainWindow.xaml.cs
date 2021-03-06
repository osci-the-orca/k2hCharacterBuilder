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
        Character character = new();
        Item item = new();
        //IDataManager<Item> dataManager;
        
        public MainWindow()
        {
            InitializeComponent();

            PopulateHeadCombo();
            PopulateArmorCombo();
            PopulateBeltCombo();
            PopulateLegsCombo();
            PopulateCapeCombo();

            PopulateWeaponCombo();
            PopulateShieldCombo();

            PopulateRingCombo();
            PopulateAmuleteCombo();

            strTextBox.TextChanged += UpdateLevel;
            endTextBox.TextChanged += UpdateLevel;
            agiTextBox.TextChanged += UpdateLevel;
            wisTextBox.TextChanged += UpdateLevel;
            intTextBox.TextChanged += UpdateLevel;

            WeaponComboBox.SelectionChanged += UpdateLevel;
            ShieldComboBox.SelectionChanged += UpdateLevel;
        }
 
        private void ClickPlusStr(object sender, MouseButtonEventArgs e)
        {
            character.Strength++;
            strTextBox.Text = character.Strength.ToString();    
        }

        private void ClickMinusStr(object sender, MouseButtonEventArgs e)
        {
            character.Strength--;
            strTextBox.Text = character.Strength.ToString();
        }

        private void ClickPlusEnd(object sender, MouseButtonEventArgs e)
        {
            character.Endurance++;
            endTextBox.Text = character.Endurance.ToString();  
        }

        private void ClickMinusEnd(object sender, MouseButtonEventArgs e)
        {
            character.Endurance--;
            endTextBox.Text = character.Endurance.ToString();
        }

        private void ClickPlusAgi(object sender, MouseButtonEventArgs e)
        {
            character.Agility++;
            agiTextBox.Text = character.Agility.ToString();
        }

        private void ClickMinusAgi(object sender, MouseButtonEventArgs e)
        {
            character.Agility--;
            agiTextBox.Text = character.Agility.ToString();
        }

        private void ClickPlusWis(object sender, MouseButtonEventArgs e)
        {
            character.Wisdom++;
            wisTextBox.Text = character.Wisdom.ToString();
        }

        private void ClickMinusWis(object sender, MouseButtonEventArgs e)
        {
            character.Wisdom--;
            wisTextBox.Text = character.ToString();
        }

        private void ClickPlusInt(object sender, MouseButtonEventArgs e)
        {
            character.Intelligence++;            
            intTextBox.Text = character.Intelligence.ToString();
        }

        private void ClickMinusInt(object sender, MouseButtonEventArgs e)
        {
            character.Intelligence++;
            intTextBox.Text = character.Intelligence.ToString();
        }

        private void UpdateLevel(object sender, EventArgs e)
        {
           
            levelTextBlock.Text = "Level: " + character.SetLevel().ToString();
            statpointsTextBlock.Text = "Stat points: " + character.SetStatpoint().ToString();

            //MeleeDmgTextBox.Text ="Melee dmg: " +  character.MeeleDmg.ToString();

            MeleeDmgTextBox.Text = "Melee dmg: " + character.MeeleDmg;

            RangeDmgTextBox.Text = "Range dmg: " + character.RangeDmg.ToString();

            ArmorClassTextBox.Text = "Armor class: " + character.ArmorClass.ToString();

            hpTextBlock.Text = "HP: " + character.TotalHp.ToString();
            mpTextBlock.Text = "MP: " + character.TotalMp.ToString();

            spTextBlock.Text = "SP: " + character.TotalStamina.ToString();
        }

        private void UpdateEquipment(object sender, SelectionChangedEventArgs e)
        {
            //MeleeDmgTextBox.Text = "Melee dmg: " + GetSelectedWeapon().AddStr.ToString();
            GetSelectedWeapon();
            GetSelectedOffHand();
        }

        
        private void PopulateWeaponCombo()
        {
            WeaponComboBox.ItemsSource = DataManager<Item>.LoadData().Where(item => item.Type == ItemType.Weapon);
        }

        private void PopulateShieldCombo()
        {
            ShieldComboBox.ItemsSource = DataManager<Item>.LoadData().Where(item => item.Type == ItemType.Shield);
        }

        private void PopulateArmorCombo()
        {
            ArmorComboBox.ItemsSource = DataManager<Item>.LoadData().Where(item => item.Type == ItemType.Shield);
        }

        private void PopulateHeadCombo()
        {
            HeadComboBox.ItemsSource = DataManager<Item>.LoadData().Where(item => item.Type == ItemType.Head);
        }

        private void PopulateBeltCombo()
        {
            BeltComboBox.ItemsSource = DataManager<Item>.LoadData().Where(item => item.Type == ItemType.Belt);
        }

        private void PopulateLegsCombo()
        {
            LegsComboBox.ItemsSource = DataManager<Item>.LoadData().Where(item => item.Type == ItemType.Legs);
        }
        private void PopulateCapeCombo()
        {
            CapeComboBox.ItemsSource = DataManager<Item>.LoadData().Where(item => item.Type == ItemType.Cape);
        }

        private void PopulateRingCombo()
        {
            RingComboBox.ItemsSource = DataManager<Item>.LoadData().Where(item => item.Type == ItemType.Ring);
        }

        private void PopulateAmuleteCombo()
        {
            AmuletComboBox.ItemsSource = DataManager<Item>.LoadData().Where(item => item.Type == ItemType.Amulet);
        }

        private Item GetSelectedWeapon()
        {
            character.Weapon = (Item)WeaponComboBox.SelectedValue;

            return character.Weapon;
        }

        private Item GetSelectedOffHand()
        {
            character.Shield = (Item)ShieldComboBox.SelectedValue;
            return character.Shield;
        }
    }
}
