//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "WCF Service Contracts" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using Xomega.Framework;

namespace AdventureWorks.Services
{
    #region ICustomerService

    ///<summary>
    /// Current customer information. Also see the Person and Store tables.
    ///</summary>
    [ServiceContract]
    public interface ICustomerService
    {

        ///<summary>
        /// Reads a list of Customer objects based on the specified criteria.
        ///</summary>
        [OperationContract]
        [FaultContract(typeof(ErrorList))]
        IEnumerable<Customer_ReadListOutput> ReadList(Customer_ReadListInput_Criteria _criteria);

    }
    #endregion

    #region Customer_ReadListInput_Criteria structure

    ///<summary>
    /// Structure of parameter Criteria of the input structure of operation ICustomerService.ReadList.
    ///</summary>
    [DataContract]
    public class Customer_ReadListInput_Criteria
    {
        [DataMember]
        public int? TerritoryId { get; set; }
        [DataMember]
        public string PersonNameOperator { get; set; }
        [DataMember]
        public string PersonName { get; set; }
        [DataMember]
        public string StoreNameOperator { get; set; }
        [DataMember]
        public string StoreName { get; set; }
        [DataMember]
        public string AccountNumberOperator { get; set; }
        [DataMember]
        public string AccountNumber { get; set; }
    }
    #endregion

    #region Customer_ReadListOutput structure

    ///<summary>
    /// The output structure of operation ICustomerService.ReadList.
    ///</summary>
    [DataContract]
    public class Customer_ReadListOutput
    {
        [DataMember]
        public int CustomerId { get; set; }
        [DataMember]
        public int? StoreId { get; set; }
        [DataMember]
        public string StoreName { get; set; }
        [DataMember]
        public int? PersonId { get; set; }
        [DataMember]
        public string PersonName { get; set; }
        [DataMember]
        public string AccountNumber { get; set; }
        [DataMember]
        public int? TerritoryId { get; set; }
    }
    #endregion

}