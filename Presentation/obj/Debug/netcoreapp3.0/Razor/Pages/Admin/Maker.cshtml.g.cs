#pragma checksum "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad1f2703383bd686f338ec92d575e1b9584558c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Presentation.Pages.Admin.Pages_Admin_Maker), @"mvc.1.0.razor-page", @"/Pages/Admin/Maker.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\_ViewImports.cshtml"
using Presentation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad1f2703383bd686f338ec92d575e1b9584558c8", @"/Pages/Admin/Maker.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d76d778d4c858045a827ae28cbb9bc28e1d5c23", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Maker : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("EditPlane-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
  
  Layout = "_LayoutAdmin";
	ViewData["Title"] = "Admin Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main-panel"">
  <!-- Maker content-wrapper -->
  <div class=""content-wrapper"">
     <!-- row button create -->
    <div class=""row"">
      <div class=""col-lg-12 stretch-card"">
        <a href=""#CreateMakerForm"" data-toggle=""modal"" id=""btCreateMaker"" type=""button"" class=""btn  btn-primary btn-lg btn-inverse-*"">
          <i class=""mdi mdi-upload""></i>Create Maker
        </a>
      </div>
    </div>
    <!-- row table -->
    <div class=""row"">
      <div class=""col-lg-12 stretch-card"">
        <div class=""card"">
          <div class=""card-header"">
            <div class=""form-group row"">
              <div class=""col-sm-7""></div>
              <div class=""col-sm-5"">
                <div class=""input-group"">
                  <input type=""search"" class=""form-control"" placeholder=""Search Here"">
                  <button type=""button"" class=""btn btn-icons btn-rounded btn-outline-primary""><i class=""fa fa-search""></i></button>
                </div> 
              </div> 
         ");
            WriteLiteral(@"   </div>
          </div>
          <div class=""card-body"">
            <h3 align=""center"">List of Makers </h3>
            <table class=""table table-bordered table-striped table-hover"" id=""TableMaker"">
            <thead>
              <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Address</th>
                <th></th>
              </tr>
            </thead>
            <tbody>
              <!-- change to code later thua --> 
");
#nullable restore
#line 46 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
               foreach (var item in Model.ListMakers){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                <!-- <tr id=\"");
#nullable restore
#line 48 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
                        Write(item.MakerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"list-maker\"> -->\r\n                  <td>");
#nullable restore
#line 49 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
                 Write(item.MakerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td>");
#nullable restore
#line 50 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
                 Write(item.MakerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td>");
#nullable restore
#line 51 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
                 Write(item.Address.toString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td> \r\n                    <button");
            BeginWriteAttribute("id", "  id=\"", 1970, "\"", 1989, 1);
#nullable restore
#line 53 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
WriteAttributeValue("", 1976, item.MakerId, 1976, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#EditMakerForm\"  type=\"button\" class=\"btn btn-dark btn-sm  btn-rounded EditMaker\"><i class=\"fa fa-cog\"></i></button>\r\n                    <button");
            BeginWriteAttribute("id", "  id=\"", 2169, "\"", 2188, 1);
#nullable restore
#line 54 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
WriteAttributeValue("", 2175, item.MakerId, 2175, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-danger btn-sm  btn-rounded DeleteMaker\"><i class=\"fa fa-times\" ></i></button>\r\n                  </td>\r\n                </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
    <!-- end table maker  -->

  </div> 
  <!-- end content_warper -->

  <!-- Plane content-wrapper -->
  <div class=""content-wrapper"">
    <!-- row table -->
    <div class=""row"">
    <div class=""col-lg-9 stretch-card"">
      <div class=""card"">
        <div class=""card-body"">
          <h3 align=""center"">List of Planes </h3>
          <table class=""table table-bordered table-striped table-hover"" id=""TablePlane"">
           <thead>
            <tr>
              <th>Phane ID</th>
              <th>Seat Num</th>
              <th>Maker ID</th>
              <th></th>
            </tr>
           </thead>
           <tbody>
");
#nullable restore
#line 87 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
             foreach (var item in Model.ListPlanes){

#line default
#line hidden
#nullable disable
            WriteLiteral("              <tr>\r\n                <td>");
#nullable restore
#line 89 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
               Write(item.PlaneId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 90 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
               Write(item.SeatNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 91 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
               Write(item.MakerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> \r\n                  <button");
            BeginWriteAttribute("id", "  id=\"", 3365, "\"", 3384, 1);
#nullable restore
#line 93 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
WriteAttributeValue("", 3371, item.PlaneId, 3371, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#EditPlaneForm\"  type=\"button\" class=\"btn btn-dark btn-sm  btn-rounded EditPlane\"><i class=\"fa fa-cog\"></i></button>\r\n                  <button");
            BeginWriteAttribute("id", "  id=\"", 3562, "\"", 3581, 1);
#nullable restore
#line 94 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
WriteAttributeValue("", 3568, item.PlaneId, 3568, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-danger btn-sm  btn-rounded DeletePlane\"><i class=\"fa fa-times\" ></i></button>\r\n                </td>\r\n              </tr>\r\n");
#nullable restore
#line 97 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
          </table>
        </div>
      </div>
    </div>
    </div>

  </div>
  <!-- end content-wrapper -->

</div>
<!-- end main body -->

<!--create maker form  -->
<div class=""modal fade"" id=""CreateMakerForm"" role=""dialog"">
  <div class=""modal-dialog modal-dialog-centered modal-sm"">
    <div class=""modal-content"" >
      <div class=""modal-header"" style=""text-align:center !important; background-color:aliceblue;"">
        <h4 class=""modal-title"" style="" color:#000; font-weight: bold;font-size:34"">Create Maker</h4>
      </div>
		  <div class=""model-body"" style=""margin: 15px"">
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad1f2703383bd686f338ec92d575e1b9584558c812243", async() => {
                WriteLiteral(@"
          <div class=""form-group row"">
            <label class=""col-sm-3 col-form-label"">Name</label>
            <div class=""col-sm-9"">
              <input id=""CreateMaker-id"" type=""text"" class=""form-control""  placeholder=""Enter name"">
            </div>    
          </div>
          <div class=""form-group row"">
            <label class=""col-sm-3 col-form-label"">Address</label>
            <div class=""col-sm-9"">
              <input id=""CreateMaker-name"" type=""text"" class=""form-control"" placeholder=""Enter address"">
            </div>
          </div>
          <button id=""btsubmitCreateMaker"" type=""submit"" class=""btn btn-success mr-2"" ><b>Create</b></button>
          <button class=""btn btn-light"" data-dismiss=""modal""><b>Cancel</b></button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
		  </div>
    </div> 
  </div>
</div>

 <!-- edit maker form -->
<div class=""modal fade"" id=""EditMakerForm"" role=""dialog"">
  <div class=""modal-dialog modal-dialog-centered modal-sm"">
    <div class=""modal-content"" >
      <div class=""modal-header"" style=""text-align:center !important; background-color:aliceblue;"">
        <h4 class=""modal-title"" style="" color:#000; font-weight: bold;font-size:34"">Edit Maker</h4>
      </div>
      <div class=""model-body"" style=""margin: 15px"" id=""bodyEditMaker"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad1f2703383bd686f338ec92d575e1b9584558c814916", async() => {
                WriteLiteral(@"
          <input id=""EditMaker-id"" type=""hidden"" class=""form-control""   >
          <div class=""form-group row"">
            <label class=""col-sm-3 col-form-label"">Name</label>
            <div class=""col-sm-9"">
              <input id=""EditMaker-name"" type=""text"" class=""form-control""  placeholder=""Enter name"">
            </div>
            <span style=""color: red bold"" class=""z-mak-name""></span>
          </div>
          <div class=""form-group row"">
            <label class=""col-sm-3 col-form-label"">Address</label>
            <div class=""col-sm-9"">
              <input id=""EditMaker-address"" type=""text"" class=""form-control"" placeholder=""Enter address"">
            </div>
            <span style=""color: red bold"" class=""z-mak-address""></span>
          </div>
          <button  id=""btsubmitEditMaker"" class=""btn btn-success mr-2""><b>Update</b></button>
          <button class=""btn btn-light"" data-dismiss=""modal""><b>Cancel</b></button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
      </div>
    </div>    
  </div>
</div>

<!--create plane form  -->
<div class=""modal fade"" id=""CreatePlaneForm"" role=""dialog"">
  <div class=""modal-dialog modal-dialog-centered modal-sm"">
    <div class=""modal-content"" >
      <div class=""modal-header"" style=""text-align:center !important; background-color:aliceblue;"">
        <h4 class=""modal-title"" style="" color:#000; font-weight: bold;font-size:34"">Create Plane</h4>
      </div>
		  <div class=""model-body"" style=""margin: 15px"">
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad1f2703383bd686f338ec92d575e1b9584558c817783", async() => {
                WriteLiteral(@"
          <div class=""form-group row"">
            <label class=""col-sm-3 col-form-label"">SeatNum</label>
            <div class=""col-sm-9"">
              <input id=""CreatePlane-seatnum"" type=""text"" class=""form-control""  placeholder=""Enter seat number"">
            </div>    
          </div>
          <div class=""form-group row"">
            <label class=""col-sm-3 col-form-label"">Maker ID</label>
            <div class=""col-sm-9"">
              <select class=""form-control form-control-lg"" id=""CreatePlane-makerid"">
");
#nullable restore
#line 191 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
                 foreach (var item in Model.ListMakers){

#line default
#line hidden
#nullable disable
                WriteLiteral("                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad1f2703383bd686f338ec92d575e1b9584558c818869", async() => {
#nullable restore
#line 192 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
                     Write(item.MakerId);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 193 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"              </select>
            </div>
          </div>
          <button id=""btsubmitCreatePlane"" type=""submit"" class=""btn btn-success mr-2"" ><b>Create</b></button>
          <button class=""btn btn-light"" data-dismiss=""modal""><b>Cancel</b></button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
		  </div>
    </div> 
  </div>
</div>

 <!-- edit Plane form -->
<div class=""modal fade"" id=""EditPlaneForm"" role=""dialog"">
  <div class=""modal-dialog modal-dialog-centered modal-sm"">
    <div class=""modal-content"" >
      <div class=""modal-header"" style=""text-align:center !important; background-color:aliceblue;"">
        <h4 class=""modal-title"" style="" color:#000; font-weight: bold;font-size:34"">Edit Plane</h4>
      </div>
      <div class=""model-body"" style=""margin: 15px"" id=""bodyEditPlane"">
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad1f2703383bd686f338ec92d575e1b9584558c822134", async() => {
                WriteLiteral(@"
          <div class=""form-group row"">
            <label class=""col-sm-3 col-form-label"">SeatNum</label>
            <div class=""col-sm-9"">
              <input id=""EditPlane-seatnum"" type=""text"" class=""form-control""  placeholder=""Enter seat number"">
            </div>    
          </div>
          <div class=""form-group row"">
            <label class=""col-sm-3 col-form-label"">Maker ID</label>
            <div class=""col-sm-9"">
              <select class=""form-control form-control-lg"" id=""EditPlane-makerid"">
                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad1f2703383bd686f338ec92d575e1b9584558c822961", async() => {
                    WriteLiteral("abc");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 225 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
                 foreach (var item in Model.ListMakers){

#line default
#line hidden
#nullable disable
                WriteLiteral("                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad1f2703383bd686f338ec92d575e1b9584558c824654", async() => {
#nullable restore
#line 226 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
                     Write(item.MakerId);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 227 "C:\Users\Administrator\Desktop\Greenair-1\Presentation\Pages\Admin\Maker.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"              </select>
            </div>
          </div>
          <button id=""btsubmitCreatePlane"" type=""submit"" class=""btn btn-success mr-2"" ><b>Create</b></button>
          <button class=""btn btn-light"" data-dismiss=""modal""><b>Cancel</b></button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n      </div>\r\n    </div>    \r\n  </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Presentation.Pages.Admin.MakerModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentation.Pages.Admin.MakerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentation.Pages.Admin.MakerModel>)PageContext?.ViewData;
        public Presentation.Pages.Admin.MakerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
