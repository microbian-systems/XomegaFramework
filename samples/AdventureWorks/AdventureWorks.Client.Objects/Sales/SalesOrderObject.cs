//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "Xomega Data Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using AdventureWorks.Client.Objects;
using AdventureWorks.Enumerations;
using AdventureWorks.Services;
using System;
using System.Data.Spatial;
using Xomega.Framework;
using Xomega.Framework.Properties;

namespace AdventureWorks.Client.Objects
{
    public partial class SalesOrderObject : DataObject
    {
        #region Constants

        public const string AccountNumber = "AccountNumber";
        public const string BillToAddressId = "BillToAddressId";
        public const string Comment = "Comment";
        public const string CreditCardApprovalCode = "CreditCardApprovalCode";
        public const string CreditCardId = "CreditCardId";
        public const string CurrencyRateId = "CurrencyRateId";
        public const string CustomerId = "CustomerId";
        public const string Detail = "Detail";
        public const string DueDate = "DueDate";
        public const string Freight = "Freight";
        public const string ModifiedDate = "ModifiedDate";
        public const string OnlineOrderFlag = "OnlineOrderFlag";
        public const string OrderDate = "OrderDate";
        public const string PurchaseOrderNumber = "PurchaseOrderNumber";
        public const string Reason = "Reason";
        public const string RevisionNumber = "RevisionNumber";
        public const string Rowguid = "Rowguid";
        public const string SalesOrderId = "SalesOrderId";
        public const string SalesOrderNumber = "SalesOrderNumber";
        public const string SalesPersonId = "SalesPersonId";
        public const string ShipDate = "ShipDate";
        public const string ShipMethodId = "ShipMethodId";
        public const string ShipToAddressId = "ShipToAddressId";
        public const string Status = "Status";
        public const string SubTotal = "SubTotal";
        public const string TaxAmt = "TaxAmt";
        public const string TerritoryId = "TerritoryId";
        public const string TotalDue = "TotalDue";

        #endregion

        #region Properties

        public TextProperty AccountNumberProperty { get; private set; }
        public IntegerKeyProperty BillToAddressIdProperty { get; private set; }
        public TextProperty CommentProperty { get; private set; }
        public TextProperty CreditCardApprovalCodeProperty { get; private set; }
        public IntegerKeyProperty CreditCardIdProperty { get; private set; }
        public IntegerKeyProperty CurrencyRateIdProperty { get; private set; }
        public IntegerKeyProperty CustomerIdProperty { get; private set; }
        public DateTimeProperty DueDateProperty { get; private set; }
        public MoneyProperty FreightProperty { get; private set; }
        public DateTimeProperty ModifiedDateProperty { get; private set; }
        public BooleanProperty OnlineOrderFlagProperty { get; private set; }
        public DateTimeProperty OrderDateProperty { get; private set; }
        public TextProperty PurchaseOrderNumberProperty { get; private set; }
        public TinyIntegerProperty RevisionNumberProperty { get; private set; }
        public GuidProperty RowguidProperty { get; private set; }
        public IntegerKeyProperty SalesOrderIdProperty { get; private set; }
        public TextProperty SalesOrderNumberProperty { get; private set; }
        public EnumIntProperty SalesPersonIdProperty { get; private set; }
        public DateTimeProperty ShipDateProperty { get; private set; }
        public IntegerKeyProperty ShipMethodIdProperty { get; private set; }
        public IntegerKeyProperty ShipToAddressIdProperty { get; private set; }
        public EnumByteProperty StatusProperty { get; private set; }
        public MoneyProperty SubTotalProperty { get; private set; }
        public MoneyProperty TaxAmtProperty { get; private set; }
        public EnumIntProperty TerritoryIdProperty { get; private set; }
        public MoneyProperty TotalDueProperty { get; private set; }

        #endregion

        #region Child Objects

