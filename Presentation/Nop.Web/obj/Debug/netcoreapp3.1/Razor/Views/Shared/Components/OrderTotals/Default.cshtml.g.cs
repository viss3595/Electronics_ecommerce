#pragma checksum "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6134c877a17a12053bcbfd62a4780a19889c9ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_OrderTotals_Default), @"mvc.1.0.view", @"/Views/Shared/Components/OrderTotals/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 8 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Boards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Checkout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Newsletter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.PrivateMessages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Vendors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6134c877a17a12053bcbfd62a4780a19889c9ad", @"/Views/Shared/Components/OrderTotals/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7654b745a4afa95f40d704ba2b1e9f7718148f30", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_OrderTotals_Default : Nop.Web.Framework.Mvc.Razor.NopRazorPage<OrderTotalsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"total-info\">\r\n    <table class=\"cart-total\">\r\n        <tbody>\r\n            <tr class=\"order-subtotal\">\r\n                <td class=\"cart-total-left\">\r\n                    <label>");
#nullable restore
#line 7 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                      Write(T("ShoppingCart.Totals.SubTotal"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                </td>\r\n                <td class=\"cart-total-right\">\r\n                    <span class=\"value-summary\">");
#nullable restore
#line 10 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                                           Write(Model.SubTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 13 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
             if (!string.IsNullOrEmpty(Model.SubTotalDiscount))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"order-subtotal-discount\">\r\n                    <td class=\"cart-total-left\">\r\n                        <label>");
#nullable restore
#line 17 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                          Write(T("ShoppingCart.Totals.SubTotalDiscount"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                    </td>\r\n                    <td class=\"cart-total-right\">\r\n                        <span class=\"value-summary\">");
#nullable restore
#line 20 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                                               Write(Model.SubTotalDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 23 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
             if (!Model.HideShippingTotal)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"shipping-cost\">\r\n                    <td class=\"cart-total-left\">\r\n                        <label>");
#nullable restore
#line 28 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                          Write(T("ShoppingCart.Totals.Shipping"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n");
#nullable restore
#line 29 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                         if (Model.RequiresShipping && !string.IsNullOrEmpty(Model.SelectedShippingMethod))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"selected-shipping-method\">");
#nullable restore
#line 31 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                                                              Write(T("ShoppingCart.Totals.Shipping.Method", Model.SelectedShippingMethod));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 32 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td class=\"cart-total-right\">\r\n");
#nullable restore
#line 35 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                         if (Model.RequiresShipping)
                        {
                            if (!string.IsNullOrEmpty(Model.Shipping))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"value-summary\">");
#nullable restore
#line 39 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                                                   Write(Model.Shipping);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 40 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>");
#nullable restore
#line 43 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                             Write(T("ShoppingCart.Totals.CalculatedDuringCheckout"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 44 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>");
#nullable restore
#line 48 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                             Write(T("ShoppingCart.Totals.Shipping.NotRequired"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 49 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 52 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
             if (!string.IsNullOrEmpty(Model.PaymentMethodAdditionalFee))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"additional-fees\">\r\n                    <td class=\"cart-total-left\">\r\n                        <label>");
#nullable restore
#line 57 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                          Write(T("ShoppingCart.Totals.PaymentMethodAdditionalFee"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                    </td>\r\n                    <td class=\"cart-total-right\">\r\n                        <span class=\"value-summary\">");
#nullable restore
#line 60 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                                               Write(Model.PaymentMethodAdditionalFee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 63 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
             if (Model.DisplayTaxRates && Model.TaxRates.Count > 0)
            {
                foreach (var taxRate in Model.TaxRates)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"tax-rate\">\r\n                    <td class=\"cart-total-left\">\r\n                        <label>");
#nullable restore
#line 70 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                          Write(string.Format(T("ShoppingCart.Totals.TaxRateLine").Text, taxRate.Rate));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                    </td>\r\n                    <td class=\"cart-total-right\">\r\n                        <span>");
#nullable restore
#line 73 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                         Write(taxRate.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 76 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
             if (Model.DisplayTax)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"tax-value\">\r\n                    <td class=\"cart-total-left\">\r\n                        <label>");
