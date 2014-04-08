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

        private void Print(FlowDocument flowDoc)
        {
            Print((IDocumentPaginatorSource)flowDoc);
        }

        private void Print(IDocumentPaginatorSource paginatorSource)
        {
            // Get a print queue to print the document to.
            PrintQueue queue = GetPrintQueue();
            if (queue == null)
                return;

            // Create an XPS document writer.
            XpsDocumentWriter writer = PrintQueue.CreateXpsDocumentWriter(queue);
            
            // Write the document to the print queue in XPS format.
            writer.Write(paginatorSource.DocumentPaginator);

            MessageBox.Show("Printing complete.");
        }

        private PrintQueue GetPrintQueue()
        {
            // Create an instance of the printing dialog.
            PrintDialog dialog = new PrintDialog();
            
            // Return the PrintQueue for the printer selected in the dialog.
            if (dialog.ShowDialog().GetValueOrDefault())
                return dialog.PrintQueue;

            // Return null if the dialog was cancelled.
            return null;
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