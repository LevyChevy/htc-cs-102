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

namespace Week_4_Code_Along
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Movie> movieList;
        public MainWindow()
        {
            InitializeComponent();
            movieList = new List<Movie>();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Movie movie = new Movie(titleInput.Text, Convert.ToInt32(releaseYearInput.Text));

            movieList.Add(movie);

            titleInput.Clear();
            releaseYearInput.Clear();
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie movie in movieList)
            {
                movie.ShowDetails();
            }
        }
    }
}
