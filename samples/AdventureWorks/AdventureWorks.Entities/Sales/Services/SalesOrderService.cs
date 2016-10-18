//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "Service Implementations" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated
// unless they are placed between corresponding CUSTOM_CODE_START/CUSTOM_CODE_END lines.
//
// This file can be DELETED DURING REGENERATION IF NO LONGER NEEDED, e.g. if it gets renamed.
// To prevent this and preserve manual custom changes please remove the line above.
//---------------------------------------------------------------------------------------------

using AdventureWorks.Enumerations;
using AdventureWorks.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;
using Xomega.Framework;
using Xomega.Framework.Services;
// CUSTOM_CODE_START: add namespaces for custom code below
// CUSTOM_CODE_END

namespace AdventureWorks.Entities.Services
{
    public partial class SalesOrderService : ISalesOrderService
    {
        public SalesOrderService()
        {
        }

        public virtual SalesOrder_ReadOutput Read(int _salesOrderId)
        {
            SalesOrder_ReadOutput res = new SalesOrder_ReadOutput();
            using (AdventureWorksEntities ctx = new AdventureWorksEntities())
            {
                SalesOrder obj = ctx.SalesOrder.Find(_salesOrderId);
                if (obj == null)
                {
                    ErrorList.Current.CriticalError(HttpStatusCode.NotFound, "SalesOrder with id {0} not found", _salesOrderId);
                }
                ServiceUtil.CopyProperties(obj, res);
                if (obj.CustomerIdObject != null)
                  res.CustomerId = obj.CustomerIdObject.CustomerId;
                if (obj.SalesPersonIdObject != null)
                  res.SalesPersonId = obj.SalesPersonIdObject.BusinessEntityId;
                if (obj.TerritoryIdObject != null)
                  res.TerritoryId = obj.TerritoryIdObject.TerritoryId;
                if (obj.BillToAddressIdObject != null)
                  res.BillToAddressId = obj.BillToAddressIdObject.AddressId;
                if (obj.ShipToAddressIdObject != null)
                  res.ShipToAddressId = obj.ShipToAddressIdObject.AddressId;
                if (obj.ShipMethodIdObject != null)
                  res.ShipMethodId = obj.ShipMethodIdObject.ShipMethodId;
                if (obj.CreditCardIdObject != null)
                  res.CreditCardId = obj.CreditCardIdObject.CreditCardId;
                if (obj.CurrencyRateIdObject != null)
                  res.CurrencyRateId = obj.CurrencyRateIdObject.CurrencyRateId;
                // CUSTOM_CODE_START: add custom code for Read operation below
                // CUSTOM_CODE_END
            }
            return res;
        }

