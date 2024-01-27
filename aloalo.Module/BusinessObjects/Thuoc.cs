using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace aloalo.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Thuoc : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Thuoc(Session session)
            : base(session)
        {
        }
        


        private string _Masothuoc;
        [XafDisplayName("Mã số thuốc")]
        public string Masothuoc
        {
            get { return _Masothuoc; }
            set { SetPropertyValue<string>(nameof(Masothuoc), ref _Masothuoc, value); }
        }


        private string _Kêđơn;
        [XafDisplayName("Kê đơn")]
        public string Kêđơn
        {
            get { return _Kêđơn; }
            set { SetPropertyValue<string>(nameof(Kêđơn), ref _Kêđơn, value); }
        }

        private string _Huongdansudung;
        [XafDisplayName("Hướng dẫn sử dụng")]
        public string Huongdansudung
        {
            get { return _Huongdansudung; }
            set { SetPropertyValue<string>(nameof(Huongdansudung), ref _Huongdansudung, value); }
        }


        private string _Quycachdunggoi;
        [XafDisplayName("Quy cách đóng gói")]
        public string Quycachdunggoi
        {
            get { return _Quycachdunggoi; }
            set { SetPropertyValue<string>(nameof(Quycachdunggoi), ref _Quycachdunggoi, value); }
        }

        private string _Baoquan;
        [XafDisplayName("Bảo quản")]
        public string Baoquan
        {
            get { return _Baoquan; }
            set { SetPropertyValue<string>(nameof(Baoquan), ref _Baoquan, value); }
        }

        private string _Hoatchat;
        [XafDisplayName("Hoạt chất")]
        public string Hoatchat
        {
            get { return _Hoatchat; }
            set { SetPropertyValue<string>(nameof(Hoatchat), ref _Hoatchat, value); }
        }







        private string _Tenthuoc;
        [XafDisplayName("Tên thuốc")]
        public string Tenthuoc
        {
            get { return _Tenthuoc; }
            set { SetPropertyValue<string>(nameof(Tenthuoc), ref _Tenthuoc, value); }
        }

        [DefaultProperty("abc")]
        public class CustomObject : BaseObject
        {
            public CustomObject(Session session) : base(session) { }
            private string _Name;
            public string Name
            {
                get { return _Name; }
                set { SetPropertyValue<string>("Name", ref _Name, value); }
            }
        }



        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //private string _PersistentProperty;
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty {
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue(nameof(PersistentProperty), ref _PersistentProperty, value); }
        //}

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}
    }
}