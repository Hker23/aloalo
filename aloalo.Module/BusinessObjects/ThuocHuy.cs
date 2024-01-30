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
using System.Text;

namespace aloalo.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class ThuocHuy : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public ThuocHuy(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string _Sophieubienban;
        [XafDisplayName("Số biên bản")]
        public string Sophieubienban
        {
            get { return _Sophieubienban; }
            set { SetPropertyValue<string>(nameof(Sophieubienban), ref _Sophieubienban, value); }
        }

        private string _Mathuoc;
        [XafDisplayName("Mã thuốc")]
        public string Mathuoc
        {
            get { return _Mathuoc; }
            set { SetPropertyValue<string>(nameof(Mathuoc), ref _Mathuoc, value); }
        }

        private string _Losanxuat;
        [XafDisplayName("Lô sản xuất")]
        public string Losanxuat
        {
            get { return _Losanxuat; }
            set { SetPropertyValue<string>(nameof(Losanxuat), ref _Losanxuat, value); }
        }

        private int _Soluonghuy;
        [XafDisplayName("Số lượng hủy")]
        public int Soluonghuy
        {
            get { return _Soluonghuy; }
            set { SetPropertyValue<int>(nameof(Soluonghuy), ref _Soluonghuy, value); }
        }


        private string _unknown;
        public string unknown
        {
            get { return _unknown; }
            set { SetPropertyValue<string>(nameof(unknown), ref _unknown, value); }
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