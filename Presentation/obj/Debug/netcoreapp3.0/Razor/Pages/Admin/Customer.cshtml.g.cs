#pragma checksum "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Customer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acb3c88440b04e6918cb01499a2144ca34c642f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Presentation.Pages.Admin.Pages_Admin_Customer), @"mvc.1.0.razor-page", @"/Pages/Admin/Customer.cshtml")]
namespace Presentation.Pages.Admin
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
#line 1 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\_ViewImports.cshtml"
using Presentation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acb3c88440b04e6918cb01499a2144ca34c642f2", @"/Pages/Admin/Customer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d76d778d4c858045a827ae28cbb9bc28e1d5c23", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Customer : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Customer.cshtml"
  
  Layout = "_LayoutAdmin";
	ViewData["Title"] = "Admin Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main-panel"">
  <div class=""content-wrapper"">
     <!-- row search -->
    <div class=""row"">
    </div>
    <!-- row table -->
    <div class=""row"">
    <div class=""col-lg-12 stretch-card"">
      <div class=""card"">
        <div class=""card-body"">
          <h3 align=""center"">List of Customers </h3>
          <table class=""table table-bordered table-striped table-hover"">
           <thead>
            <tr>
              <th>ID</th>
              <th>Name</th>
              <th>Birthday</th>
              <th>Phone</th>
              <th>Address</th>
              <th>Email</th>
              <th>Status</th>
              <th></th>
            </tr>
           </thead>
           <tbody>
             <!-- change to code later -->
            <!-- ");
#nullable restore
#line 33 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Customer.cshtml"
                  foreach (var item in Model.ListCus){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"              <tr>
                <td>item.ID</td>
                <td>item.Name</td>
                <td>item.Birthday</td>
                <td>item.Phone</td>
                <td>item.Address</td>
                <td>item.Email</td>
                <td><label class=""badge badge-warning"">item.Status</label></td>
                <td> 
                  <button type=""button"" class=""btn btn-dark btn-sm  btn-rounded"" ><i class=""fa fa-cog""></i></button>
                  <button type=""button"" class=""btn btn-danger btn-sm  btn-rounded""><i class=""fa fa-times""></i></button>
                </td>
              </tr>
");
#nullable restore
#line 47 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Customer.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(" -->\r\n            </tbody>\r\n          </table>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    </div> \r\n  </div> \r\n  <!-- end content_warper -->\r\n</div>\r\n<!-- end main body -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Presentation.Pages.Admin.CustomerModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentation.Pages.Admin.CustomerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentation.Pages.Admin.CustomerModel>)PageContext?.ViewData;
        public Presentation.Pages.Admin.CustomerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
