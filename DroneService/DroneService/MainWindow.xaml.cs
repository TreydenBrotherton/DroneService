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

namespace DroneService
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

        // --- Methods --- //

        // AddNewItem - Adds a new service item (Client Name, Drone Model, Service Problem & Service Cost)

        // GetServicePriority - Returns a value of the selected radio button (Regular or Express) (Must be called inside AddNewItem before adding)

        // RegularServiceDisplay - Displays the Regular Service queue to a list view

        // ExpressServiceDisplay - Displays the Express Service queue to a list view

        // IncrementServiceTag - Increments the service tag control (Must be called inside AddNewItem before adding)

        // ClearTextBoxes - Clears all text boxes (Used after a service item is added)

        // --- Buttons --- //

        // DeleteRegularItem - Deletes item from the Regular listview and dequeues the regular service queue (Dequeued items must be added to a finished list)

        // DeleteExpressItem - Deletes item from the Express listview and dequeues the Express service queue (Dequeued items must be added to a finished list)

        // DoubleClickRemove - Double click to remove item from finished listbox and remove the same item from the finished list

        // MouseClickRegularItem - Display client name & service problem in related text boxes for Regular items

        // MouseClickExpressItem - Display client name & service problem in related text boxes for Express items




    }
}
