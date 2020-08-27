using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using XFTest.Models;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services.Dialogs;
using XFTest.Services;
using System.Windows.Input;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using System.Linq;
using System;
using Xamarin.Essentials;

namespace XFTest.ViewModels
{
    public class CleaningListViewModel : BindableBase, INotifyPropertyChanged
    {

        private double previousLat1;
        private double previousLng1;
        private string month;
        private string moDay;
        private string tuDay;
        private string wedDay;
        private string thuDay;
        private string frDay;
        private string satDay;
        private string suDay;
        private string year;
        private bool show29;
        private bool show30;
        private bool show31;
        bool isRefreshing;
        private bool isShow1;
        private List<CleaningList> ccList1 = new List<CleaningList>();
        readonly IList<CleaningList> source;
        private IDataService _dataService;
        public static List<CleaningList> MyProperty;
        private ObservableCollection<CleaningList> monkeys;

        public ObservableCollection<CleaningList> Monkeys
        {
            get => monkeys;
            set
            {
                monkeys = value;
                OnPropertyChanged();
            }
        }

        public bool isShow
        {
            get => isShow1;
            set
            {
                isShow1 = value;
                OnPropertyChanged();
            }
        }

        public List<CleaningList> ccList
        {
            get => ccList1;
            set
            {
                ccList1 = value;
                OnPropertyChanged();
            }
        }

        public string Year
        {
            get => year;
            set
            {
                year = value;
                OnPropertyChanged();
            }
        }

        public string Month
        {
            get => month;
            set
            {
                month = value;
                OnPropertyChanged();
            }
        }

        public string MoDay
        {
            get => moDay;
            set
            {
                moDay = value;
                OnPropertyChanged();
            }
        }

        public string TuDay
        {
            get => tuDay;
            set
            {
                tuDay = value;
                OnPropertyChanged();
            }
        }

        public string WedDay
        {
            get => wedDay;
            set
            {
                wedDay = value;
                OnPropertyChanged();
            }
        }

        public string ThuDay
        {
            get => thuDay;
            set
            {
                thuDay = value;
                OnPropertyChanged();
            }
        }

        public string FrDay
        {

            get => frDay;
            set
            {
                frDay = value;
                OnPropertyChanged();
            }
        }

        public string SatDay
        {
            get => satDay;
            set
            {
                satDay = value;
                OnPropertyChanged();
            }
        }

        public string SuDay
        {
            get => suDay;
            set
            {
                suDay = value;
                OnPropertyChanged();
            }
        }

        public bool Show29
        {
            get => show29;
            set
            {
                show29 = value;
                OnPropertyChanged();
            }
        }

        public bool Show30
        {
            get => show30;
            set
            {
                show30 = value;
                OnPropertyChanged();
            }
        }

        public bool Show31
        {
            get => show31;
            set
            {
                show31 = value;
                OnPropertyChanged();
            }
        }

        public double previousLat
        {
            get => previousLat1;
            set
            {
                previousLat1 = value;
                OnPropertyChanged();
            }
        }

        public double previousLng
        {
            get => previousLng1;
            set
            {
                previousLng1 = value;
                OnPropertyChanged();
            }
        }

