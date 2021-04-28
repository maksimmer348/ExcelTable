using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
using ExcelTable.ViewModel;
using Microsoft.Win32;
using OfficeOpenXml;

namespace ExcelTable
{
    public partial class MainWindow : Window
    {
        //Хотя окно(класс Window) в WPF может содержать как интерфейс в xaml, так и привязанный к нему код C#,
        //однако в идеале код C# не должен содержать какой-то логики, кроме разве что конструктора, который вызывает метод
        //InitializeComponent и выполняет начальную инициализацию окна. Вся же основная логика приложения выносится в
        //компонент ViewModel.
        public MainWindow()
        {
            InitializeComponent();
        }

        //Однако иногда в файле связанного кода все может находиться некоторая логика, которую трудно реализовать в рамках паттерна MVVM во ViewModel.
        //Представление не обрабатывает события за редким исключением, а выполняет действия в основном посредством команд.

    }
}

