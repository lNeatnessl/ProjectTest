using System.Windows;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using System;
using System.Windows.Media;
using DevExpress.Xpf.LayoutControl;
using System.Linq;
using System.Windows.Controls;

namespace Solra
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            this.Loaded += LoadEvent;
            //GridSetting();


        }

        void GridSetting()
        {
            
            //Grid Setting

            

            //Grid DynamicGrid = new Grid();

            //this.AddChild(DynamicGrid);
            
            ////DynamicGrid.Width = 800;
            //DynamicGrid.HorizontalAlignment = HorizontalAlignment.Stretch;
            //DynamicGrid.VerticalAlignment = VerticalAlignment.Stretch;
            //DynamicGrid.ShowGridLines = true;
            //DynamicGrid.Background = new SolidColorBrush(Colors.White);

            //ColumnDefinition Col1 = new ColumnDefinition();
            //ColumnDefinition Col2 = new ColumnDefinition();
            //ColumnDefinition Col3 = new ColumnDefinition();            

            //DynamicGrid.ColumnDefinitions.Add(Col1);
            //DynamicGrid.ColumnDefinitions.Add(Col2);
            //DynamicGrid.ColumnDefinitions.Add(Col3);

            //RowDefinition Row1 = new RowDefinition();
            //Row1.Height = new GridLength(4, GridUnitType.Star);
            //RowDefinition Row2 = new RowDefinition();
            //Row1.Height = new GridLength(1, GridUnitType.Star);

            //DynamicGrid.RowDefinitions.Add(Row1);
            //DynamicGrid.RowDefinitions.Add(Row2);

            

            TileLayoutControl TLC1 = new TileLayoutControl();


            DynamicGrid.Children.Add(TLC1);

            //TileLayoutControl TLC2 = new TileLayoutControl();
            //TileLayoutControl TLC3 = new TileLayoutControl();
            //TileLayoutControl TLC4 = new TileLayoutControl();

            TileLayoutControl Test = new TileLayoutControl();
            //Grid.SetRow(TLC1, 0);
            
            //Grid.SetRow(TLC2, 0);
            //Grid.SetColumn(TLC2, 1);
            //Grid.SetRow(TLC3, 2);
            //Grid.SetColumn(TLC3, 2);
            //Grid.SetRow(TLC4, 1);
            //Grid.SetRowSpan(TLC4, 2);
            //Grid.SetColumnSpan(TLC4, 3);

            

            

            
            //DynamicGrid.Children.Add(TLC2);
            //DynamicGrid.Children.Add(TLC3);
            //DynamicGrid.Children.Add(TLC4);

            //Group1
            Tile G1Tile1 = new Tile() { Header = "Tile", Name = "G1Tile1", Size = TileSize.Large };
            Tile G1Tile2 = new Tile() { Header = "Tile", Name = "G1Tile2", Size = TileSize.Small };
            //Tile G1Tile3 = new Tile() { Header = "Tile", Name = "G1Tile3", Size = TileSize.Small };
            //Tile G1Tile4 = new Tile() { Header = "Tile", Name = "G1Tile4", Size = TileSize.Small };
            //Tile G1Tile5 = new Tile() { Header = "Tile", Name = "G1Tile5", Size = TileSize.Small };

            G1Tile1.SetValue(TileLayoutControl.GroupHeaderProperty, TLC1);
            G1Tile2.SetValue(TileLayoutControl.GroupHeaderProperty, TLC1);
            //G1Tile3.SetValue(TileLayoutControl.GroupHeaderProperty, TLC1);
            //G1Tile4.SetValue(TileLayoutControl.GroupHeaderProperty, TLC1);
            //G1Tile5.SetValue(TileLayoutControl.GroupHeaderProperty, TLC1);
            TLC1.Children.Add(G1Tile1);
            TLC1.Children.Add(G1Tile2);
            //TLC1.Children.Add(G1Tile3);
            //TLC1.Children.Add(G1Tile4);
            //TLC1.Children.Add(G1Tile5);
        }

        void LoadEvent(object sender, EventArgs e)
        {

            

            //Group2
            
        }

        public List<Agent> Agents { get { return Solra.Agents.DataSource; } }
    }

    public class Agent
    {
        public string AgentName { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }
        public ImageSource PhotoSource
        {
            get
            {
                return string.IsNullOrEmpty(Photo) ? null : new BitmapImage(new Uri(Photo, UriKind.Relative));
            }
        }
    }

    public static class Agents
    {
        public static readonly List<Agent> DataSource =
            new List<Agent> {
                new Agent { AgentName = "Anthony Peterson", Phone = "(555) 444-0782", Photo = "Icon/Weather-thunder.png" },
                new Agent { AgentName = "Rachel Scott", Phone = "(555) 249-1614", Photo = "Icon/Radioactive.png" },
                new Agent { AgentName = "Albert Walker", Phone = "(555) 232-2303", Photo = "Icon/Warning.png" }
            };
    }
}
