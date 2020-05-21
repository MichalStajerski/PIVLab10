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

namespace Z_10
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Student SimpleStudent = new Student()
        {
            Id = 0,
            Name = "Jan",
            LastName = "Kowalski",
            EnlistingDate = new DateTime(2015,10,3)

        };

        List<Student> students = new List<Student>()
        {
            new Student()
            {
                Id = 0,
                Name = "Jan",
                LastName = "Kowalski",
                EnlistingDate = new DateTime(2015,10,3)
            },
            new Student()
            {
                Id = 1,
                Name = "Jan",
                LastName = "Nowak",
                EnlistingDate = new DateTime(2016,10,3)
            },
            new Student()
            {
                Id = 2,
                Name = "Jan",
                LastName = "Kwiatkowski",
                EnlistingDate = new DateTime(2017,10,3)
            },
            new Student()
            {
                Id = 3,
                Name = "Jan",
                LastName = "Smith",
                EnlistingDate = new DateTime(2018,10,3)
            }

        };

        public MainWindow()
        {
            InitializeComponent();
            Single.DataContext = SimpleStudent;
            
            t2.SetBinding(TextBox.TextProperty, new Binding("Name"));

            StudentLV.ItemsSource = students;
            StudentLB.ItemsSource = students;
        }

      
    }
}