        public SalesOrderDetailList DetailList { get { return (SalesOrderDetailList)GetChildObject(Detail); } }
        public SalesOrderReasonList ReasonList { get { return (SalesOrderReasonList)GetChildObject(Reason); } }

        #endregion

        #region Construction

        protected override void Initialize()
        {
            AccountNumberProperty = new TextProperty(this, AccountNumber);
            AccountNumberProperty.Size = 15;
            BillToAddressIdProperty = new IntegerKeyProperty(this, BillToAddressId);
            BillToAddressIdProperty.Required = true;
            CommentProperty = new TextProperty(this, Comment);
            CommentProperty.Size = 128;
            CreditCardApprovalCodeProperty = new TextProperty(this, CreditCardApprovalCode);
            CreditCardApprovalCodeProperty.Size = 15;
            CreditCardIdProperty = new IntegerKeyProperty(this, CreditCardId);
            CurrencyRateIdProperty = new IntegerKeyProperty(this, CurrencyRateId);
            CustomerIdProperty = new IntegerKeyProperty(this, CustomerId);
            CustomerIdProperty.Required = true;
            DueDateProperty = new DateTimeProperty(this, DueDate);
            DueDateProperty.Required = true;
            FreightProperty = new MoneyProperty(this, Freight);
            FreightProperty.Required = true;
            ModifiedDateProperty = new DateTimeProperty(this, ModifiedDate);
            ModifiedDateProperty.Required = true;
            OnlineOrderFlagProperty = new BooleanProperty(this, OnlineOrderFlag);
            OnlineOrderFlagProperty.Required = true;
            OrderDateProperty = new DateTimeProperty(this, OrderDate);
            OrderDateProperty.Required = true;
            PurchaseOrderNumberProperty = new TextProperty(this, PurchaseOrderNumber);
            PurchaseOrderNumberProperty.Size = 25;
            RevisionNumberProperty = new TinyIntegerProperty(this, RevisionNumber);
            RevisionNumberProperty.Required = true;
            RowguidProperty = new GuidProperty(this, Rowguid);
            RowguidProperty.Required = true;
            SalesOrderIdProperty = new IntegerKeyProperty(this, SalesOrderId);
            SalesOrderIdProperty.Required = true;
            SalesOrderIdProperty.Editable = false;
            SalesOrderNumberProperty = new TextProperty(this, SalesOrderNumber);
            SalesOrderNumberProperty.Required = true;
            SalesOrderNumberProperty.Size = 25;
            SalesPersonIdProperty = new EnumIntProperty(this, SalesPersonId);
            SalesPersonIdProperty.EnumType = "sales person";
            ShipDateProperty = new DateTimeProperty(this, ShipDate);
            ShipMethodIdProperty = new IntegerKeyProperty(this, ShipMethodId);
            ShipMethodIdProperty.Required = true;
            ShipToAddressIdProperty = new IntegerKeyProperty(this, ShipToAddressId);
            ShipToAddressIdProperty.Required = true;
            StatusProperty = new EnumByteProperty(this, Status);
            StatusProperty.Required = true;
            StatusProperty.Size = 10;
            StatusProperty.EnumType = "sales order status";
            SubTotalProperty = new MoneyProperty(this, SubTotal);
            SubTotalProperty.Required = true;
            TaxAmtProperty = new MoneyProperty(this, TaxAmt);
            TaxAmtProperty.Required = true;
            TerritoryIdProperty = new EnumIntProperty(this, TerritoryId);
            TerritoryIdProperty.Size = 10;
            TerritoryIdProperty.EnumType = "sales territory";
            TotalDueProperty = new MoneyProperty(this, TotalDue);
            TotalDueProperty.Required = true;
            DataObject objDetail = new SalesOrderDetailList();
            AddChildObject(Detail, objDetail);
            DataObject objReason = new SalesOrderReasonList();
            AddChildObject(Reason, objReason);
        }

        #endregion
    }

}