        public virtual SalesOrder_CreateOutput Create(SalesOrder_CreateInput _data)
        {
            SalesOrder_CreateOutput res = new SalesOrder_CreateOutput();
            using (AdventureWorksEntities ctx = new AdventureWorksEntities())
            {
                EntityState state = EntityState.Added;
                SalesOrder obj = new SalesOrder();
                var entry = ctx.Entry(obj);
                entry.State = state;
                entry.CurrentValues.SetValues(_data);
                obj.CustomerIdObject = ctx.Customer.Find(_data.CustomerId);
                if (obj.CustomerIdObject == null)
                    ErrorList.Current.AddError("Invalid value {0} for parameter CustomerId. Cannot find the corresponding Customer object.", _data.CustomerId);
                obj.SalesPersonIdObject = ctx.SalesPerson.Find(_data.SalesPersonId);
                if (_data.SalesPersonId != null && obj.SalesPersonIdObject == null)
                    ErrorList.Current.AddError("Invalid value {0} for parameter SalesPersonId. Cannot find the corresponding SalesPerson object.", _data.SalesPersonId);
                obj.TerritoryIdObject = ctx.SalesTerritory.Find(_data.TerritoryId);
                if (_data.TerritoryId != null && obj.TerritoryIdObject == null)
                    ErrorList.Current.AddError("Invalid value {0} for parameter TerritoryId. Cannot find the corresponding SalesTerritory object.", _data.TerritoryId);
                obj.BillToAddressIdObject = ctx.Address.Find(_data.BillToAddressId);
                if (obj.BillToAddressIdObject == null)
                    ErrorList.Current.AddError("Invalid value {0} for parameter BillToAddressId. Cannot find the corresponding Address object.", _data.BillToAddressId);
                obj.ShipToAddressIdObject = ctx.Address.Find(_data.ShipToAddressId);
                if (obj.ShipToAddressIdObject == null)
                    ErrorList.Current.AddError("Invalid value {0} for parameter ShipToAddressId. Cannot find the corresponding Address object.", _data.ShipToAddressId);
                obj.ShipMethodIdObject = ctx.ShipMethod.Find(_data.ShipMethodId);
                if (obj.ShipMethodIdObject == null)
                    ErrorList.Current.AddError("Invalid value {0} for parameter ShipMethodId. Cannot find the corresponding ShipMethod object.", _data.ShipMethodId);
                obj.CreditCardIdObject = ctx.CreditCard.Find(_data.CreditCardId);
                if (_data.CreditCardId != null && obj.CreditCardIdObject == null)
                    ErrorList.Current.AddError("Invalid value {0} for parameter CreditCardId. Cannot find the corresponding CreditCard object.", _data.CreditCardId);
                obj.CurrencyRateIdObject = ctx.CurrencyRate.Find(_data.CurrencyRateId);
                if (_data.CurrencyRateId != null && obj.CurrencyRateIdObject == null)
                    ErrorList.Current.AddError("Invalid value {0} for parameter CurrencyRateId. Cannot find the corresponding CurrencyRate object.", _data.CurrencyRateId);
                // CUSTOM_CODE_START: add custom code for Create operation below
                // CUSTOM_CODE_END
                ErrorList.Current.AbortIfHasErrors(HttpStatusCode.BadRequest);
                ctx.SaveChanges();
                ServiceUtil.CopyProperties(obj, res);
            }
            return res;
        }

        public virtual void Update(int _salesOrderId, SalesOrder_UpdateInput_Data _data)
        {
            using (AdventureWorksEntities ctx = new AdventureWorksEntities())
            {
                SalesOrder obj = ctx.SalesOrder.Find(_salesOrderId);
                if (obj == null)
                {
                    ErrorList.Current.CriticalError(HttpStatusCode.NotFound, "SalesOrder with id {0} not found", _salesOrderId);
                }
                var entry = ctx.Entry(obj);
                entry.CurrentValues.SetValues(_data);
                obj.CustomerIdObject = ctx.Customer.Find(_data.CustomerId);
                if (obj.CustomerIdObject == null)
                    ErrorList.Current.AddError("Invalid value {0} for parameter CustomerId. Cannot find the corresponding Customer object.", _data.CustomerId);
                obj.SalesPersonIdObject = ctx.SalesPerson.Find(_data.SalesPersonId);
                if (_data.SalesPersonId != null && obj.SalesPersonIdObject == null)
                    ErrorList.Current.AddError("Invalid value {0} for parameter SalesPersonId. Cannot find the corresponding SalesPerson object.", _data.SalesPersonId);
                obj.TerritoryIdObject = ctx.SalesTerritory.Find(_data.TerritoryId);
                if (_data.TerritoryId != null && obj.TerritoryIdObject == null)
                    ErrorList.Current.AddError("Invalid value {0} for parameter TerritoryId. Cannot find the corresponding SalesTerritory object.", _data.TerritoryId);
                obj.BillToAddressIdObject = ctx.Address.Find(_data.BillToAddressId);
                if (obj.BillToAddressIdObject == null)
                    ErrorList.Current.AddError("Invalid value {0} for parameter BillToAddressId. Cannot find the corresponding Address object.", _data.BillToAddressId);
                obj.ShipToAddressIdObject = ctx.Address.Find(_data.ShipToAddressId);
                if (obj.ShipToAddressIdObject == null)
                    ErrorList.Current.AddError("Invalid value {0} for parameter ShipToAddressId. Cannot find the corresponding Address object.", _data.ShipToAddressId);
                obj.ShipMethodIdObject = ctx.ShipMethod.Find(_data.ShipMethodId);
                if (obj.ShipMethodIdObject == null)
                    ErrorList.Current.AddError("Invalid value {0} for parameter ShipMethodId. Cannot find the corresponding ShipMethod object.", _data.ShipMethodId);
                obj.CreditCardIdObject = ctx.CreditCard.Find(_data.CreditCardId);
                if (_data.CreditCardId != null && obj.CreditCardIdObject == null)
                    ErrorList.Current.AddError("Invalid value {0} for parameter CreditCardId. Cannot find the corresponding CreditCard object.", _data.CreditCardId);
                obj.CurrencyRateIdObject = ctx.CurrencyRate.Find(_data.CurrencyRateId);
                if (_data.CurrencyRateId != null && obj.CurrencyRateIdObject == null)
                    ErrorList.Current.AddError("Invalid value {0} for parameter CurrencyRateId. Cannot find the corresponding CurrencyRate object.", _data.CurrencyRateId);
                // CUSTOM_CODE_START: add custom code for Update operation below
                // CUSTOM_CODE_END
                ErrorList.Current.AbortIfHasErrors(HttpStatusCode.BadRequest);
                ctx.SaveChanges();
            }
        }

