#pragma checksum "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23ea5513d040e83165460a21026e8c5768da24cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Presentation.Pages.Pages_Account), @"mvc.1.0.razor-page", @"/Pages/Account.cshtml")]
namespace Presentation.Pages
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
#line 1 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\_ViewImports.cshtml"
using Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ea5513d040e83165460a21026e8c5768da24cc", @"/Pages/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d76d778d4c858045a827ae28cbb9bc28e1d5c23", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Account : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
  
	if(HttpContext.Session.GetString("userid") == null)
		Response.Redirect("Index");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""hero-wrap js-fullheight"" style=""background-image: url('images/bg_1.jpg');"">
	<div class=""overlay""></div>
	<div class=""container"">
		<div class=""row no-gutters slider-text js-fullheight align-items-center justify-content-start"" data-scrollax-parent=""true"">
			<div class=""col-md-9 ftco-animate mb-5 pb-5 text-center text-md-left"" data-scrollax="" properties: { translateY: '70%' }"">
				<h1 class=""mb-4"" data-scrollax=""properties: { translateY: '30%', opacity: 1.6 }"">Discover <br>A new Place</h1>
				<p data-scrollax=""properties: { translateY: '30%', opacity: 1.6 }"">Find great places to stay, eat, shop, or visit from local experts</p>
			</div>
		</div>
	</div>
