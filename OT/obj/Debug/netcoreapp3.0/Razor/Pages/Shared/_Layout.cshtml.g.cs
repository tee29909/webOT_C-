#pragma checksum "D:\TBKK\OT\OT\Pages\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "864df7e0fc5252a15353a7720426745edb51ba7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OT.Pages.Shared.Pages_Shared__Layout), @"mvc.1.0.view", @"/Pages/Shared/_Layout.cshtml")]
namespace OT.Pages.Shared
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
#line 1 "D:\TBKK\OT\OT\Pages\_ViewImports.cshtml"
using OT;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"864df7e0fc5252a15353a7720426745edb51ba7b", @"/Pages/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e6f1ac5e30ae7fa0a04c04589db12ca943662fa", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "864df7e0fc5252a15353a7720426745edb51ba7b3347", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "D:\TBKK\OT\OT\Pages\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - ขอทำงาน</title>
    

    <!-- Custom fonts for this template-->
    <link href=""lib/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">

    <!-- Page level plugin CSS-->
    <link href=""lib/datatables/dataTables.bootstrap4.css"" rel=""stylesheet"">

    <!-- Custom styles for this template-->
    <link href=""css/sb-admin.css"" rel=""stylesheet"">
    <link href=""css/sb-admin2.css"" rel=""stylesheet"">



    <!-- Bootstrap core JavaScript-->
    <script src=""lib/jquery/jquery.min.js""></script>
    <script src=""lib/bootstrap/js/bootstrap.bundle.min.js""></script>

    <!-- Core plugin JavaScript-->
    <script src=""lib/jquery-easing/jquery.easing.min.js""></script>

    <!-- Page level plugin JavaScript-->
    <script src=""lib/chart.js/Chart.min.js""></script>
    <script src=""lib/datatables/jquery.dataTables.js""></script>
    <script src=""lib/datatables/dataTables.bootstrap4.js""></script>

    <!-- Custom scripts for all pages-->
    <script src=""js/sb-admin.min.js""></scri");
                WriteLiteral(@"pt>

    <!-- Demo scripts for this page-->
    <script src=""js/demo/datatables-demo.js""></script>
    <script src=""js/demo/chart-area-demo.js""></script>



    <script>


        function selectType1() {
            var m1 = document.getElementById(""M1"");
            var m2 = document.getElementById(""M2"");
            document.getElementById(""gridCheck2"").checked = false;
            document.getElementById(""gridCheck3"").checked = false;
            m1.style.display = ""block"";
            m2.style.display = ""none"";



        }
        function selectType2() {
            var m1 = document.getElementById(""M1"");
            var m2 = document.getElementById(""M2"");
            document.getElementById(""gridCheck1"").checked = false;
            document.getElementById(""gridCheck3"").checked = false;
            m1.style.display = ""none"";
            m2.style.display = ""block"";

        }
        function selectType3() {
            var m1 = document.getElementById(""M1"");
          ");
                WriteLiteral(@"  var m2 = document.getElementById(""M2"");
            document.getElementById(""gridCheck1"").checked = false;
            document.getElementById(""gridCheck2"").checked = false;
            m1.style.display = ""none"";
            m2.style.display = ""block"";

        }
        function selectH1() {
            document.getElementById(""h2"").checked = false;

        }
        function selectH2() {
            document.getElementById(""h1"").checked = false;
        }
    </script>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "864df7e0fc5252a15353a7720426745edb51ba7b7327", async() => {
                WriteLiteral(@"

    <nav class=""navbar navbar-expand navbar-dark bg-dark static-top"">

        <a class=""navbar-brand mr-1"" href=""index.html"">TBKK</a>

        <button class=""btn btn-link btn-sm text-white order-1 order-sm-0"" id=""sidebarToggle"" href=""#"">
            <i class=""fas fa-bars""></i>
        </button>

        <!-- Navbar Search -->
        <!-- Navbar -->

        <div class=""input-group""></div>
        <ul class=""navbar-nav ml-auto ml-md-0"">
            <li class=""nav-item dropdown no-arrow"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button"" data-toggle=""dropdown""
                   aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-user-circle fa-fw""></i>
                </a>
                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""userDropdown"">
                    <a class=""dropdown-item"" href=""#"">Settings</a>
                    <a class=""dropdown-item"" href=""#"">Activity Log</a>
           ");
                WriteLiteral(@"         <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">Logout</a>
                </div>
            </li>
        </ul>



    </nav>

    <div id=""wrapper"">

        <!-- Sidebar -->
        <ul class=""sidebar bg-gradient-primary navbar-nav"">
            <li class=""nav-item active"">
                <a class=""nav-link"" href=""index.html"">
                    <i class=""fas fa-fw fa-home""></i>
                    <span>Home</span>
                </a>
            </li>

            <li class=""nav-item dropdown"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""pagesDropdown"" role=""button"" data-toggle=""dropdown""
                   aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-fw fa-users""></i>
                    <span>Gauge</span>
                </a>
                <div class=""dropdown-menu"" aria-labelledby=""pagesDropdown"">

               ");
                WriteLiteral(@"     <a class=""dropdown-item"" href=""login.html"">เกรต</a>
                    <a class=""dropdown-item"" href=""register.html"">ทำแบบประเมิน</a>


                </div>
            </li>




            <li class=""nav-item dropdown"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""pagesDropdown"" role=""button"" data-toggle=""dropdown""
                   aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-fw fa-clipboard""></i>
                    <span>OT</span>
                </a>
                <div class=""dropdown-menu"" aria-labelledby=""pagesDropdown"">

                    <a class=""dropdown-item"" href=""login.html"">ขอทำงานOT</a>
                    <a class=""dropdown-item"" href=""register.html"">คิวรถกลับบ่าน</a>
                    <a class=""dropdown-item"" href=""forgot-password.html"">ประวัตการทำงานOT</a>

                </div>
            </li>

            <li class=""nav-item dropdown"">
                <a class=""nav-link dropdown-toggle"" hr");
                WriteLiteral(@"ef=""#"" id=""pagesDropdown"" role=""button"" data-toggle=""dropdown""
                   aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-fw fa-cogs""></i>
                    <span>IT Serves</span>
                </a>
                <div class=""dropdown-menu"" aria-labelledby=""pagesDropdown"">
                    <h6 class=""dropdown-header"">Help Desk:</h6>
                    <a class=""dropdown-item"" href=""login.html"">แจ้งอุปกรรเสียหาย</a>
                    <a class=""dropdown-item"" href=""login.html"">อุปกรที่ใช้งานอยู่</a>
                    <h6 class=""dropdown-header"">Asset Control:</h6>
                    <a class=""dropdown-item"" href=""login.html"">ติดตามการซ่อม</a>


                </div>
            </li>




            <li class=""nav-item dropdown"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""pagesDropdown"" role=""button"" data-toggle=""dropdown""
                   aria-haspopup=""true"" aria-expanded=""false"">
                    <i class");
                WriteLiteral(@"=""fas fa-fw fa-folder""></i>
                    <span>from</span>
                </a>
                <div class=""dropdown-menu"" aria-labelledby=""pagesDropdown"">
                    <h6 class=""dropdown-header"">Login Screens:</h6>
                    <a class=""dropdown-item"" href=""login.html"">Login</a>
                    <a class=""dropdown-item"" href=""register.html"">Register</a>
                    <a class=""dropdown-item"" href=""forgot-password.html"">Forgot Password</a>
                    <div class=""dropdown-divider""></div>
                    <h6 class=""dropdown-header"">Other Pages:</h6>
                    <a class=""dropdown-item"" href=""404.html"">404 Page</a>
                    <a class=""dropdown-item"" href=""blank.html"">Blank Page</a>
                </div>
            </li>








            <li class=""nav-item"">
                <a class=""nav-link"" href=""charts.html"">
                    <i class=""fas fa-fw fa-chart-area""></i>
                    <span>Charts</span>
        ");
                WriteLiteral(@"        </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""tables.html"">
                    <i class=""fas fa-fw fa-table""></i>
                    <span>Tables</span>
                </a>
            </li>
        </ul>

        <div id=""content-wrapper"">
            ");
#nullable restore
#line 222 "D:\TBKK\OT\OT\Pages\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

            <!-- /.container-fluid -->
            <!-- Sticky Footer -->
            <footer class=""sticky-footer"">
                <div class=""container my-auto"">
                    <div class=""copyright text-center my-auto"">
                        <span>Copyright © Your Website 2019</span>
                    </div>
                </div>
            </footer>

        </div>
        <!-- /.content-wrapper -->

    </div>
    <!-- /#wrapper -->
    <!-- Scroll to Top Button-->
    <a class=""scroll-to-top rounded"" href=""#page-top"">
        <i class=""fas fa-angle-up""></i>
    </a>

    <!-- Logout Modal-->
    <div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
         aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Ready to Leave?</h5>
                ");
                WriteLiteral(@"    <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                </div>
                <div class=""modal-body"">Select ""Logout"" below if you are ready to end your current session.</div>
                <div class=""modal-footer"">
                    <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                    <a class=""btn btn-primary"" href=""login.html"">Logout</a>
                </div>
            </div>
        </div>
    </div>
    <!-- Bootstrap core JavaScript-->
    <script src=""lib/jquery/jquery.min.js""></script>
    <script src=""lib/bootstrap/js/bootstrap.bundle.min.js""></script>

    <!-- Core plugin JavaScript-->
    <script src=""lib/jquery-easing/jquery.easing.min.js""></script>

    <!-- Page level plugin JavaScript-->
    <script src=""lib/chart.js/Chart.min.js""></script>
    <script src=""lib/datatables/jquery.dataTab");
                WriteLiteral(@"les.js""></script>
    <script src=""lib/datatables/dataTables.bootstrap4.js""></script>

    <!-- Custom scripts for all pages-->
    <script src=""js/sb-admin.min.js""></script>

    <!-- Demo scripts for this page-->
    <script src=""js/demo/datatables-demo.js""></script>
    <script src=""js/demo/chart-area-demo.js""></script>



");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591