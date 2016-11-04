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
    public partial class SalesCustomerLookupObject : DataObject
    {
        #region Constants

        public const string PersonName = "PersonName";
        public const string StoreName = "StoreName";

        #endregion

        #region Properties

        public TextProperty PersonNameProperty { get; private set; }
        public TextProperty StoreNameProperty { get; private set; }

        #endregion

        #region Construction

        protected override void Initialize()
        {
            PersonNameProperty = new TextProperty(this, PersonName);
            StoreNameProperty = new TextProperty(this, StoreName);
        }

        #endregion
    }

}