        public virtual void Delete(int _salesOrderId)
        {
            using (AdventureWorksEntities ctx = new AdventureWorksEntities())
            {
                EntityState state = EntityState.Deleted;
                SalesOrder obj = ctx.SalesOrder.Find(_salesOrderId);
                if (obj == null)
                {
                    ErrorList.Current.CriticalError(HttpStatusCode.NotFound, "SalesOrder with id {0} not found", _salesOrderId);
                }
                var entry = ctx.Entry(obj);
                entry.State = state;
                // CUSTOM_CODE_START: add custom code for Delete operation below
                // CUSTOM_CODE_END
                ErrorList.Current.AbortIfHasErrors(HttpStatusCode.BadRequest);
                ctx.SaveChanges();
            }
        }

        public virtual IEnumerable<SalesOrder_ReadListOutput> ReadList(SalesOrder_ReadListInput_Criteria _criteria)
        {
            IEnumerable<SalesOrder_ReadListOutput> res = null;
            using (AdventureWorksEntities ctx = new AdventureWorksEntities())
            {
                var src = from obj in ctx.SalesOrder select obj;
                #region Source filter
                if (_criteria != null)
                {

                    // CUSTOM_CODE_START: add code for GlobalRegion criteria of ReadList operation below
                    if (_criteria.GlobalRegion != null)
                    {
                        src = src.Where(o => _criteria.GlobalRegion == o.TerritoryIdObject.Group);
                    } // CUSTOM_CODE_END
                }
                // CUSTOM_CODE_START: add custom filter criteria to the source query for ReadList operation below
                // src = src.Where(o => o.FieldName == VALUE);
                // CUSTOM_CODE_END
                #endregion
                var qry = from obj in src
                          select new SalesOrder_ReadListOutput() {
                              SalesOrderId = obj.SalesOrderId,
                              SalesOrderNumber = obj.SalesOrderNumber,
                              Status = obj.Status,
                              OrderDate = obj.OrderDate,
                              ShipDate = obj.ShipDate,
                              DueDate = obj.DueDate,
                              TotalDue = obj.TotalDue,
                              OnlineOrderFlag = obj.OnlineOrderFlag,
                              // CUSTOM_CODE_START: set the CustomerStore output parameter of ReadList operation below
                              CustomerStore = obj.CustomerIdObject.StoreIdObject.Name, // CUSTOM_CODE_END
                              // CUSTOM_CODE_START: set the CustomerName output parameter of ReadList operation below
                              CustomerName = obj.CustomerIdObject.PersonIdObject.LastName + ", " + 
                                             obj.CustomerIdObject.PersonIdObject.FirstName, // CUSTOM_CODE_END
                              SalesPersonId = obj.SalesPersonIdObject.BusinessEntityId,
                              TerritoryId = obj.TerritoryIdObject.TerritoryId,
                          };
                #region Result filter
                if (_criteria != null)
                {
                    #region SalesOrderNumber
                    if (_criteria.SalesOrderNumberOperator != null)
                    {
                        switch (_criteria.SalesOrderNumberOperator)
                        {
                            case Operators.IsEqualTo:
                                qry = qry.Where(o => o.SalesOrderNumber == _criteria.SalesOrderNumber); break;
                            case Operators.IsNotEqualTo:
                                qry = qry.Where(o => o.SalesOrderNumber != _criteria.SalesOrderNumber); break;
                            case Operators.Contains:
                                qry = qry.Where(o => o.SalesOrderNumber.Contains(_criteria.SalesOrderNumber)); break;
                            case Operators.DoesNotContain:
                                qry = qry.Where(o => !o.SalesOrderNumber.Contains(_criteria.SalesOrderNumber)); break;
                            default:
                                ErrorList.Current.AddError("Unsupported operator {0} for the Sales Order Number.", _criteria.SalesOrderNumberOperator); break;
                        }
                    }
                    #endregion

                    #region Status
                    if (_criteria.StatusOperator != null)
                    {
                        switch (_criteria.StatusOperator)
                        {
                            case Operators.IsEqualTo:
                                qry = qry.Where(o => o.Status == _criteria.Status); break;
                            case Operators.IsNotEqualTo:
                                qry = qry.Where(o => o.Status != _criteria.Status); break;
                            default:
                                ErrorList.Current.AddError("Unsupported operator {0} for the Status.", _criteria.StatusOperator); break;
                        }
                    }
                    #endregion

                    #region OrderDate
                    if (_criteria.OrderDateOperator != null)
                    {
                        switch (_criteria.OrderDateOperator)
                        {
                            case Operators.IsEqualTo:
                                qry = qry.Where(o => o.OrderDate == _criteria.OrderDate); break;
                            case Operators.IsNotEqualTo:
                                qry = qry.Where(o => o.OrderDate != _criteria.OrderDate); break;
                            case Operators.IsEarlierThan:
                                qry = qry.Where(o => o.OrderDate < _criteria.OrderDate); break;
                            case Operators.IsLaterThan:
                                qry = qry.Where(o => o.OrderDate > _criteria.OrderDate); break;
                            case Operators.IsBetween:
                                qry = qry.Where(o => o.OrderDate >= _criteria.OrderDate && o.OrderDate <= _criteria.OrderDate2); break;
                            default:
                                ErrorList.Current.AddError("Unsupported operator {0} for the Order Date.", _criteria.OrderDateOperator); break;
                        }
                    }
                    #endregion

                    #region DueDate
                    if (_criteria.DueDateOperator != null)
                    {
                        switch (_criteria.DueDateOperator)
                        {
                            case Operators.IsEqualTo:
                                qry = qry.Where(o => o.DueDate == _criteria.DueDate); break;
                            case Operators.IsNotEqualTo:
                                qry = qry.Where(o => o.DueDate != _criteria.DueDate); break;
                            case Operators.IsEarlierThan:
                                qry = qry.Where(o => o.DueDate < _criteria.DueDate); break;
                            case Operators.IsLaterThan:
                                qry = qry.Where(o => o.DueDate > _criteria.DueDate); break;
                            case Operators.IsBetween:
                                qry = qry.Where(o => o.DueDate >= _criteria.DueDate && o.DueDate <= _criteria.DueDate2); break;
                            default:
                                ErrorList.Current.AddError("Unsupported operator {0} for the Due Date.", _criteria.DueDateOperator); break;
                        }
                    }
                    #endregion

                    #region TotalDue
                    if (_criteria.TotalDueOperator != null)
                    {
                        switch (_criteria.TotalDueOperator)
                        {
                            case Operators.IsEqualTo:
                                qry = qry.Where(o => o.TotalDue == _criteria.TotalDue); break;
                            case Operators.IsNotEqualTo:
                                qry = qry.Where(o => o.TotalDue != _criteria.TotalDue); break;
                            case Operators.IsLessThan:
                                qry = qry.Where(o => o.TotalDue < _criteria.TotalDue); break;
                            case Operators.IsNotLessThan:
                                qry = qry.Where(o => o.TotalDue >= _criteria.TotalDue); break;
                            case Operators.IsGreaterThan:
                                qry = qry.Where(o => o.TotalDue > _criteria.TotalDue); break;
                            case Operators.IsNotGreaterThan:
                                qry = qry.Where(o => o.TotalDue <= _criteria.TotalDue); break;
                            case Operators.IsBetween:
                                qry = qry.Where(o => o.TotalDue >= _criteria.TotalDue && o.TotalDue <= _criteria.TotalDue2); break;
                            default:
                                ErrorList.Current.AddError("Unsupported operator {0} for the Total Due.", _criteria.TotalDueOperator); break;
                        }
                    }
                    #endregion

                    #region CustomerStore
                    if (_criteria.CustomerStoreOperator != null)
                    {
                        switch (_criteria.CustomerStoreOperator)
                        {
                            case Operators.IsNull:
                                qry = qry.Where(o => o.CustomerStore == null); break;
                            case Operators.IsNotNull:
                                qry = qry.Where(o => o.CustomerStore != null); break;
                            case Operators.IsEqualTo:
                                qry = qry.Where(o => o.CustomerStore == _criteria.CustomerStore); break;
                            case Operators.IsNotEqualTo:
                                qry = qry.Where(o => o.CustomerStore != _criteria.CustomerStore); break;
                            case Operators.Contains:
                                qry = qry.Where(o => o.CustomerStore.Contains(_criteria.CustomerStore)); break;
                            case Operators.DoesNotContain:
                                qry = qry.Where(o => !o.CustomerStore.Contains(_criteria.CustomerStore)); break;
                            default:
                                ErrorList.Current.AddError("Unsupported operator {0} for the Customer Store.", _criteria.CustomerStoreOperator); break;
                        }
                    }
                    #endregion

                    #region CustomerName
                    if (_criteria.CustomerNameOperator != null)
                    {
                        switch (_criteria.CustomerNameOperator)
                        {
                            case Operators.IsNull:
                                qry = qry.Where(o => o.CustomerName == null); break;
                            case Operators.IsNotNull:
                                qry = qry.Where(o => o.CustomerName != null); break;
                            case Operators.IsEqualTo:
                                qry = qry.Where(o => o.CustomerName == _criteria.CustomerName); break;
                            case Operators.IsNotEqualTo:
                                qry = qry.Where(o => o.CustomerName != _criteria.CustomerName); break;
                            case Operators.Contains:
                                qry = qry.Where(o => o.CustomerName.Contains(_criteria.CustomerName)); break;
                            case Operators.DoesNotContain:
                                qry = qry.Where(o => !o.CustomerName.Contains(_criteria.CustomerName)); break;
                            default:
                                ErrorList.Current.AddError("Unsupported operator {0} for the Customer Name.", _criteria.CustomerNameOperator); break;
                        }
                    }
                    #endregion

                    #region TerritoryId
                    if (_criteria.TerritoryIdOperator != null)
                    {
                        switch (_criteria.TerritoryIdOperator)
                        {
                            case Operators.IsNull:
                                qry = qry.Where(o => o.TerritoryId == null); break;
                            case Operators.IsNotNull:
                                qry = qry.Where(o => o.TerritoryId != null); break;
                            case Operators.IsEqualTo:
                                qry = qry.Where(o => o.TerritoryId == _criteria.TerritoryId); break;
                            case Operators.IsNotEqualTo:
                                qry = qry.Where(o => o.TerritoryId != _criteria.TerritoryId); break;
                            default:
                                ErrorList.Current.AddError("Unsupported operator {0} for the Territory Id.", _criteria.TerritoryIdOperator); break;
                        }
                    }
                    #endregion

                    #region SalesPersonId
                    if (_criteria.SalesPersonIdOperator != null)
                    {
                        switch (_criteria.SalesPersonIdOperator)
                        {
                            case Operators.IsNull:
                                qry = qry.Where(o => o.SalesPersonId == null); break;
                            case Operators.IsNotNull:
                                qry = qry.Where(o => o.SalesPersonId != null); break;
                            case Operators.IsOneOf:
                                qry = qry.WhereIn(o => o.SalesPersonId, _criteria.SalesPersonId); break;
                            case Operators.IsNoneOf:
                                qry = qry.WhereNotIn(o => o.SalesPersonId, _criteria.SalesPersonId); break;
                            default:
                                ErrorList.Current.AddError("Unsupported operator {0} for the Sales Person Id.", _criteria.SalesPersonIdOperator); break;
                        }
                    }
                    #endregion
                }
                // CUSTOM_CODE_START: add custom filter criteria to the result query for ReadList operation below
                // qry = qry.Where(o => o.FieldName == VALUE);
                // CUSTOM_CODE_END
                #endregion
                ErrorList.Current.AbortIfHasErrors(HttpStatusCode.BadRequest);
                res = qry.ToList();
            }
            return res;
        }

