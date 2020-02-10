using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _301028454_Martins_Lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<CheckOut> checkouts = new ObservableCollection<CheckOut>();

        // list of items in the menu
        public Menu menu = new Menu();
        List<CheckOut> beverages;
        List<CheckOut> appetizers;
        List<CheckOut> mainCourse;
        List<CheckOut> desserts;

        double subtotal = 0;
        double total = 0;
        string comboBoxValue;
        public MainWindow()
        {
            InitializeComponent();
            InitializeBeverageComboBox();
            InitializeAppetizerComboBox();
            InitializeMainCourseComboBox();
            InitializeDessertComboBox();
        }
        public void InitializeBeverageComboBox()
        {
            beverages = menu.ReturnBeverages();
            foreach (CheckOut items in beverages)
            {
                beveragesCmbBx.Items.Add(items.ItemName + items.ItemPrice);
            }
        }

        public void InitializeAppetizerComboBox()
        {
            appetizers = menu.ReturnAppetizers();
            foreach (CheckOut items in appetizers)
            {
                appetizersCmbBx.Items.Add(items.ItemName + items.ItemPrice);
            }
        }

        public void InitializeMainCourseComboBox()
        {
            mainCourse = menu.ReturnMainCourse();

            foreach (CheckOut items in mainCourse)
            {
                mainCourseCmbBx.Items.Add(items.ItemName + items.ItemPrice);
            }          
        }

        public void InitializeDessertComboBox()
        {
            desserts = menu.ReturnDessert();
            foreach (CheckOut items in desserts)
            {
                dessertsCmbBx.Items.Add(items.ItemName + items.ItemPrice);
            }
        }

        private void BeveragesCmbBx_DropDownClosed(object sender, EventArgs e)
        {
            //add a beverages item to the instance of a checkout object of items
            if (beveragesCmbBx.SelectedIndex > -1)
            {
                comboBoxValue = beveragesCmbBx.Text;
                bool existItem = false;

                mydg.ItemsSource = checkouts;
                foreach(CheckOut items in beverages.Where(s => s.ItemName + s.ItemPrice == comboBoxValue))
                {
                    foreach (var duplicate in checkouts)
                    {
                        if (duplicate.ItemName == items.ItemName)
                        {
                            existItem = true;
                            duplicate.Quantity++;
                            mydg.Items.Refresh();
                        }
                    }
                    if (!existItem)
                    {
                        checkouts.Add(items);
                    }
                    subtotal += items.CalculateSubTotal();
                    subTotalTxt.Text = string.Format("{0:C2}",subtotal);
                    taxTxt.Text = string.Format("{0:C2}",items.CalculateTax(subtotal));
                    total = items.CalculateTotal(subtotal);
                    totalTxt.Text = string.Format("{0:C2}", total);
                }
            }
            ClearComboBox();
        }

        private void AppetizersCmbBx_DropDownClosed(object sender, EventArgs e)
        {

            //add a appetizer item to the instance of a checkout object of items
            if (appetizersCmbBx.SelectedIndex > -1)
            {
                comboBoxValue = appetizersCmbBx.Text;
                bool existItem = false;
                mydg.ItemsSource = checkouts;
                foreach (CheckOut items in appetizers.Where(s => s.ItemName + s.ItemPrice == comboBoxValue))
                {
                    foreach (var duplicate in checkouts)
                    {
                        if (duplicate.ItemName == items.ItemName)
                        {
                            existItem = true;
                            duplicate.Quantity++;
                            mydg.Items.Refresh();
                        }
                    }
                    if (!existItem)
                    {
                        checkouts.Add(items);
                    }
                    subtotal += items.CalculateSubTotal();
                    subTotalTxt.Text = string.Format("{0:C2}", subtotal);
                    taxTxt.Text = string.Format("{0:C2}", items.CalculateTax(subtotal));
                    total = items.CalculateTotal(subtotal);
                    totalTxt.Text = string.Format("{0:C2}", total);
                }
                ClearComboBox();
            }
        }

        private void MainCourseCmbBx_DropDownClosed(object sender, EventArgs e)
        {
            //add a main course item to the instance of a checkout object of items
            if (mainCourseCmbBx.SelectedIndex > -1)
            {
                comboBoxValue = mainCourseCmbBx.Text;
                bool existItem = false;
                mydg.ItemsSource = checkouts;
                foreach (CheckOut items in mainCourse.Where(s => s.ItemName + s.ItemPrice == comboBoxValue))
                {
                    foreach (var duplicate in checkouts)
                    {
                        if (duplicate.ItemName == items.ItemName)
                        {
                            existItem = true;
                            duplicate.Quantity++;
                            mydg.Items.Refresh();
                        }
                    }
                    if (!existItem)
                    {
                        checkouts.Add(items);
                    }
                    subtotal += items.CalculateSubTotal();
                    subTotalTxt.Text = string.Format("{0:C2}", subtotal);
                    taxTxt.Text = string.Format("{0:C2}", items.CalculateTax(subtotal));
                    total = items.CalculateTotal(subtotal);
                    totalTxt.Text = string.Format("{0:C2}", total);
                }
                ClearComboBox();
            }
        }

        private void DessertsCmbBx_DropDownClosed(object sender, EventArgs e)
        {
            //add a dessert item to the instance of a checkout object of items
            if (dessertsCmbBx.SelectedIndex > -1)
            {
                comboBoxValue = dessertsCmbBx.Text;
                bool existItem = false;
                mydg.ItemsSource = checkouts;
                foreach (CheckOut items in desserts.Where(s => s.ItemName + s.ItemPrice == comboBoxValue))
                {
                    foreach (var duplicate in checkouts)
                    {
                        if (duplicate.ItemName == items.ItemName)
                        {
                            existItem = true;
                            duplicate.Quantity++;
                            mydg.Items.Refresh();
                        }
                    }
                    if (!existItem)
                    {
                        checkouts.Add(items);
                    }
                    subtotal += items.CalculateSubTotal();
                    subTotalTxt.Text = string.Format("{0:C2}", subtotal);
                    taxTxt.Text = string.Format("{0:C2}", items.CalculateTax(subtotal));
                    total = items.CalculateTotal(subtotal);
                    totalTxt.Text = string.Format("{0:C2}", total);
                }
                ClearComboBox();    
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            //clear all comboboxes 
            ClearComboBox();
            
            taxTxt.Clear();
            subTotalTxt.Clear();
            totalTxt.Clear();
            checkouts.Clear();
            subtotal = 0;
            mydg.ItemsSource = checkouts;            
        }

        private void ClearComboBox()
        {
            beveragesCmbBx.SelectedItem = null;
            appetizersCmbBx.SelectedItem = null;
            mainCourseCmbBx.SelectedItem = null;
            dessertsCmbBx.SelectedItem = null;
        }
        private void Mydg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
               subtotal = 0;

                foreach (var items in checkouts)
                {
                    subtotal += items.ItemPrice * items.Quantity;
                    subTotalTxt.Text = string.Format("{0:C2}", subtotal);
                    taxTxt.Text = string.Format("{0:C2}", items.CalculateTax(subtotal));
                    total = items.CalculateTotal(subtotal);
                    totalTxt.Text = string.Format("{0:C2}", total);
                }
        }

        private void RemoveItemBtn_Click(object sender, RoutedEventArgs e)
        {
            if (mydg.SelectedIndex > -1)
            {
                CheckOut selectedItem = checkouts.ElementAt(mydg.SelectedIndex);
                subtotal -= selectedItem.ItemPrice * selectedItem.Quantity;
                subTotalTxt.Text = string.Format("{0:C2}", subtotal);
                taxTxt.Text = string.Format("{0:C2}", selectedItem.CalculateTax(subtotal));
                total = selectedItem.CalculateTotal(subtotal);
                totalTxt.Text = string.Format("{0:C2}", total);
                checkouts.RemoveAt(mydg.SelectedIndex);
            }
        }

        private void ReciptBtn_Click(object sender, RoutedEventArgs e)
        {
            FlowDocument recipt = CreateFlowDocument();
            IDocumentPaginatorSource idpSource = recipt;
            PrintDialog printDialog = new PrintDialog();
            printDialog.PrintDocument(idpSource.DocumentPaginator, "Creating Invoce...");
        }

        private FlowDocument CreateFlowDocument()
        {
            // Create a FlowDocument  
            FlowDocument doc = new FlowDocument();
            // Create a Section  
            Section sec = new Section();
            // Create first Paragraph  
            Paragraph paragraph = new Paragraph();

            paragraph.Inlines.Add("***********************************\n");
            paragraph.Inlines.Add("*                     I N V O I C E                    *\n");
            paragraph.Inlines.Add("***********************************\n\n\n");
            paragraph.Inlines.Add("Item Name      Quantity      Unit Price\n\n");

            foreach (var items in checkouts)
            {
                paragraph.Inlines.Add(items.ItemName + "\t"+ items.Quantity + "\t"+ items.ItemPrice + "\n");
            }

            paragraph.Inlines.Add("\n\n\n\n\nSubtotal.......:  " + subTotalTxt.Text + "\n");
            paragraph.Inlines.Add("Tax HST........:  " + taxTxt.Text + "\n");
            paragraph.Inlines.Add("Total..........:  " + totalTxt.Text);

            sec.Blocks.Add(paragraph);
            doc.Blocks.Add(sec);
            return doc;
        }

        private void Mydg_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "ItemPrice")
            {
                (e.Column as DataGridTextColumn).Binding.StringFormat = "c";
            }
        }
    }
}
