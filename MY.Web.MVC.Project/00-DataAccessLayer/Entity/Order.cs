using System;
using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderDate { get; set; }
        public string OrderDeliveryDate { get; set; }
        public int OrderStatu { get; set; }
        public int OrderPaymentOptionDepositCard { get; set; }
        public int OrderPaymentCard { get; set; }
        public string OrderPaymentCardResult { get; set; }
        public string OrderPaymentStructuredIp { get; set; }
        public string OrderPaymentCardPin { get; set; }
        public string OrderPaymentInstallmentNumber { get; set; }
        public string OrderTotalVAT { get; set; }
        public string PriceExcludingOrderVAT { get; set; }
        public string PriceIncludingOrderTotalVAT { get; set; }
        public string OrderTotalCargoPrice { get; set; }
        public int TotalOrder { get; set; }
        public int OrderMemberId { get; set; }
        public string OrderMemberName { get; set; }
        public string OrderMemberSurname { get; set; }
        public string OrderMemberEmail { get; set; }
        public string OrderMemberCompany { get; set; }
        public string OrderMemberTaxOffice { get; set; }
        public string OrderMemberTaxNumber { get; set; }
        public string OrderMemberGsm { get; set; }
        public string OrderMemberPhone { get; set; }
        public string OrderMemberCity { get; set; }
        public string OrderMemberDistrict { get; set; }
        public string OrderMemberAddress { get; set; }
        public string OrderNote { get; set; }
        public string OrderInvoiceName { get; set; }
        public string OrderInvoiceSurname { get; set; }
        public string OrderInvoiceEmail { get; set; }
        public string OrderInvoiceCompany { get; set; }
        public string OrderInvoiceTaxAdministration { get; set; }
        public string OrderInvoiceTaxNumber { get; set; }
        public string OrderInvoiceGsm { get; set; }
        public string OrderInvoicePhone { get; set; }
        public string OrderInvoiceCity { get; set; }
        public string OrderInvoiceDistrict { get; set; }
        public string OrderInvoiceAddress { get; set; }
        public string OrderInvoiceTrackingNumber { get; set; }
    }
}
