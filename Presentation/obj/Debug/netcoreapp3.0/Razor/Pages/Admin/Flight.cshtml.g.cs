#pragma checksum "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db7099282c26856600c82fd276da6d1038488a9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Presentation.Pages.Admin.Pages_Admin_Flight), @"mvc.1.0.razor-page", @"/Pages/Admin/Flight.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\_ViewImports.cshtml"
using Presentation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db7099282c26856600c82fd276da6d1038488a9d", @"/Pages/Admin/Flight.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d76d778d4c858045a827ae28cbb9bc28e1d5c23", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Flight : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("SearchFlight"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search Here"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "searchString", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
  
  Layout = "_LayoutAdmin";
	ViewData["Title"] = "Admin Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main-panel"">
  <div class=""content-wrapper"">
     <!-- row button create -->
    <div class=""row"">
      <div class=""col-lg-12 stretch-card"">
        <a href=""#CreateFlightForm"" data-toggle=""modal"" id=""btCreateFlight"" type=""button"" class=""btn  btn-primary btn-lg btn-inverse-*"">
          <i class=""mdi mdi-upload""></i>Create Flight
        </a>
      </div>
    </div>
    <!-- row table -->
    <div class=""row"">
      <div class=""col-lg-12 stretch-card"">
        <div class=""card"">
          <div class=""card-body"">
            <div class=""form-group row"">
              <div class=""col-sm-7""></div>
              <div class=""col-sm-5"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db7099282c26856600c82fd276da6d1038488a9d6271", async() => {
                WriteLiteral("\r\n                  <div class=\"input-group\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "db7099282c26856600c82fd276da6d1038488a9d6598", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 27 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchString);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <button type=\"submit\" id=\"btsubmitSearchFlight\" class=\"btn btn-icons btn-rounded btn-outline-primary\"><i class=\"fa fa-search\"></i></button>\r\n                  </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            <h3 align=""center"">List of Flights </h3>
            <table class=""table table-bordered table-striped table-hover"" id=""TableFlight"">
            <thead>
              <tr>
                <th>ID</th>
                <th>Status</th>
                <th>Plane ID</th>
                <th>Action</th>
              </tr>
            </thead>
            <tbody> 
");
#nullable restore
#line 44 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
               foreach (var item in Model.ListFlights){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                <!-- <tr id=\"");
#nullable restore
#line 46 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
                        Write(item.FlightId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"list-Flight\"> -->\r\n                  <td>");
#nullable restore
#line 47 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
                 Write(item.FlightId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td>");
#nullable restore
#line 48 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
                 Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td>");
#nullable restore
#line 49 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
                 Write(item.PlaneId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td> \r\n                    <button");
            BeginWriteAttribute("id", "  id=\"", 1981, "\"", 2001, 1);
#nullable restore
#line 51 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
WriteAttributeValue("", 1987, item.FlightId, 1987, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#DetailFlightForm\"  type=\"button\" class=\"btn btn-info btn-sm  btn-rounded DetailFlight\"><i class=\"fa fa-vcard-o\"></i></button>\r\n                    <button");
            BeginWriteAttribute("id", "  id=\"", 2191, "\"", 2211, 1);
#nullable restore
#line 52 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
WriteAttributeValue("", 2197, item.FlightId, 2197, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#EditFlightForm\"  type=\"button\" class=\"btn btn-dark btn-sm  btn-rounded EditFlight\"><i class=\"fa fa-cog\"></i></button>\r\n                    <button");
            BeginWriteAttribute("id", "  id=\"", 2393, "\"", 2413, 1);
#nullable restore
#line 53 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
WriteAttributeValue("", 2399, item.FlightId, 2399, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-danger btn-sm  btn-rounded DeleteFlight\"><i class=\"fa fa-times\" ></i></button>\r\n                  </td>\r\n                </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
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
    <!-- end table Flight  -->

  </div> 
  <!-- end content_warper -->
  
</div>
<!-- end main body -->


<!--detail flight form  -->
<div class=""modal fade"" id=""DetailFlightForm"" role=""dialog"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"">
        <div class=""modal-content"" >
            <div class=""modal-header"" style="" background-color:aliceblue;"">
                <h4 class=""modal-title"" style=""margin: 10px 0 10px 510px; color:#000; font-weight: bold;font-size:34"">Detail Flight</h4>
            </div>
		    <div class=""model-body"" style=""margin: 15px"">
          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db7099282c26856600c82fd276da6d1038488a9d14393", async() => {
                WriteLiteral(@"
				    <p style=""font-weight:600"" class=""card-description""> Flight info </p>
            <div class=""row"">
              <div class=""col-md-4"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Flight ID</label>
                  <div class=""col-sm-9"">
                    <span id=""DetailFlight-flightid""></span>
                  </div>
                </div>
              </div>
              <div class=""col-md-4"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Plane ID</label>
                  <div class=""col-sm-9"">
                    <span id=""DetailFlight-planeid""></span>
                  </div>
                </div>
              </div>
              <div class=""col-md-4"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Status</label>
                  <div class=""col-sm-9"">
                    <span id=""DetailFlight-");
                WriteLiteral(@"status""></span>
                  </div>
                </div>
              </div>
            </div> 
            <p style=""font-weight:600"" class=""card-description""> Flight detail </p>
            <div id=""DetailFlight-context""></div>

            
          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
		    </div>
        <div class=""model-footer"" style=""margin: 15px"">
          <div class=""row"" style="" display: flex; justify-content: flex-end;"">
              <button class=""btn btn-light"" data-dismiss=""modal""><b>Back to list</b></button>
            </div>
        </div>
      </div>    
    </div>
</div>

<!--edit flight form  -->
<div class=""modal fade"" id=""EditFlightForm"" role=""dialog"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"">
        <div class=""modal-content"" >
            <div class=""modal-header"" style="" background-color:aliceblue;"">
                <h4 class=""modal-title"" style=""margin: 10px 0 10px 510px; color:#000; font-weight: bold;font-size:34"">Edit Flight</h4>
            </div>
		    <div class=""model-body"" style=""margin: 15px"">
          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db7099282c26856600c82fd276da6d1038488a9d17918", async() => {
                WriteLiteral(@"
            <input id=""EditFlight-flightid"" type=""text"" class=""form-control"" hidden/>
				    <p style=""font-weight:600"" class=""card-description""> Flight info </p>
            <div class=""row"">
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Plane ID</label>
                  <div class=""col-sm-9"">
                    <select class=""form-control form-control-lg"" id=""EditFlight-planeid"">
");
#nullable restore
#line 140 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
                       foreach (var item in Model.ListNamePlanes){

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db7099282c26856600c82fd276da6d1038488a9d18977", async() => {
#nullable restore
#line 141 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
                           Write(item);

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
#line 142 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
                      }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                  </div>
                </div>
              </div>
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Status</label>
                  <div class=""col-sm-9"">
                    <select class=""form-control form-control-lg"" id=""EditFlight-status"">
                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db7099282c26856600c82fd276da6d1038488a9d20797", async() => {
                    WriteLiteral("AVAILABLE");
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
                WriteLiteral("\r\n                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db7099282c26856600c82fd276da6d1038488a9d21837", async() => {
                    WriteLiteral("DISABLED");
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
                WriteLiteral(@"
                    </select>
                  </div>
                </div>
              </div>
            </div> 
            <p style=""font-weight:600"" class=""card-description""> Flight Detail </p>
            <div class=""row"">
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Plane ID</label>
                  <div class=""col-sm-9"">
                    
                  </div>
                </div>
              </div>
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Status</label>
                  <div class=""col-sm-9"">
                    
                  </div>
                </div>
              </div>
            </div>

            
          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
		    </div>
        <div class=""model-footer"" style=""margin: 15px"">
          <div class=""row"" style="" display: flex; justify-content: flex-end;"">
              <button class=""btn btn-light"" data-dismiss=""modal""><b>Back to list</b></button>
            </div>
        </div>
      </div>    
    </div>
</div>

<!--create flight form  đây là form thêm-->
<div class=""modal fade"" id=""CreateFlightForm"" role=""dialog"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"">
        <div class=""modal-content"" >
            <div class=""modal-header"" style="" background-color:aliceblue;"">
                <h4 class=""modal-title"" style=""margin: 10px 0 10px 510px; color:#000; font-weight: bold;font-size:34"">Create Flight</h4>
            </div>
		    <div class=""model-body"" style=""margin: 15px"">
          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db7099282c26856600c82fd276da6d1038488a9d25666", async() => {
                WriteLiteral(@"
            <input id=""CreateFlight-flightid"" type=""text"" class=""form-control"" hidden/>
				    <p style=""font-weight:600"" class=""card-description""> Flight info </p>
            <div class=""row"">
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Plane ID</label>
                  <div class=""col-sm-9"">
                    <select class=""form-control form-control-lg"" id=""CreateFlight-planeid"">
");
#nullable restore
#line 208 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
                       foreach (var item in Model.ListNamePlanes){

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db7099282c26856600c82fd276da6d1038488a9d26729", async() => {
#nullable restore
#line 209 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
                           Write(item);

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
#line 210 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
                      }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                  </div>
                </div>
              </div>
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Status</label>
                  <div class=""col-sm-9"">
                    <select class=""form-control form-control-lg"" id=""CreateFlight-status"">
                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db7099282c26856600c82fd276da6d1038488a9d28551", async() => {
                    WriteLiteral("AVAILABLE");
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
                WriteLiteral("\r\n                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db7099282c26856600c82fd276da6d1038488a9d29591", async() => {
                    WriteLiteral("DISABLED");
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
                WriteLiteral(@"
                    </select>
                  </div>
                </div>
              </div>
            </div> 
            <p style=""font-weight:600"" class=""card-description""> Flight Detail </p>
            <div id=""CreateFlight-context"">
              <input id=""CreateFlight-number"" type=""text"" class=""form-control"" value=""1"" hidden/>
              <div class=""row"">
                <div class=""col-md-4"">
                  <button  id=""CreateFlight-btadd"" type=""button"" class=""btn  btn-primary btn-md"">
                  <i class=""mdi mdi-upload""></i>Add</button>
                   <button  id=""CreateFlight-btdelete"" type=""button"" class=""btn btn-danger btn-md"">
                  <i class=""fa fa-times"" ></i>Remove</button>
                </div>
              </div>
              <div class =""row"">
                <div class=""col-md-4"">
                  <label class=""col-form-label"">Route ID</label>
                </div>
                <div class=""col-md-4"">
                  <la");
                WriteLiteral(@"bel class=""col-form-label"">Departure Date</label>
                </div>
                <div class=""col-md-4"">
                  <label class=""col-form-label"">Arrive Date</label>
                </div>
              </div>
              <div class=""row"" id=""CreateFlight-row1"">
                <div class=""col-md-4"">
                  <select class=""form-control form-control-lg"" id=""CreateFlight-routeid1"">
");
#nullable restore
#line 252 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
                       foreach (var item in Model.ListNameRoutes){

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db7099282c26856600c82fd276da6d1038488a9d32429", async() => {
#nullable restore
#line 253 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
                            Write(item);

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
#line 254 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Flight.cshtml"
                      }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                  </select>
                </div>
                <div class=""col-md-4"">
                  <input id=""CreateFlight-depdate1"" type=""date"" class=""form-control"" />
                </div>
                <div class=""col-md-4"">
                  <input id=""CreateFlight-arrdate1"" type=""date"" class=""form-control"" disabled/>
                </div>
              </div>
              <hr id=""CreateFlight-hr1"">
              
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t    </div>\r\n      </div>    \r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Presentation.Pages.Admin.FlightModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentation.Pages.Admin.FlightModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentation.Pages.Admin.FlightModel>)PageContext?.ViewData;
        public Presentation.Pages.Admin.FlightModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
