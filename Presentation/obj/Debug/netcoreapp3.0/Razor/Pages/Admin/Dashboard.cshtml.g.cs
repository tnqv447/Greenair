<<<<<<< HEAD
#pragma checksum "D:\Code\C#\Greenair\Presentation\Pages\Admin\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e42ea792aec7821498f3a0335945ce68f5416e9"
=======
#pragma checksum "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e42ea792aec7821498f3a0335945ce68f5416e9"
>>>>>>> e593428ee25b928af64e013df76e2bd8192fa2d1
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Presentation.Pages.Admin.Pages_Admin_Dashboard), @"mvc.1.0.razor-page", @"/Pages/Admin/Dashboard.cshtml")]
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
<<<<<<< HEAD
#line 1 "D:\Code\C#\Greenair\Presentation\Pages\_ViewImports.cshtml"
=======
#line 1 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\_ViewImports.cshtml"
>>>>>>> e593428ee25b928af64e013df76e2bd8192fa2d1
using Presentation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e42ea792aec7821498f3a0335945ce68f5416e9", @"/Pages/Admin/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d76d778d4c858045a827ae28cbb9bc28e1d5c23", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Dashboard : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
<<<<<<< HEAD
#line 3 "D:\Code\C#\Greenair\Presentation\Pages\Admin\Dashboard.cshtml"
=======
#line 3 "C:\Users\Administrator\Desktop\Greenair\presentation\Pages\Admin\Dashboard.cshtml"
>>>>>>> e593428ee25b928af64e013df76e2bd8192fa2d1
  
  Layout = "_LayoutAdmin";
	ViewData["Title"] = "Admin Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main-panel"">
  <div class=""content-wrapper"">
    <!-- Page Title Header Starts-->
    <div class=""row page-title-header"">
    </div>
    <!-- Page Title Header Ends-->

    <!-- Statistic Total -->
    <div class=""row"">
      <div class=""col-md-12 grid-margin"">
        <div class=""card"">
          <div class=""card-body"">
            <div class=""row"">
              <div class=""col-lg-3 col-md-6"">
                <div class=""d-flex"">
                  <div class=""wrapper"">
                    <h3 class=""mb-0 font-weight-semibold"">32,451</h3>
                    <h5 class=""mb-0 font-weight-medium text-primary"">Total Turnover</h5>
                  </div>
                  <div class=""wrapper my-auto ml-auto ml-lg-4"">
                    <canvas height=""50"" width=""100"" id=""stats-line-graph-1""></canvas>
                  </div>
                </div>
              </div>
              <div class=""col-lg-3 col-md-6"">
                <div class=""d-flex"">
                  <div c");
            WriteLiteral(@"lass=""wrapper"">
                    <h3 class=""mb-0 font-weight-semibold"">32,451</h3>
                    <h5 class=""mb-0 font-weight-medium text-primary"">Number Of Flights</h5>
                  </div>
                  <div class=""wrapper my-auto ml-auto ml-lg-4"">
                    <canvas height=""50"" width=""100"" id=""stats-line-graph-2""></canvas>
                  </div>
                </div>
              </div>
              <div class=""col-lg-3 col-md-6"">
                <div class=""d-flex"">
                  <div class=""wrapper"">
                    <h3 class=""mb-0 font-weight-semibold"">32,451</h3>
                    <h5 class=""mb-0 font-weight-medium text-primary"">Number Of Tickets</h5>
                  </div>
                  <div class=""wrapper my-auto ml-auto ml-lg-4"">
                    <canvas height=""50"" width=""100"" id=""stats-line-graph-3""></canvas>
                  </div>
                </div>
              </div>
              <div class=""col-lg-3 col-md-6"">
      ");
            WriteLiteral(@"          <div class=""d-flex"">
                  <div class=""wrapper"">
                    <h3 class=""mb-0 font-weight-semibold"">32,451</h3>
                    <h5 class=""mb-0 font-weight-medium text-primary"">Number Of Booking</h5>
                  </div>
                  <div class=""wrapper my-auto ml-auto ml-lg-4"">
                    <canvas height=""50"" width=""100"" id=""stats-line-graph-4""></canvas>
                  </div>
                </div>
              </div>            
            </div>
          </div>
        </div>
      </div>
    </div>
   <!--End Statistic -->
   
   <!-- Satistic diagram -->
    <div class=""row"">
              <div class=""col-md-12 grid-margin stretch-card"">
                <div class=""card"">
                  <div class=""card-body"">
                    <h4 class=""card-title mb-0"">Sales Statistics Overview</h4>
                    <div class=""d-flex flex-column flex-lg-row"">
                      <p>Lorem ipsum is placeholder text commonly used</");
            WriteLiteral(@"p>
                      <ul class=""nav nav-tabs sales-mini-tabs ml-lg-auto mb-4 mb-md-0"" role=""tablist"">
                        <li class=""nav-item"">
                          <a class=""nav-link active"" id=""sales-statistics_switch_1"" data-toggle=""tab"" role=""tab"" aria-selected=""true"">1D</a>
                        </li>
                        <li class=""nav-item"">
                          <a class=""nav-link"" id=""sales-statistics_switch_2"" data-toggle=""tab"" role=""tab"" aria-selected=""false"">5D</a>
                        </li>
                        <li class=""nav-item"">
                          <a class=""nav-link"" id=""sales-statistics_switch_3"" data-toggle=""tab"" role=""tab"" aria-selected=""false"">1M</a>
                        </li>
                        <li class=""nav-item"">
                          <a class=""nav-link"" id=""sales-statistics_switch_4"" data-toggle=""tab"" role=""tab"" aria-selected=""false"">1Y</a>
                        </li>
                      </ul>
                    </div");
            WriteLiteral(@">
                    <div class=""d-flex flex-column flex-lg-row"">
                      <div class=""data-wrapper d-flex mt-2 mt-lg-0"">
                        <div class=""wrapper pr-5"">
                          <h5 class=""mb-0"">Total Cost</h5>
                          <div class=""d-flex align-items-center"">
                            <h4 class=""font-weight-semibold mb-0"">15,263</h4>
                            <small class=""ml-2 text-gray d-none d-lg-block""><b>89.5%</b> of 20,000 Total</small>
                          </div>
                        </div>
                        <div class=""wrapper"">
                          <h5 class=""mb-0"">Total Revenue</h5>
                          <div class=""d-flex align-items-center"">
                            <h4 class=""font-weight-semibold mb-0"">$753,098</h4>
                            <small class=""ml-2 text-gray d-none d-lg-block""><b>10.5%</b> of 20,000 Total</small>
                          </div>
                        </div>
         ");
            WriteLiteral(@"             </div>
                      <div class=""ml-lg-auto"" id=""sales-statistics-legend""></div>
                    </div>
                    <canvas class=""mt-5"" height=""120"" id=""sales-statistics-overview""></canvas>
                  </div>
                </div>
              </div>
    </div>
    <!-- ENd Satistic diagram  -->

    <!-- List Top Route -->
    <div class=""row"">
      <div class=""col-md-12 grid-margin"">
        <div class=""card"">
          <div class=""card-body"">
            <div class=""d-flex justify-content-between"">
              <h2 class=""card-title mb-0"">Top 10 Route</h2>
              <a href=""#""><small>Show All</small></a>
            </div>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Est quod cupiditate esse fuga</p>
            <div class=""table-responsive"">
              <table class=""table table-striped table-hover"">
                <thead>
                  <tr>
                    <th>Route ID</th>
                   ");
            WriteLiteral(@" <th>Origin</th>
                    <th>Origin Airport</th>
                    <th>Destination</th>
                    <th>Destination Port</th>
                  </tr>
                </thead>
                <tbody>
                  <tr>
                    <td>001</td>
                    <td>Hồ Chí Minh City</td>
                    <td>Tân Sơn Nhất</td>
                    <td>Hà Nội</td>
                    <td>Nội Bài</td>
                  </tr>
                </tbody>
              </table>
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- End List Top Route -->        
  </div>
  <!-- content-wrapper ends -->
</div>
<!-- main-panel ends -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Presentation.Pages.Admin.DashboardModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentation.Pages.Admin.DashboardModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentation.Pages.Admin.DashboardModel>)PageContext?.ViewData;
        public Presentation.Pages.Admin.DashboardModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
