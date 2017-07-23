﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace YouTube
{
    /// <summary>
    /// QueueWindow.xaml 的互動邏輯
    /// </summary>
    public partial class QueueWindow : Window
    {
        public QueueWindow()
        {
            InitializeComponent();
            Process.OnEnqueue += Process_OnEnqueue;
            Process.OnDequeue += Process_OnDequeue;
            Process.OnQueueMove += Process_OnQueueMove;

            LBox.ItemsSource = Grids;
            RowDefinition GRow0 = new RowDefinition();
            RowDefinition GRow1 = new RowDefinition();
            ColumnDefinition GCol0 = new ColumnDefinition();
            GCol0.Width = new GridLength(2, GridUnitType.Star);
            ColumnDefinition GCol1 = new ColumnDefinition();
            GCol1.Width = new GridLength(1, GridUnitType.Star);
            TemplateGrid = new Grid();
            TemplateGrid.Height = 50;
            TemplateGrid.RowDefinitions.Add(GRow0);
            TemplateGrid.RowDefinitions.Add(GRow1);
            TemplateGrid.ColumnDefinitions.Add(GCol0);
            TemplateGrid.ColumnDefinitions.Add(GCol1);
            TemplateGrid.Margin = new Thickness(0);
        }

        Grid TemplateGrid = null;
        ObservableCollection<Grid> Grids = new ObservableCollection<Grid>();

        private void Process_OnEnqueue(Work w)
        {
            var G = TemplateGrid;
            SolidColorBrush BGBrush = null;
            switch (w.TaskType)
            {
                case Work.Type.Download:
                    BGBrush = new SolidColorBrush(Colors.LightPink);
                    break;
                case Work.Type.Convert:
                    BGBrush = new SolidColorBrush(Colors.LightBlue);
                    break;
                default:
                    throw new ArgumentNullException("Work type is null, apparently it shouldn't");
            }
            G.Background = BGBrush;
            Label NameLab = new Label();
            Label FormatQualityLab = new Label();
            Label StateLab = new Label();
            NameLab.Content = w.Name;
            FormatQualityLab.Content = w.OutputFormat.ToString() + "@" + w.Quality.ToString();
            StateLab.Content = w.TaskState.ToString();
            StateLab.HorizontalContentAlignment = HorizontalAlignment.Right;
            Grid.SetColumn(NameLab, 0);
            Grid.SetRow(NameLab, 0);
            Grid.SetColumn(FormatQualityLab, 0);
            Grid.SetRow(FormatQualityLab, 1);
            Grid.SetColumn(StateLab, 1);
            Grid.SetRow(StateLab, 1);
            G.Children.Add(NameLab);
            G.Children.Add(FormatQualityLab);
            G.Children.Add(StateLab);
            Grids.Add(G);
        }

        private void Process_OnDequeue(int ID)
        {
            throw new NotImplementedException();
        }

        private void Process_OnQueueMove(int OldID, int NewID)
        {
            throw new NotImplementedException();
        }
    }
}
