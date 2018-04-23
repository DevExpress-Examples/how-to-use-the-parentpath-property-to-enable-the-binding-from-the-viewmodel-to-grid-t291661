using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MultiLevelMasterDetail {
    public class MultiLevelDataSource : INotifyPropertyChanged {
        MasterLevelItem currentItem;
        DetailLevelItem currentDetailItem;
        ObservableCollection<MasterLevelItem> items;

        public ObservableCollection<MasterLevelItem> Items {
            get { return items; }
            set {
                if(items == value) return;
                items = value;
                RaisePropertyChanged("Items");
            }
        }
        public MasterLevelItem CurrentItem {
            get { return currentItem; }
            set {
                if(currentItem == value) return;
                currentItem = value;
                RaisePropertyChanged("CurrentItem");
            }
        }
        public DetailLevelItem CurrentDetailItem {
            get { return currentDetailItem; }
            set {
                if(currentDetailItem == value) return;
                currentDetailItem = value;
                RaisePropertyChanged("CurrentDetailItem");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public MultiLevelDataSource() {
            Items = new ObservableCollection<MasterLevelItem>();
            InitMasterItems();
            CurrentItem = null;
        }
        void InitMasterItems() {
            for(int i = 0; i < 10; i++) {
                Items.Add(new MasterLevelItem() {
                    MasterId = i,
                    MasterName = String.Format("master item {0}", i),
                });
            }
        }
        void RaisePropertyChanged(string propertyName) {
            if(PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
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
