using System;
using System.Windows;
using System.Collections;

namespace DataBindingToCollectionsDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
                
        private IEnumerable GetCustomers()
        {
            yield return new Data.Customer 
            { 
                Age = 21, 
                CustomerID = Guid.NewGuid(), 
                FirstName = "Aaaa", 
                LastName = "Bbbbcccc" 
            };

            yield return new Data.Customer
            {
                Age = 31,
                CustomerID = Guid.NewGuid(),
                FirstName = "Cccc",
                LastName = "Ddbbcccc"
            };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource customerCollectionViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customerCollectionViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // customerCollectionViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource customerCollectionViewSource1 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customerCollectionViewSource1")));
            // Load data by setting the CollectionViewSource.Source property:
            // customerCollectionViewSource1.Source = [generic data source]

            customerCollectionViewSource.Source = GetCustomers();
        }
    }
}