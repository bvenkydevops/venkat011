#pragma checksum "J:\PoojaStores13042023\trunk\PoojaStores\Views\Home\FAQs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d891276777aa1900045f77e235c7562ac9410101"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FAQs), @"mvc.1.0.view", @"/Views/Home/FAQs.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "J:\PoojaStores13042023\trunk\PoojaStores\Views\_ViewImports.cshtml"
using PoojaStores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "J:\PoojaStores13042023\trunk\PoojaStores\Views\_ViewImports.cshtml"
using PoojaStores.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d891276777aa1900045f77e235c7562ac9410101", @"/Views/Home/FAQs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16fd5e81157aaadf292c89301cd5c1be8ee9a165", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_FAQs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container mb-4"">    <h2>Frequently Asked Questions</h2>    <div class=""accordion"">        <div class=""accordion-item"">            <button id=""accordion-button-1"" aria-expanded=""false"">                <span class=""accordion-title"">How can I place an order on this portal?</span>                <span class=""icon"" aria-hidden=""true""></span>            </button>            <div class=""accordion-content"">                <p>                    You need to create an account to order from our portal. Register with us by providing your basic details like your name, phone number, and email.                </p>            </div>        </div>        <div class=""accordion-item"">            <button id=""accordion-button-2"" aria-expanded=""false"">                <span class=""accordion-title"">Do Divine Precincts sell high-quality products?</span>                <span class=""icon"" aria-hidden=""true""></span>            </button>            <div class=""accordion-content"">                <p>       ");
            WriteLiteral(@"             Yes, Divine Precincts only sell 100% high-quality Pooja Products to make your worshipping divine. We outsource the entire manufacturing process to the Original Equipment Manufacturer (OEM) and each category of products is manufactured from different parts of India where only standardized materials are used.                </p>            </div>        </div>        <div class=""accordion-item"">            <button id=""accordion-button-3"" aria-expanded=""false"">                <span class=""accordion-title"">What payment methods are accepted at Divine Precincts?</span>                <span class=""icon"" aria-hidden=""true""></span>            </button>            <div class=""accordion-content"">                <p>                    We accept payments through all major debit & credit cards. You can pay the amount while placing the order itself.                </p>            </div>        </div>        <div class=""accordion-item"">            <button id=""accordion-button-4"" aria-expanded=""fa");
            WriteLiteral(@"lse"">                <span class=""accordion-title"">Where can I track all my orders?</span>                <span class=""icon"" aria-hidden=""true""></span>            </button>            <div class=""accordion-content"">                <p>                    The portal doesn’t have a separate section to track the orders. You will receive a tracking ID number that will redirect you to check your order status.                </p>            </div>        </div>        <div class=""accordion-item"">            <button id=""accordion-button-6"" aria-expanded=""false"">                <span class=""accordion-title"">How and where can I cancel a product?</span>                <span class=""icon"" aria-hidden=""true""></span>            </button>            <div class=""accordion-content"">                <p>                    You can cancel a product under any circumstance, if only when the product is not dispatched. To cancel a product, please find the nearest shipping office and provide invoice number details to ");
            WriteLiteral(@"initiate the cancellation process.                </p>            </div>        </div>        <div class=""accordion-item"">            <button id=""accordion-button-7"" aria-expanded=""false"">                <span class=""accordion-title"">Are refunds allowed in every case of return policy?</span>                <span class=""icon"" aria-hidden=""true""></span>            </button>            <div class=""accordion-content"">                <p>                    Yes, we allow refunds in every case of the return policy, and the refunds are processed after the product’s successful return.                </p>            </div>        </div>        <div class=""accordion-item"">            <button id=""accordion-button-7"" aria-expanded=""false"">                <span class=""accordion-title"">How and when can I replace a product?</span>                <span class=""icon"" aria-hidden=""true""></span>            </button>            <div class=""accordion-content"">                <p>                    Yes, your sa");
            WriteLiteral(@"tisfaction is our topmost priority and you can replace the products if you feel they fall below the quality standards or are damaged. Share the product images with the seller’s WhatsApp mobile number displayed on the goods to initiate this process.                </p>            </div>        </div>    </div></div><script>    const items = document.querySelectorAll('.accordion button');    function toggleAccordion() {        const itemToggle = this.getAttribute('aria-expanded');        for (i = 0; i < items.length; i++) {            items[i].setAttribute('aria-expanded', 'false');        }        if (itemToggle == 'false') {            this.setAttribute('aria-expanded', 'true');        }    }    items.forEach((item) => item.addEventListener('click', toggleAccordion));</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
