using System;
using System.Printing; // in System.Printing.dll assembly, contains PrintQueue and XpsDocumentWriter
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Xps;

namespace PrintingDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region /* Event Handlers */

        private void buttonPrintFixed_Click(object sender, RoutedEventArgs e)
        {
            // Print a fixed document.
            Print(viewerContent.Document);
        }

        private void buttonPrintFlow_Click(object sender, RoutedEventArgs e)
        {
            // Print a flow document.
            Print(textboxContent.Document);
        }

        #endregion 
    }
}