        public virtual SalesOrderDetail_ReadOutput Detail_Read(int _salesOrderDetailId)
        {
            SalesOrderDetail_ReadOutput res = new SalesOrderDetail_ReadOutput();
            using (AdventureWorksEntities ctx = new AdventureWorksEntities())
            {
                SalesOrderDetail obj = ctx.SalesOrderDetail.Find(_salesOrderDetailId);
                if (obj == null)
                {
                    ErrorList.Current.CriticalError(HttpStatusCode.NotFound, "SalesOrderDetail with id {0} not found", _salesOrderDetailId);
                }
                ServiceUtil.CopyProperties(obj, res);
                res.SalesOrderId = obj.SalesOrderObject.SalesOrderId;
                // CUSTOM_CODE_START: set the SpecialOfferId output field of Detail_Read operation below
                // TODO: res.SpecialOfferId = ???; // CUSTOM_CODE_END
                // CUSTOM_CODE_START: set the ProductId output field of Detail_Read operation below
                // TODO: res.ProductId = ???; // CUSTOM_CODE_END
                // CUSTOM_CODE_START: add custom code for Detail_Read operation below
                // CUSTOM_CODE_END
            }
            return res;
        }

        public virtual SalesOrderDetail_CreateOutput Detail_Create(SalesOrderDetail_CreateInput _data)
        {
            SalesOrderDetail_CreateOutput res = new SalesOrderDetail_CreateOutput();
            using (AdventureWorksEntities ctx = new AdventureWorksEntities())
            {
                EntityState state = EntityState.Added;
                SalesOrderDetail obj = new SalesOrderDetail();
                var entry = ctx.Entry(obj);
                entry.State = state;
                entry.CurrentValues.SetValues(_data);
                obj.SalesOrderObject = ctx.SalesOrder.Find(_data.SalesOrderId);
                if (obj.SalesOrderObject == null)
                    ErrorList.Current.AddError("Invalid value {0} for parameter SalesOrderId. Cannot find the corresponding SalesOrder object.", _data.SalesOrderId);
                // CUSTOM_CODE_START: use the SpecialOfferId input parameter of Detail_Create operation below
                // TODO: ??? = _data.SpecialOfferId; // CUSTOM_CODE_END
                // CUSTOM_CODE_START: use the ProductId input parameter of Detail_Create operation below
                // TODO: ??? = _data.ProductId; // CUSTOM_CODE_END
                // CUSTOM_CODE_START: add custom code for Detail_Create operation below
                // CUSTOM_CODE_END
                ErrorList.Current.AbortIfHasErrors(HttpStatusCode.BadRequest);
                ctx.SaveChanges();
                ServiceUtil.CopyProperties(obj, res);
            }
            return res;
        }

