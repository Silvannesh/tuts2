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
    }
}