#nullable restore
#line 82 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                          Write(T("ShoppingCart.Totals.Tax"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                    </td>\r\n                    <td class=\"cart-total-right\">\r\n                        <span class=\"value-summary\">");
#nullable restore
#line 85 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                                               Write(Model.Tax);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 88 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
             if (!string.IsNullOrEmpty(Model.OrderTotalDiscount))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"discount-total\">\r\n                    <td class=\"cart-total-left\">\r\n                        <label>");
#nullable restore
#line 93 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                          Write(T("ShoppingCart.Totals.OrderTotalDiscount"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                    </td>\r\n                    <td class=\"cart-total-right\">\r\n                        <span class=\"value-summary\">");
#nullable restore
#line 96 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                                               Write(Model.OrderTotalDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 99 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
             if (Model.GiftCards.Count > 0)
            {
                foreach (var gc in Model.GiftCards)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"giftcard-summary\">\r\n                    <td class=\"cart-total-left\">\r\n                        <label>");
#nullable restore
#line 106 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                          Write(T("ShoppingCart.Totals.GiftCardInfo"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                        <span>");
#nullable restore
#line 107 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                         Write(T("ShoppingCart.Totals.GiftCardInfo.Code", gc.CouponCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 108 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                         if (Model.IsEditable)
                        {
                            //little hack here with empty "value" element

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"submit\"");
            BeginWriteAttribute("name", " name=\"", 4920, "\"", 4948, 2);
            WriteAttributeValue("", 4927, "removegiftcard-", 4927, 15, true);
#nullable restore
#line 111 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
WriteAttributeValue("", 4942, gc.Id, 4942, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\" \"");
            BeginWriteAttribute("title", " title=\"", 4959, "\"", 4986, 1);
#nullable restore
#line 111 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
WriteAttributeValue("", 4967, T("Common.Remove"), 4967, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"remove-gift-card-button\" />\r\n");
#nullable restore
#line 112 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"giftcard-remaining\">");
#nullable restore
#line 113 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                                                    Write(string.Format(T("ShoppingCart.Totals.GiftCardInfo.Remaining").Text, gc.Remaining));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n                    <td class=\"cart-total-right\">\r\n                        <span class=\"value-summary\">");
#nullable restore
#line 116 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                                               Write(gc.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 119 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
             if (Model.RedeemedRewardPoints > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"reward-points\">\r\n                    <td class=\"cart-total-left\">\r\n                        <label>");
#nullable restore
#line 125 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                          Write(string.Format(T("ShoppingCart.Totals.RewardPoints").Text, Model.RedeemedRewardPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                    </td>\r\n                    <td class=\"cart-total-right\">\r\n                        <span class=\"value-summary\">");
#nullable restore
#line 128 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                                               Write(Model.RedeemedRewardPointsAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 131 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"order-total\">\r\n                <td class=\"cart-total-left\">\r\n                    <label>");
#nullable restore
#line 134 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                      Write(T("ShoppingCart.Totals.OrderTotal"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                </td>\r\n                <td class=\"cart-total-right\">\r\n");
#nullable restore
#line 137 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                     if (!string.IsNullOrEmpty(Model.OrderTotal))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"value-summary\"><strong>");
#nullable restore
#line 139 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                                                       Write(Model.OrderTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\r\n");
#nullable restore
#line 140 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>");
#nullable restore
#line 143 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                         Write(T("ShoppingCart.Totals.CalculatedDuringCheckout"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 144 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 147 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
             if (Model.WillEarnRewardPoints > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"earn-reward-points\">\r\n                    <td class=\"cart-total-left\">\r\n                        <label>");
#nullable restore
#line 151 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                          Write(T("ShoppingCart.Totals.RewardPoints.WillEarn"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                    </td>\r\n                    <td class=\"cart-total-right\">\r\n                        <span class=\"value-summary\">");
#nullable restore
#line 154 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
                                               Write(string.Format(T("ShoppingCart.Totals.RewardPoints.WillEarn.Point").Text, Model.WillEarnRewardPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 157 "D:\Project\ecommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Shared\Components\OrderTotals\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderTotalsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