        public virtual void Detail_Update(int _salesOrderDetailId, SalesOrderDetail_UpdateInput_Data _data)
        {
            using (AdventureWorksEntities ctx = new AdventureWorksEntities())
            {
                SalesOrderDetail obj = ctx.SalesOrderDetail.Find(_salesOrderDetailId);
                if (obj == null)
                {
                    ErrorList.Current.CriticalError(HttpStatusCode.NotFound, "SalesOrderDetail with id {0} not found", _salesOrderDetailId);
                }
                var entry = ctx.Entry(obj);
                entry.CurrentValues.SetValues(_data);
                // CUSTOM_CODE_START: use the SpecialOfferId input parameter of Detail_Update operation below
                // TODO: ??? = _data.SpecialOfferId; // CUSTOM_CODE_END
                // CUSTOM_CODE_START: use the ProductId input parameter of Detail_Update operation below
                // TODO: ??? = _data.ProductId; // CUSTOM_CODE_END
                // CUSTOM_CODE_START: add custom code for Detail_Update operation below
                // CUSTOM_CODE_END
                ErrorList.Current.AbortIfHasErrors(HttpStatusCode.BadRequest);
                ctx.SaveChanges();
            }
        }

        public virtual void Detail_Delete(int _salesOrderDetailId)
        {
            using (AdventureWorksEntities ctx = new AdventureWorksEntities())
            {
                EntityState state = EntityState.Deleted;
                SalesOrderDetail obj = ctx.SalesOrderDetail.Find(_salesOrderDetailId);
                if (obj == null)
                {
                    ErrorList.Current.CriticalError(HttpStatusCode.NotFound, "SalesOrderDetail with id {0} not found", _salesOrderDetailId);
                }
                var entry = ctx.Entry(obj);
                entry.State = state;
                // CUSTOM_CODE_START: add custom code for Detail_Delete operation below
                // CUSTOM_CODE_END
                ErrorList.Current.AbortIfHasErrors(HttpStatusCode.BadRequest);
                ctx.SaveChanges();
            }
        }

