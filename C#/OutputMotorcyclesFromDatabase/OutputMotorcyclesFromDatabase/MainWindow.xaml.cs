using OutputMotorcyclesFromDatabase.Entities;
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

namespace OutputMotorcyclesFromDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int ProductOnPage = 1;

        private int NumberOfPage = 0;

        private string NameActiveButton;
        public MainWindow()
        {
            InitializeComponent();

            PreviousButton.Content = "<";
            NextButton.Content = ">";
            OneProductButton_Click(new object(), new());
        }
        
        private void Update(int skip, int count)
        {
            using (Db db = new Db())
            {
                OutputProductControl.ItemsSource = db.Motorcycles.Skip(skip).Take(count).ToList();
            }
        }
        
        private void ChangeButtonsToTransition(bool isEnable, Visibility visibility)
        {
            NextButton.IsEnabled = isEnable;
            NextButton.Visibility = visibility;

            PreviousButton.IsEnabled = isEnable;
            PreviousButton.Visibility = visibility;
        }
        
        private void ChangeScrollViewer(ScrollBarVisibility visibility)
        {
            ScrollView.VerticalScrollBarVisibility = visibility;
        }
        
        private void UpdateModeButtons(string name)
        {
            Button[] buttons = new Button[] { OneProductButton, FourProductButton, AllProductButton };

            foreach (var b in buttons)
            {
                b.IsEnabled = true;
                if(b.Name == name)
                {
                    b.IsEnabled = true;
                }
                
            }
            

            
        }
        private void OneProductButton_Click(object sender, RoutedEventArgs e)
        {
            NameActiveButton = "OneProductButton";
            UpdateModeButtons(NameActiveButton);
            ChangeScrollViewer(ScrollBarVisibility.Hidden);
            ChangeButtonsToTransition(true, Visibility.Visible);
            ProductOnPage = 1;
            NumberOfPage = 0;
            Update(NumberOfPage, ProductOnPage);
        }

        private void FourProductButton_Click(object sender, RoutedEventArgs e)
        {
            NameActiveButton = "FourProductButton_Click";
            UpdateModeButtons(NameActiveButton);
            ChangeScrollViewer(ScrollBarVisibility.Visible);
            ChangeButtonsToTransition(true, Visibility.Visible);
            ProductOnPage = 4;
            NumberOfPage = 0;
            Update(NumberOfPage, ProductOnPage);
        }

        private void AllProductButton_Click(object sender, RoutedEventArgs e)
        {
            NameActiveButton = "AllProductButton_Click";
            UpdateModeButtons(NameActiveButton);
            ChangeScrollViewer(ScrollBarVisibility.Visible);
            ChangeButtonsToTransition(false, Visibility.Hidden);
            
            using(Db db = new Db())
            {
                ProductOnPage = db.Motorcycles.Count();
            }
            NumberOfPage = 0;
            Update(NumberOfPage, ProductOnPage);
        
        }
        
        private int GetMaxCountOfPage()
        {
            int countOfMotorcycles;
            using (Db db = new Db())
            {
                countOfMotorcycles = db.Motorcycles.Count();
            }
            if (NameActiveButton == "AllProductButton")
            {
                return 1;
            }
            if(NameActiveButton == "OneProductButton")
            {
                return countOfMotorcycles;
            }

            if (countOfMotorcycles % 4 != 0)
            {
                return (countOfMotorcycles / 4) + 1;
            }
            else
            {
                return countOfMotorcycles / 4;
            }
        }
        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            if(NumberOfPage == 0)
            {
                return;
            }
            NumberOfPage -= ProductOnPage;
            Update(NumberOfPage, ProductOnPage);
        }
        
        private int GetCountOfLastPageInModeFour()
        {
            int countOfMotorcycles;
            using (Db db = new Db())
            {
                countOfMotorcycles = db.Motorcycles.Count();
            }
            return countOfMotorcycles - (countOfMotorcycles % 4);
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (NumberOfPage + 1 == GetMaxCountOfPage())
            {
                return;
            }
            if(NameActiveButton == "FourProductButton" && NumberOfPage == GetCountOfLastPageInModeFour())
            {
                return;
            }
            NumberOfPage += ProductOnPage;
            Update(NumberOfPage, ProductOnPage);
        }
    }
}
