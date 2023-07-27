using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MultiLevelMasterDetail {
    public class MainViewModel : ViewModelBase {
        public MainViewModel() {
            Items = new ObservableCollection<MasterLevelItem>();
            InitMasterItems();
            CurrentMasterItem = null;
        }
        public ObservableCollection<MasterLevelItem> Items { get; private set; }
        public MasterLevelItem CurrentMasterItem { get { return GetValue<MasterLevelItem>(); } set { SetValue(value); } }
        public DetailLevelItem CurrentDetailItem { get { return GetValue<DetailLevelItem>(); } set { SetValue(value); } }

        void InitMasterItems() {
            for(int i = 0; i < 10; i++) {
                Items.Add(new MasterLevelItem() {
                    MasterId = i,
                    MasterName = String.Format("master item {0}", i),
                });
            }
        }
    }

    public class MasterLevelItem {
        public int MasterId { get; set; }
        public string MasterName { get; set; }
        public List<DetailLevelItem> DetailItems { get; set; }
        public MasterLevelItem() {
            DetailItems = new List<DetailLevelItem>();
            InitDetailItems();
        }
        void InitDetailItems() {
            for(int i = 0; i < 10; i++) {
                DetailItems.Add(new DetailLevelItem() {
                    DetailId = i,
                    DetailName = String.Format("detail item {0}", i),
                    MasterItem = this,
                });
            }
        }
    }

    public class DetailLevelItem {
        public int DetailId { get; set; }
        public string DetailName { get; set; }
        public object MasterItem { get; set; }
    }
}