        public virtual IEnumerable<SalesOrderDetail_ReadListOutput> Detail_ReadList(int _salesOrderId)
        {
            IEnumerable<SalesOrderDetail_ReadListOutput> res = null;
            using (AdventureWorksEntities ctx = new AdventureWorksEntities())
            {
                var src = from obj in ctx.SalesOrderDetail
                          where obj.SalesOrderObject.SalesOrderId == _salesOrderId
                          select obj;
                #region Source filter
                if (true)
                {
                    // CUSTOM_CODE_START: add code for SalesOrderId criteria of Detail_ReadList operation below
                    if (_salesOrderId != null)
                    {
                        // TODO: src = src.Where(o => _salesOrderId == _salesOrderId);
                    } // CUSTOM_CODE_END
                }
                // CUSTOM_CODE_START: add custom filter criteria to the source query for Detail_ReadList operation below
                // src = src.Where(o => o.FieldName == VALUE);
                // CUSTOM_CODE_END
                #endregion
                var qry = from obj in src
                          select new SalesOrderDetail_ReadListOutput() {
                              SalesOrderDetailId = obj.SalesOrderDetailId,
                              CarrierTrackingNumber = obj.CarrierTrackingNumber,
                              OrderQty = obj.OrderQty,
                              // CUSTOM_CODE_START: set the SpecialOfferId output parameter of Detail_ReadList operation below
                              // TODO: SpecialOfferId = obj.SpecialOfferId, // CUSTOM_CODE_END
                              // CUSTOM_CODE_START: set the ProductId output parameter of Detail_ReadList operation below
                              // TODO: ProductId = obj.ProductId, // CUSTOM_CODE_END
                              UnitPrice = obj.UnitPrice,
                              UnitPriceDiscount = obj.UnitPriceDiscount,
                              LineTotal = obj.LineTotal,
                              Rowguid = obj.Rowguid,
                              ModifiedDate = obj.ModifiedDate,
                          };
                #region Result filter
                if (true)
                {
                }
                // CUSTOM_CODE_START: add custom filter criteria to the result query for Detail_ReadList operation below
                // qry = qry.Where(o => o.FieldName == VALUE);
                // CUSTOM_CODE_END
                #endregion
                ErrorList.Current.AbortIfHasErrors(HttpStatusCode.BadRequest);
                res = qry.ToList();
            }
            return res;
        }

