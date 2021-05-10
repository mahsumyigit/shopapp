#pragma checksum "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\Admin\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "223c8a3a6e66d8e0e73056a3791dfd16431af38a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserList), @"mvc.1.0.view", @"/Views/Admin/UserList.cshtml")]
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
#line 2 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"223c8a3a6e66d8e0e73056a3791dfd16431af38a", @"/Views/Admin/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a37584fdbe64ca31cd20fae569eeb6d30eee5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/user/delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.20/css/dataTables.bootstrap4.min.css\">\r\n");
            }
            );
            WriteLiteral("  \r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""//cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.20/js/dataTables.bootstrap4.min.js""></script>

    <script>
        $(document).ready( function () {
            $('#myTable').DataTable();
        });
    </script>

");
            }
            );
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-12"">
        <h1 class=""h3"">User List</h1>
        <hr>
        <a class=""btn btn-primary btn-sm"" href=""/admin/user/create"">Create User</a>
        <hr>
        <table data-page-length='3' id=""myTable"" class=""table table-bordered mt-3"">
            <thead>
                <tr>
                    <td>FirstName</td>
                    <td>LastName</td>
                    <td>UserName</td>
                    <td>Email</td>
                    <td>EmailConfirmed</td>
                    <td style=""width: 160px;""></td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 40 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\Admin\UserList.cshtml"
                 if(Model.Count()>0)
                {
                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\Admin\UserList.cshtml"
                        foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("class", " class=\"", 1309, "\"", 1355, 1);
#nullable restore
#line 44 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\Admin\UserList.cshtml"
WriteAttributeValue("", 1317, item.EmailConfirmed?"":"bg-warning", 1317, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <td>");
#nullable restore
#line 45 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\Admin\UserList.cshtml"
                               Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\Admin\UserList.cshtml"
                               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                              \r\n                                <td>");
#nullable restore
#line 47 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\Admin\UserList.cshtml"
                               Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                              \r\n                                <td>");
#nullable restore
#line 48 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\Admin\UserList.cshtml"
                               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                              \r\n                                <td>");
#nullable restore
#line 49 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\Admin\UserList.cshtml"
                               Write(item.EmailConfirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                              \r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1844, "\"", 1871, 2);
            WriteAttributeValue("", 1851, "/admin/user/", 1851, 12, true);
#nullable restore
#line 51 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\Admin\UserList.cshtml"
WriteAttributeValue("", 1863, item.Id, 1863, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Edit</a>\r\n                                    \r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "223c8a3a6e66d8e0e73056a3791dfd16431af38a9421", async() => {
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("value", " value=\"", 2142, "\"", 2158, 1);
#nullable restore
#line 54 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\Admin\UserList.cshtml"
WriteAttributeValue("", 2150, item.Id, 2150, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                        </tr>\r\n");
#nullable restore
#line 59 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\Admin\UserList.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\Admin\UserList.cshtml"
                         
                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>No Users</h3>\r\n                    </div>\r\n");
#nullable restore
#line 64 "C:\TemsaDev\DevYigit\shopapp\shopapp.webui\Views\Admin\UserList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             \r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
