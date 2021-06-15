//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "EF Domain Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using System;

namespace AdventureWorks.Services.Entities
{
    ///<summary>
    /// Currency exchange rates.
    ///</summary>
    public partial class CurrencyRate
    {
        public CurrencyRate()
        {
        }

        #region Properties

        public int CurrencyRateId  { get; set; }

        ///<summary>
        /// Date and time the exchange rate was obtained.
        ///</summary>
        public DateTime CurrencyRateDate  { get; set; }

        ///<summary>
        /// Exchange rate was converted from this currency code.
        ///</summary>
        public string FromCurrencyCode  { get; set; }

        ///<summary>
        /// Exchange rate was converted to this currency code.
        ///</summary>
        public string ToCurrencyCode  { get; set; }

        ///<summary>
        /// Average exchange rate for the day.
        ///</summary>
        public decimal AverageRate  { get; set; }

        ///<summary>
        /// Final exchange rate for the day.
        ///</summary>
        public decimal EndOfDayRate  { get; set; }

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public DateTime ModifiedDate  { get; set; }

        #endregion

        #region Navigation Properties

        ///<summary>
        /// Currency object referenced by the field FromCurrencyCode.
        ///</summary>
        public virtual Currency FromCurrencyCodeObject { get; set; }

        ///<summary>
        /// Currency object referenced by the field ToCurrencyCode.
        ///</summary>
        public virtual Currency ToCurrencyCodeObject { get; set; }

        #endregion
    }
}