        public virtual SalesOrderReason_ReadOutput Reason_Read(int _salesOrderId, int _salesReasonId)
        {
            SalesOrderReason_ReadOutput res = new SalesOrderReason_ReadOutput();
            using (AdventureWorksEntities ctx = new AdventureWorksEntities())
            {
                SalesOrderReason obj = ctx.SalesOrderReason.Find(_salesOrderId, _salesReasonId);
                if (obj == null)
                {
                    ErrorList.Current.CriticalError(HttpStatusCode.NotFound, "SalesOrderReason with id {0}{1} not found", _salesOrderId, _salesReasonId);
                }
                ServiceUtil.CopyProperties(obj, res);
                // CUSTOM_CODE_START: add custom code for Reason_Read operation below
                // CUSTOM_CODE_END
            }
            return res;
        }

        public virtual void Reason_Create(SalesOrderReason_CreateInput _data)
        {
            using (AdventureWorksEntities ctx = new AdventureWorksEntities())
            {
                EntityState state = EntityState.Unchanged;
                SalesOrderReason obj = ctx.SalesOrderReason.Find(_data.SalesOrderId, _data.SalesReasonId);
                if (obj == null)
                {
                    obj = new SalesOrderReason();
                    state = EntityState.Added;
                }
                var entry = ctx.Entry(obj);
                entry.State = state;
                entry.CurrentValues.SetValues(_data);
                obj.SalesOrderObject = ctx.SalesOrder.Find(_data.SalesOrderId);
                if (obj.SalesOrderObject == null)
                    ErrorList.Current.AddError("Invalid value {0} for parameter SalesOrderId. Cannot find the corresponding SalesOrder object.", _data.SalesOrderId);
                // CUSTOM_CODE_START: add custom code for Reason_Create operation below
                // CUSTOM_CODE_END
                ErrorList.Current.AbortIfHasErrors(HttpStatusCode.BadRequest);
                ctx.SaveChanges();
            }
        }

