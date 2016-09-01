using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IQTests
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            List<Answers> Answers = new List<Answers>();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                       
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }
    }
    public class Answers
    {
        char A { get; set; }
        char B { get; set; }
        char C { get; set; }
        char D { get; set; }
    }
    public class Tests
    {
        public string questionImage { get; set; }
        public string answerImage1 { get; set; }
        public string answerImage2 { get; set; }
        public string answerImage3 { get; set; }
        public string answerImage4 { get; set; }
        public string questionText { get; set; }
        public string answerText1 { get; set; }
        public string answerText2 { get; set; }
        public string answerText3 { get; set; }
        public string answerText4 { get; set; }

    }
}