        public bool IsRefreshing
        {
            get => isRefreshing;
            set
            {
                isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        public ICommand Day01 { get; set; }
        public ICommand Day02 { get; set; }
        public ICommand Day03 { get; set; }
        public ICommand Day04 { get; set; }
        public ICommand Day05 { get; set; }
        public ICommand Day06 { get; set; }
        public ICommand Day07 { get; set; }
        public ICommand Day08 { get; set; }
        public ICommand Day09 { get; set; }
        public ICommand Day10 { get; set; }
        public ICommand Day11 { get; set; }
        public ICommand Day12 { get; set; }
        public ICommand Day13 { get; set; }
        public ICommand Day14 { get; set; }
        public ICommand Day15 { get; set; }
        public ICommand Day16 { get; set; }
        public ICommand Day17 { get; set; }
        public ICommand Day18 { get; set; }
        public ICommand Day19 { get; set; }
        public ICommand Day20 { get; set; }
        public ICommand Day21 { get; set; }
        public ICommand Day22 { get; set; }
        public ICommand Day23 { get; set; }
        public ICommand Day24 { get; set; }
        public ICommand Day25 { get; set; }
        public ICommand Day26 { get; set; }
        public ICommand Day27 { get; set; }
        public ICommand Day28 { get; set; }
        public ICommand Day29 { get; set; }
        public ICommand Day30 { get; set; }
        public ICommand Day31 { get; set; }

        public ICommand ShowDialogCommand { get; set; }
        public ICommand RefreshCommand { get; }

        public ICommand PreviousCommand { get; set; }
        public ICommand NextCommand { get; set; }

        //constructor
        public CleaningListViewModel(IDialogService dialogService, INavigationService navigationService, IDataService dataService)
        {
            _dataService = dataService;
            isShow = false;
            source = new List<CleaningList>();
            LoadJsonData();


            DateTime dt = DateTime.Now;
            int monthID = dt.Month;
            Year = dt.Year.ToString();
            Month = MonthName(monthID);

            //Danish days bind relevent day
            MoDay = ActiveDay(dt.Year, monthID, 1);
            TuDay = ActiveDay(dt.Year, monthID, 2);
            WedDay = ActiveDay(dt.Year, monthID, 3);
            ThuDay = ActiveDay(dt.Year, monthID, 4);
            FrDay = ActiveDay(dt.Year, monthID, 5);
            SatDay = ActiveDay(dt.Year, monthID, 6);
            SuDay = ActiveDay(dt.Year, monthID, 7);

            //show number of days relevent month
            int days = DateTime.DaysInMonth(dt.Year, monthID);
            if (days == 28)
            {
                Show29 = false;
                Show30 = false;
                Show31 = false;
            }
            else if (days == 29)
            {
                Show29 = true;
                Show30 = false;
                Show31 = false;

            }
            else if (days == 30)
            {
                Show29 = true;
                Show30 = true;
                Show31 = false;

            }
            else if (days == 31)
            {
                Show29 = true;
                Show30 = true;
                Show31 = true;
            }

            PreviousCommand = new Command(() => PreviousMonth());
            NextCommand = new Command(() => NextMonth());

            Day01 = new Command(() => ExecuteCommandDay01());
            Day02 = new Command(() => ExecuteCommandDay02());
            Day03 = new Command(() => ExecuteCommandDay03());
            Day04 = new Command(() => ExecuteCommandDay04());
            Day05 = new Command(() => ExecuteCommandDay05());
            Day06 = new Command(() => ExecuteCommandDay06());
            Day07 = new Command(() => ExecuteCommandDay07());
            Day08 = new Command(() => ExecuteCommandDay08());
            Day09 = new Command(() => ExecuteCommandDay09());
            Day10 = new Command(() => ExecuteCommandDay10());
            Day11 = new Command(() => ExecuteCommandDay11());
            Day12 = new Command(() => ExecuteCommandDay12());
            Day13 = new Command(() => ExecuteCommandDay13());
            Day14 = new Command(() => ExecuteCommandDay14());
            Day15 = new Command(() => ExecuteCommandDay15());
            Day16 = new Command(() => ExecuteCommandDay16());
            Day17 = new Command(() => ExecuteCommandDay17());
            Day18 = new Command(() => ExecuteCommandDay18());
            Day19 = new Command(() => ExecuteCommandDay19());
            Day20 = new Command(() => ExecuteCommandDay20());
            Day21 = new Command(() => ExecuteCommandDay21());
            Day22 = new Command(() => ExecuteCommandDay22());
            Day23 = new Command(() => ExecuteCommandDay23());
            Day24 = new Command(() => ExecuteCommandDay24());
            Day25 = new Command(() => ExecuteCommandDay25());
            Day26 = new Command(() => ExecuteCommandDay26());
            Day27 = new Command(() => ExecuteCommandDay27());
            Day28 = new Command(() => ExecuteCommandDay28());
            Day29 = new Command(() => ExecuteCommandDay29());
            Day30 = new Command(() => ExecuteCommandDay30());
            Day31 = new Command(() => ExecuteCommandDay31());

            RefreshCommand = new Command(ExecuteRefreshCommand);

            previousLat = 0;
            previousLng = 0;

            //current day parse for list filter method
            createList(Year + "-" + monthID.ToString("D2") + "-" + dt.Day.ToString("D2"));

        }

        //refresh method
        void ExecuteRefreshCommand()
        {
            Monkeys.Clear();
            Monkeys = new ObservableCollection<CleaningList>(ccList);

            // Stop refreshing
            IsRefreshing = false;
        }


        //return relevant Danish day name
        private string ActiveDay(int Y, int M, int D)
        {
            DateTime dt = new DateTime(Y, M, D);
            return DayName(dt.DayOfWeek.ToString());

        }

        //return Danish months
        private string MonthName(int monthID)
        {
            switch (monthID)
            {
                case 1: return "JAN";
                case 2: return "FEB";
                case 3: return "MAR";
                case 4: return "APR";
                case 5: return "MAJ";
                case 6: return "JUN";
                case 7: return "JUL";
                case 8: return "AUG";
                case 9: return "SEP";
                case 10: return "OKT";
                case 11: return "NOV";
                case 12: return "DEC";
                default: return null;
            }
        }

        //return month number
        private int MonthValue(string monthName)
        {
            switch (monthName)
            {
                case "JAN": return 1;
                case "FEB": return 2;
                case "MAR": return 3;
                case "APR": return 4;
                case "MAJ": return 5;
                case "JUN": return 6;
                case "JUL": return 7;
                case "AUG": return 8;
                case "SEP": return 9;
                case "OKT": return 10;
                case "NOV": return 11;
                case "DEC": return 12;
                default: return 0;
            }
        }

        //return Danish week days
        private string DayName(string dName)
        {
            switch (dName)
            {
                case "Monday": return "Ma";
                case "Tuesday": return "Ti";
                case "Wednesday": return "On";
                case "Thursday": return "To";
                case "Friday": return "Fr";
                case "Saturday": return "Lø";
                case "Sunday": return "Sø";
                default: return null;
            }
        }


        //handle next month
        private void NextMonth()
        {
            int id = MonthValue(Month);
            id = id + 1;
            int yearID = int.Parse(Year);
            if (id <= 12)
            {
                Month = MonthName(id);
                MoDay = ActiveDay(yearID, id, 1);
                TuDay = ActiveDay(yearID, id, 2);
                WedDay = ActiveDay(yearID, id, 3);
                ThuDay = ActiveDay(yearID, id, 4);
                FrDay = ActiveDay(yearID, id, 5);
                SatDay = ActiveDay(yearID, id, 6);
                SuDay = ActiveDay(yearID, id, 7);

                int days = DateTime.DaysInMonth(yearID, id);
                if (days == 28)
                {
                    Show29 = false;
                    Show30 = false;
                    Show31 = false;
                }
                else if (days == 29)
                {
                    Show29 = true;
                    Show30 = false;
                    Show31 = false;

                }
                else if (days == 30)
                {
                    Show29 = true;
                    Show30 = true;
                    Show31 = false;

                }
                else if (days == 31)
                {
                    Show29 = true;
                    Show30 = true;
                    Show31 = true;
                }
            }
        }

        //handle previous month
        private void PreviousMonth()
        {
            int id = MonthValue(Month);
            id = id - 1;
            int yearID = int.Parse(Year);
            if (id >= 1)
            {
                Month = MonthName(id);
                MoDay = ActiveDay(yearID, id, 1);
                TuDay = ActiveDay(yearID, id, 2);
                WedDay = ActiveDay(yearID, id, 3);
                ThuDay = ActiveDay(yearID, id, 4);
                FrDay = ActiveDay(yearID, id, 5);
                SatDay = ActiveDay(yearID, id, 6);
                SuDay = ActiveDay(yearID, id, 7);

                int days = DateTime.DaysInMonth(yearID, id);
                if (days == 28)
                {
                    Show29 = false;
                    Show30 = false;
                    Show31 = false;
                }
                else if (days == 29)
                {
                    Show29 = true;
                    Show30 = false;
                    Show31 = false;

                }
                else if (days == 30)
                {
                    Show29 = true;
                    Show30 = true;
                    Show31 = false;

                }
                else if (days == 31)
                {
                    Show29 = true;
                    Show30 = true;
                    Show31 = true;
                }
            }
        }

        //load json data
        private async void LoadJsonData()
        {

            var vv = await _dataService.GetBooks();
            MyProperty = vv.data;

            foreach (var item in MyProperty)
            {
                string mytitle = null;
                int sum = 0;
                if (item.tasks != null)
                {
                    foreach (var taskData in item.tasks)
                    {
                        if (!string.IsNullOrEmpty(mytitle))
                        {
                            mytitle = mytitle + " , " + taskData.title;
                        }
                        else
                        {
                            mytitle = taskData.title;
                        }


                        if (sum > 0)
                        {
                            sum = sum + int.Parse(taskData.timesInMinutes);
                        }
                        else
                        {
                            sum = int.Parse(taskData.timesInMinutes);
                        }

                    }
                }
                item.MyTitle = mytitle;
                item.SumTime = sum.ToString();
            }

            // Monkeys = new ObservableCollection<CleaningList>(MyProperty);

        }

        //click event 31 days
        #region 31days  
        private void ExecuteCommandDay01()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-01");//parse select date to createList methode


        }
        private void ExecuteCommandDay02()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-02");
        }
        private void ExecuteCommandDay03()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-03");
        }
        private void ExecuteCommandDay04()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-04");
        }
        private void ExecuteCommandDay05()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-05");
        }
        private void ExecuteCommandDay06()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-06");
        }
        private void ExecuteCommandDay07()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-07");
        }
        private void ExecuteCommandDay08()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-08");
        }
        private void ExecuteCommandDay09()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-09");
        }
        private void ExecuteCommandDay10()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-10");
        }
        private void ExecuteCommandDay11()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-11");
        }
        private void ExecuteCommandDay12()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-12");
        }
        private void ExecuteCommandDay13()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-13");
        }
        private void ExecuteCommandDay14()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-14");
        }
        private void ExecuteCommandDay15()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-15");
        }
        private void ExecuteCommandDay16()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-16");
        }
        private void ExecuteCommandDay17()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-17");
        }
        private void ExecuteCommandDay18()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-18");
        }
        private void ExecuteCommandDay19()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-19");
        }
        private void ExecuteCommandDay20()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-20");
        }
        private void ExecuteCommandDay21()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-21");
        }
        private void ExecuteCommandDay22()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-22");
        }
        private void ExecuteCommandDay23()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-23");
        }
        private void ExecuteCommandDay24()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-24");
        }
        private void ExecuteCommandDay25()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-25");
        }
        private void ExecuteCommandDay26()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-26");
        }
        private void ExecuteCommandDay27()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-27");
        }
        private void ExecuteCommandDay28()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-28");
        }
        private void ExecuteCommandDay29()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-29");
        }
        private void ExecuteCommandDay30()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-30");
        }
        private void ExecuteCommandDay31()
        {
            previousLat = 0;
            previousLng = 0;
            int clickMonth = MonthValue(Month);
            String SelectMonth = clickMonth.ToString("D2");
            createList(Year + "-" + SelectMonth + "-31");
        }
        #endregion

        //filter list using date
        private void createList(string value)
        {

            ccList = (from x in MyProperty where x.workDate == value select x).ToList();
            foreach (var item in ccList)
            {
                item.Distance = distance(previousLat, previousLng, double.Parse(item.houseOwnerLatitude), double.Parse(item.houseOwnerLongitude));

            }
            Monkeys = new ObservableCollection<CleaningList>(ccList);
        }


        //return distance between two point
        private string distance(double plat, double plng, double nlat, double nlng)
        {
            double distance = 0;
            if (plat != 0 && plng != 0)
            {
                var location = new Location(plat, plng);
                var otherLocation = new Location(nlat, nlng);
                distance = location.CalculateDistance(otherLocation, DistanceUnits.Kilometers);
                distance = Math.Round(distance, 1);
                previousLat = nlat;
                previousLng = nlng;
            }
            else
            {
                distance = 0;
                previousLat = nlat;
                previousLng = nlng;

            }
            return distance.ToString();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