        public virtual void Reason_Update(int _salesOrderId, int _salesReasonId, SalesOrderReason_UpdateInput_Data _data)
        {
            using (AdventureWorksEntities ctx = new AdventureWorksEntities())
            {
                SalesOrderReason obj = ctx.SalesOrderReason.Find(_salesOrderId, _salesReasonId);
                if (obj == null)
                {
                    ErrorList.Current.CriticalError(HttpStatusCode.NotFound, "SalesOrderReason with id {0}{1} not found", _salesOrderId, _salesReasonId);
                }
                var entry = ctx.Entry(obj);
                entry.CurrentValues.SetValues(_data);
                // CUSTOM_CODE_START: add custom code for Reason_Update operation below
                // CUSTOM_CODE_END
                ErrorList.Current.AbortIfHasErrors(HttpStatusCode.BadRequest);
                ctx.SaveChanges();
            }
        }

        public virtual void Reason_Delete(int _salesOrderId, int _salesReasonId)
        {
            using (AdventureWorksEntities ctx = new AdventureWorksEntities())
            {
                EntityState state = EntityState.Deleted;
                SalesOrderReason obj = ctx.SalesOrderReason.Find(_salesOrderId, _salesReasonId);
                if (obj == null)
                {
                    ErrorList.Current.CriticalError(HttpStatusCode.NotFound, "SalesOrderReason with id {0}{1} not found", _salesOrderId, _salesReasonId);
                }
                var entry = ctx.Entry(obj);
                entry.State = state;
                // CUSTOM_CODE_START: add custom code for Reason_Delete operation below
                // CUSTOM_CODE_END
                ErrorList.Current.AbortIfHasErrors(HttpStatusCode.BadRequest);
                ctx.SaveChanges();
            }
        }

        public virtual IEnumerable<SalesOrderReason_ReadListOutput> Reason_ReadList(int _salesOrderId)
        {
            IEnumerable<SalesOrderReason_ReadListOutput> res = null;
            using (AdventureWorksEntities ctx = new AdventureWorksEntities())
            {
                var src = from obj in ctx.SalesOrderReason
                          where obj.SalesOrderObject.SalesOrderId == _salesOrderId
                          select obj;
                #region Source filter
                if (true)
                {
                    // CUSTOM_CODE_START: add code for SalesOrderId criteria of Reason_ReadList operation below
                    if (_salesOrderId != null)
                    {
                        // TODO: src = src.Where(o => _salesOrderId == _salesOrderId);
                    } // CUSTOM_CODE_END
                }
                // CUSTOM_CODE_START: add custom filter criteria to the source query for Reason_ReadList operation below
                // src = src.Where(o => o.FieldName == VALUE);
                // CUSTOM_CODE_END
                #endregion
                var qry = from obj in src
                          select new SalesOrderReason_ReadListOutput() {
                              SalesReasonId = obj.SalesReasonId,
                              ModifiedDate = obj.ModifiedDate,
                          };
                #region Result filter
                if (true)
                {
                }
                // CUSTOM_CODE_START: add custom filter criteria to the result query for Reason_ReadList operation below
                // qry = qry.Where(o => o.FieldName == VALUE);
                // CUSTOM_CODE_END
                #endregion
                ErrorList.Current.AbortIfHasErrors(HttpStatusCode.BadRequest);
                res = qry.ToList();
            }
            return res;
        }
    }
}