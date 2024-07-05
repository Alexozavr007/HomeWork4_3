using System.IO;
using System.IO.IsolatedStorage;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeWork4_3_4;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {

    const string fileName = "TextBox.txt";
    public MainWindow() {
        InitializeComponent();
    }

    private void btnSave_Click(object sender, RoutedEventArgs e) {
        IsolatedStorageFile userStorage = IsolatedStorageFile.GetUserStoreForAssembly();
        IsolatedStorageFileStream userStream = new IsolatedStorageFileStream(fileName, FileMode.Create, userStorage);
        StreamWriter userWriter = new StreamWriter(userStream);
        userWriter.WriteLine($"{txtUserInput.Text}");
        userWriter.Close();
    }

    private void btnLoad_Click(object sender, RoutedEventArgs e) {
        txtUserInput.Text = " ";

        IsolatedStorageFile userStorage = IsolatedStorageFile.GetUserStoreForAssembly();
        if (userStorage.FileExists(fileName)) {
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream(fileName, FileMode.Open, userStorage);
            StreamReader userReader = new StreamReader(userStream);
            txtUserInput.Text = userReader.ReadToEnd();
            userReader.Close();
        }
    }
}