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

namespace griddata
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List<DataGridContent> std = new List<DataGridContent>();

		public MainWindow()
		{
			InitializeComponent();

			std.Add(new DataGridContent() {  Name = "Harini ", Birthday = "09-11-1998", Gender="Female"});
			std.Add(new DataGridContent() {  Name = "Chandana", Birthday = "14-09-1998", Gender = "Female" });
			std.Add(new DataGridContent() {  Name = "Anjali", Birthday = "20-02-1999", Gender = "Female" });
			std.Add(new DataGridContent() {  Name = "Binitta", Birthday = "24-11-1998", Gender = "Female" });

			Student.ItemsSource = std;

			//List<string> list = new List<string>();
			//list.Add("Male");
			//list.Add("Female");

			//gender.ItemsSource = list;

		}
        private void button_Click(object sender, RoutedEventArgs e)
        {
			foreach(DataGridContent dgc in std)
            {
				if(dgc.IsSelected == true)
                {
					string message = $"Hi This is { dgc.Name} wish me on {dgc.Birthday}";
					listbox.Items.Add(message);
                }
            }

		}
    }
    public class Student
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Birthday { get; set; }

		public string Gender { get; set; }

	}
	public class DataGridContent
    {
		public string Name { get; set; }
		public string Birthday { get; set; }
		public string Gender { get; set; }

		public bool IsSelected { get; set; }
    }
}