</div>
<section class=""ftco-section"">
	<div class=""container"">
		<div class=""row"">
			<div class=""col-md-3"" style=""border-right:1px solid #0f0f0f3b"">
				<div class=""nav nav-pills flex-column justify-content-center text-center"" id=""myTab"" role=""tablist"" aria-orientation=""vertical"">
					<a class=""nav-link active"" id=""Account-tab"" ");
            WriteLiteral(@"data-toggle=""pill"" href=""#account-tab"" role=""tab"" aria-controls=""account"" aria-selected=""true"">Your account</a>
					<a class=""nav-link"" id=""Identify-tab"" data-toggle=""pill"" href=""#profile-tab"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">Your profile</a>
					<a class=""nav-link"" id=""Ticket-tab"" data-toggle=""pill"" href=""#ticket-tab"" role=""tab"" aria-controls=""ticket"" aria-selected=""false"">Your tickets</a>
				</div>
			</div>
			<div class=""col-md-9"">
				<div class=""tab-content"" id=""myTabContent"">
					<div class=""tab-pane fade show active"" id=""account-tab""  role=""tabpanel"" aria-labelledby=""account"">
						<div style=""  border-bottom: 1px solid #0f0f0f3b;"" class=""row"">
							<div class=""account-title col-md-8"">
								<h2>Account Settings</h2>
							</div>
						</div>
						<div style=""margin-top: 30px"" class=""row"">
							<div class=""heading  col-md-8"">
								<h3>Username</h3>
							</div>
							<!-- <div class=""col-md-4"">
								<button id=""save-user"" class=""btn btn-pr");
            WriteLiteral(@"imary save-account hidden"">Save Changes</button>
								<button id=""close-user"" class=""btn close-account hidden"">Cancel</button>
								<button id=""open-user"" class=""btn open-account"">Edit</button>
							</div> -->
						</div>
						<div class=""row user-show "">
							<div class=""col-md-6"">
								<div class=""form-group"" style=""padding-left:15px"">
									<label style=""font-weight:600"">Username:</label>
									<div id=""text-username"">
										");
#nullable restore
#line 52 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
                                   Write(ViewData["username"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									</div>
								</div>	
							</div>		
						</div>
						<div class=""row user-field hidden"">
							<div class=""col-md-4"">
								<div class=""form-group"" style=""padding-left:15px"">
									<label style=""font-weight:600"">Username:</label>
									<input type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\'", 2998, "\'", 3027, 1);
#nullable restore
#line 61 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
WriteAttributeValue("", 3006, ViewData["username"], 3006, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""Username"">
									<span class=""hidden"" style=""color:red"" id=""err-user"">Username must be 5-14 characters, start with a letter and only letters and numbers</span>
								</div>
							</div>		
						</div>
						<div class=""row"">
							<div class=""heading col-md-8"" >
								<h3>Password</h3>
							</div>
							<div class=""col-md-4"">
								<button id=""save-pass"" class=""btn btn-primary save-account hidden"">Save Changes</button>
								<button id=""close-pass"" class=""btn close-account hidden"">Cancel</button>
								<button id=""open-pass""class=""btn open-account"">Edit</button>
							</div>
						</div>
						<div class=""row"" id=""pass-show"">
							<div class=""col-md-6"">
								<div class=""form-group"" style=""padding-left:15px"">
									<label style=""font-weight:600"">Password:</label>
									<div id=""text-password"">********</div>
								</div>
							</div>
						</div>
						<div class=""row hidden"" id=""pass-field"">
							<div class=""col-md-5"" style=""padding-left:15px"">
	");
            WriteLiteral("\t\t\t\t\t\t\t<div class=\"form-group\" >\r\n\t\t\t\t\t\t\t\t\t<label style=\"font-weight:600\">Current password</label>\r\n\t\t\t\t\t\t\t\t\t<input type=\"password\" disabled class=\"form-control\"  id=\"old-pass\">\r\n\t\t\t\t\t\t\t\t\t<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\'", 4260, "\'", 4289, 1);
#nullable restore
#line 89 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
WriteAttributeValue("", 4268, ViewData["password"], 4268, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""check-pass"">
									<span class=""hidden"" style=""color:red"" id=""err-old-pass"">Your current password is not correct</span>
								</div>
							</div>
							<div class=""col-md-5"">
								<div class=""form-group"">
									<label style=""font-weight:600"">Enter a new password</label>
									<input type=""password"" class=""form-control"" id=""new-pass"">
									<span class=""hidden"" style=""color:red"" id=""err-new-pass"">Must be 5-20 characters, contains at least one lower-case letter, one number</span>
								</div>
							</div>
							<div class=""col-md-5"" style=""padding-top: 15px"">
								<div class=""form-group"">
									<label style=""font-weight:600"">Repeat new password</label>
									<input type=""password"" class=""form-control""   id=""re-pass"">
									<span class=""hidden"" style=""color:red"" id=""err-re-pass"">Not correct with new password</span>
								</div>
									
							</div>
						</div>
					</div>
					<div class=""tab-pane fade"" id=""profile-tab""  role=""tabpanel"" aria-labe");
            WriteLiteral(@"lledby=""profile"">
						<div style=""  border-bottom: 1px solid #0f0f0f3b;"" class=""row"">
							<div class=""account-title col-md-8"">
								<h2>Profile Settings</h2>
							</div>
						</div>
						<div style=""margin-top: 30px"" class=""row"">
							<div class=""heading  col-md-8"">
								<h3>About you</h3>
							</div>
							<div class=""col-md-4"">
								<button id=""profile_s"" class=""btn btn-primary save hidden"">Save Changes</button>
								<button id=""profile_cl"" class=""btn cancel hidden"">Cancel</button>
								<button id=""profile_op""class=""btn open"">Edit</button>
							</div>
						</div>
						<div class=""row pro-show "">
							<div class=""col-md-6"">
								<div class=""form-group"" style=""padding-left:15px"">
									<label style=""font-weight:600"">Name:</label>
									<div class=""name""></div>
								</div>
							</div>
							<div class=""col-md-6"">
								<div class=""form-group"" style=""padding-left:15px"">
									<label style=""font-weight:600"">Date of birth</label>
			");
            WriteLiteral("\t\t\t\t\t\t<div class=\"birth_day\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 137 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
                                   Write(ViewData["birthdate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									</div>
								</div>
							</div>
						</div>
						<div class=""row pro-field hidden"">
							<div class=""col-md-4"">
								<div class=""form-group"">
									<label style=""font-weight:600"">First name</label>
									<input id=""firstName"" type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\'", 6695, "\'", 6725, 1);
#nullable restore
#line 146 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
WriteAttributeValue("", 6703, ViewData["firstname"], 6703, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" >
									<span class=""hidden"" style=""color:red"" id=""err-first-name"">Your first name is incorrect</span>									
								</div>
							</div>
							<div class=""col-md-4"" style=""padding-left:15px"">
								<div class=""form-group"" >
									<label style=""font-weight:600"">Last name</label>
									<input id=""lastName"" type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\'", 7088, "\'", 7117, 1);
#nullable restore
#line 153 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
WriteAttributeValue("", 7096, ViewData["lastname"], 7096, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
									<span class=""hidden"" style=""color:red"" id=""err-last-name"">Your last name is incorrect</span>
								</div>
							</div>
						
							<div class=""col-md-4"">
								<div class=""form-group"">
									<label style=""font-weight:600"">Date of birth</label>
									<input type=""text"" class=""form-control birth_date""");
            BeginWriteAttribute("value", " value=\'", 7450, "\'", 7480, 1);
#nullable restore
#line 161 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
WriteAttributeValue("", 7458, ViewData["birthdate"], 7458, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
									<span class=""hidden"" style=""color:red"" id=""err-birth-date"">The value is incorrect</span>
									
								</div>
							</div>
						</div>
						<div class=""row"">
							<div class=""heading col-md-8"" >
								<h3>Address</h3>
							</div>
							<div class=""col-md-4"">
								<button id=""add_s"" class=""btn btn-primary save hidden"">Save Changes</button>
								<button id=""add_cl"" class=""btn cancel hidden"">Cancel</button>
								<button id=""add_op"" class=""btn open"">Edit</button>
							</div>
						</div>
						<div class=""row"" id=""address-show"">
							<div class=""col-md-4"">
								<div class=""form-group"" style=""padding-left:15px"">
									<label style=""font-weight:600"">Num</label>
									<div id=""text-num"">");
#nullable restore
#line 181 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
                                                  Write(ViewData["num"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"col-md-4\">\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\" style=\"padding-left:15px\">\r\n\t\t\t\t\t\t\t\t\t<label style=\"font-weight:600\">Street</label>\r\n\t\t\t\t\t\t\t\t\t<div id=\"text-street\">");
#nullable restore
#line 187 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
                                                     Write(ViewData["street"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"col-md-4\">\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\" style=\"padding-left:15px\">\r\n\t\t\t\t\t\t\t\t\t<label style=\"font-weight:600\">District</label>\r\n\t\t\t\t\t\t\t\t\t<div id=\"text-district\">");
#nullable restore
#line 193 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
                                                       Write(ViewData["district"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"col-md-4\">\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\" style=\"padding-left:15px\">\r\n\t\t\t\t\t\t\t\t\t<label style=\"font-weight:600\">City</label>\r\n\t\t\t\t\t\t\t\t\t<div id=\"text-city\">");
#nullable restore
#line 199 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
                                                   Write(ViewData["city"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"col-md-4\">\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\" style=\"padding-left:15px\">\r\n\t\t\t\t\t\t\t\t\t<label style=\"font-weight:600\">State</label>\r\n\t\t\t\t\t\t\t\t\t<div id=\"text-state\">");
#nullable restore
#line 205 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
                                                    Write(ViewData["state"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"col-md-4\">\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\" style=\"padding-left:15px\">\r\n\t\t\t\t\t\t\t\t\t<label style=\"font-weight:600\">Country</label>\r\n\t\t\t\t\t\t\t\t\t<div id=\"text-country\">");
#nullable restore
#line 211 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
                                                      Write(ViewData["country"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
								</div>
							</div>
						</div>
						<div class=""row hidden"" id=""address-field"">
							<div class=""col-md-4"" style=""padding-left:15px"">
								<div class=""form-group"" >
									<label style=""font-weight:600"">Num</label>
									<input type=""text""");
            BeginWriteAttribute("value", " value=\'", 9709, "\'", 9733, 1);
#nullable restore
#line 219 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
WriteAttributeValue("", 9717, ViewData["num"], 9717, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" id=\"num\">\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"col-md-4\">\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t<label style=\"font-weight:600\">Street</label>\r\n\t\t\t\t\t\t\t\t\t<input");
            BeginWriteAttribute("value", " value=\'", 9934, "\'", 9961, 1);
#nullable restore
#line 225 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
WriteAttributeValue("", 9942, ViewData["street"], 9942, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" class=\"form-control\" id=\"street\">\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"col-md-4\" >\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t<label style=\"font-weight:600\">District</label>\r\n\t\t\t\t\t\t\t\t\t<input type=\"text\"");
            BeginWriteAttribute("value", " value=\'", 10192, "\'", 10221, 1);
#nullable restore
#line 231 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
WriteAttributeValue("", 10200, ViewData["district"], 10200, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"  id=\"district\" >\r\n\t\t\t\t\t\t\t\t</div>\t\t\t\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"col-md-4\" style=\"padding-left:15px\">\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\" >\r\n\t\t\t\t\t\t\t\t\t<label style=\"font-weight:600\">City</label>\r\n\t\t\t\t\t\t\t\t\t<input type=\"text\"");
            BeginWriteAttribute("value", " value=\'", 10469, "\'", 10494, 1);
#nullable restore
#line 237 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
WriteAttributeValue("", 10477, ViewData["city"], 10477, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" id=\"city\" >\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"col-md-4\" style=\"padding-left:15px\">\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\" >\r\n\t\t\t\t\t\t\t\t\t<label style=\"font-weight:600\">State</label>\r\n\t\t\t\t\t\t\t\t\t<input type=\"text\"");
            BeginWriteAttribute("value", " value=\'", 10735, "\'", 10761, 1);
#nullable restore
#line 243 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
WriteAttributeValue("", 10743, ViewData["state"], 10743, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" id=""state"" >
								</div>
							</div>
							<div class=""col-md-4"" >
								<div class=""form-group"">
									<label style=""font-weight:600"">Country</label>
									<select id=""items""  name=""items"" type=""text"" class=""form-control country""  ></select>
									<input type=""hidden""");
            BeginWriteAttribute("value", " value=\'", 11077, "\'", 11105, 1);
#nullable restore
#line 250 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
WriteAttributeValue("", 11085, ViewData["country"], 11085, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""country""/>
								</div>			
							</div>
						</div>
						<div class=""row"">
							<div class=""heading col-md-8"" >
								<h3>Email</h3>
							</div>
							<div class=""col-md-4"">
								<button id=""email_s"" class=""btn btn-primary save hidden"">Save Changes</button>
								<button id=""email_cl"" class=""btn cancel hidden"">Cancel</button>
								<button id=""email_op"" class=""btn open"">Edit</button>
							</div>
						</div>
						<div class=""row email-show "">
							<div class=""col-md-6"">
								<div class=""form-group"" style=""padding-left:15px"">
									<label style=""font-weight:600"">Email</label>
									<div id=""text-email"">");
#nullable restore
#line 268 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
                                                    Write(ViewData["email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
								</div>
							</div>
						</div>
						<div class=""row email-field hidden"">
							<div class=""col-md-4"" style=""padding-left:15px"">
								<div class=""form-group"" >
									<label style=""font-weight:600"">Email</label>
									<input id=""email"" type=""email""");
            BeginWriteAttribute("value", " value=\'", 12072, "\'", 12098, 1);
#nullable restore
#line 276 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
WriteAttributeValue("", 12080, ViewData["email"], 12080, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"">
									<span class=""hidden"" style=""color:red"" id=""err-email"">Your email is incorrect </span>
								
								</div>
							</div>
						</div>
						<div class=""row"">
							<div class=""heading col-md-8"" >
								<h3>Phone</h3>
							</div>
							<div class=""col-md-4"">
								<button id=""phone_s"" class=""btn btn-primary save hidden"">Save Changes</button>
								<button id=""phone_cl"" class=""btn cancel hidden"">Cancel</button>
								<button id=""phone_op"" class=""btn open"">Edit</button>
							</div>
						</div>
						<div class=""row phone-show "">
							<div class=""col-md-6"">
								<div class=""form-group"" style=""padding-left:15px"">
									<label style=""font-weight:600"">Phone</label>
									<div id=""text-phone"">");
#nullable restore
#line 296 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
                                                    Write(ViewData["phone"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
								</div>
							</div>
						</div>
						<div class=""row phone-field hidden"">
							<div class=""col-md-4"" style=""padding-left:15px"">
								<div class=""form-group"" >
									<label style=""font-weight:600"">Phone</label>
									<input id=""phone"" type=""text""");
            BeginWriteAttribute("value", " value=\'", 13174, "\'", 13200, 1);
#nullable restore
#line 304 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Account.cshtml"
WriteAttributeValue("", 13182, ViewData["phone"], 13182, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"">
									<span class=""hidden"" style=""color:red"" id=""err-phone"">Your phone is incorrect</span>

								</div>
							</div>
						</div>
					</div>
					<div class=""tab-pane fade"" id=""ticket-tab""  role=""tabpanel"" aria-labelledby=""ticket"">
						<div style=""border-bottom: 1px solid #0f0f0f3b;"" class=""row"">
							<div class=""account-title col-md-8"">
								<h2>Your tickets</h2>
							</div>
						</div>
						<div class=""row"">
							<div style=""margin-top:30px"" class=""ticket_detail col-md-4"">
								<div class=""form-group"">
									<label>Enter your ticket id here:</label>
									<input class=""form-control"" type=""text"" id=""ticket_id""/>
								</div>
							</div>
							<div class=""col-md-4"">
								<button style=""margin-top: 70px"" class=""btn btn-primary"" id=""submit_ticket_id"">Check</button>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
</section>
<script>
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccountModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccountModel>)PageContext?.ViewData;
        public AccountModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
