#pragma checksum "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96f87a6dbc2e3143642e7434d16428a60d6f4216"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorGalaga.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using BlazorGalaga;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using BlazorGalaga.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using Blazor.Extensions.Canvas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using Blazor.Extensions.Canvas.Canvas2D;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using Blazor.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using Blazor.Extensions.Canvas.WebGL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using BlazorGalaga.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\_Imports.razor"
using BlazorGalaga.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "style");
            __builder.AddMarkupContent(1, "\r\n\r\n        html {\r\n            background: ");
            __builder.AddContent(2, 
#nullable restore
#line 6 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                          DebugMode ? "" : "url(Assets/bezel.png) no-repeat center center fixed"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, ";\r\n            -webkit-background-size: cover;\r\n            -moz-background-size: cover;\r\n            -o-background-size: cover;\r\n            background-size: cover;\r\n        }\r\n        body {\r\n            background-color: ");
            __builder.AddContent(4, 
#nullable restore
#line 13 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                DebugMode ? "white" : "black"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, @";
        }

        .content {
            padding: 0px !important;
        }

        div.context.px-4 {
            padding: 0px !important;
        }

        .main > div {
            padding: 0px !important;
        }

        #theCanvas canvas {
            display: block;
            width: 100%;
            height: 100%;
            position: absolute;
            cursor: ");
            __builder.AddContent(6, 
#nullable restore
#line 33 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                      DebugMode ? "auto" : "none"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(7, ";\r\n        }\r\n\r\n            #theCanvas canvas:first-child {\r\n                z-index: 1;\r\n                cursor: ");
            __builder.AddContent(8, 
#nullable restore
#line 38 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                          DebugMode ? "auto" : "none"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, ";\r\n            }\r\n\r\n            #theCanvas canvas:last-child {\r\n                z-index: 1000;\r\n                cursor: ");
            __builder.AddContent(10, 
#nullable restore
#line 43 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                          DebugMode ? "auto" : "none"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, ";\r\n            }\r\n\r\n        .twinkle {\r\n            background: transparent url(\'Assets/twinkling.png\') repeat top center;\r\n            display: block;\r\n            width: 100%;\r\n            height: 100%;\r\n            position: absolute;\r\n            z-index: -50;\r\n            -webkit-animation: move-twink-back 90s linear infinite;\r\n            -moz-animation: move-twink-back 90s linear infinite;\r\n            -o-animation: move-twink-back 90s linear infinite;\r\n            animation: move-twink-back 90s linear infinite;\r\n        }\r\n\r\n        .background {\r\n            display: block;\r\n            width: 100%;\r\n            height: 100%;\r\n            position: absolute;\r\n            background-image: url(\'Assets/Background.png\');\r\n            z-index: -100;\r\n        }\r\n\r\n        .backgroundmoving {\r\n            -webkit-animation: animatedBackground 5s linear infinite;\r\n            -moz-animation: animatedBackground 5s linear infinite;\r\n            -o-animation: animatedBackground 5s linear infinite;\r\n            animation: animatedBackground 5s linear infinite;\r\n        }\r\n\r\n        #divBufferCanvas canvas {\r\n            background-color: black;\r\n            display: block;\r\n        }\r\n\r\n        #divBigBufferCanvas canvas {\r\n            background-color: black;\r\n            display: block;\r\n        }\r\n\r\n        #divBiggerBufferCanvas canvas {\r\n            background-color: black;\r\n            display: block;\r\n        }\r\n\r\n        body {\r\n            overflow-y: hidden; /* Hide vertical scrollbar */\r\n            overflow-x: hidden; /* Hide horizontal scrollbar */\r\n        }\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "id", "divDebug");
            __builder.AddAttribute(15, "style", 
#nullable restore
#line 96 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                            DebugMode ? "visibility:visible" : "visibility:hidden"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.AddMarkupContent(17, @"<div id=""divDebugDash"" style=""position:absolute;left:15px;top:15px;width:300px;height:250px;background-color:lightgray;padding:5px;font-size:10px;font-size:10px"">
        <input type=""checkbox"" id=""PauseAnimation"">
        <label for=""PauseAnimation"">Pause Animation</label>
        <br>
        <input type=""checkbox"" id=""EditCurves"">
        <label for=""EditCurves"">Edit Curves</label>
        <br>
        <button id=""btnKillAllBugs"">Kill Bugs</button>
        <br><br>
        <button id=""btnCaptureShip"">Capture Ship</button>
        <br><br>
        <button id=""btnMorphBug"">Morph Bug</button>
        <br><br>
        <button id=""btnResetAnimation"">Reset Animation</button>
        <br><br>
    </div>

    ");
            __builder.AddMarkupContent(18, "<div id=\"divDiagnostics\" style=\"position:absolute;left:15px;top:290px;width:300px;height:700px;background-color:lightgray;padding:5px;font-size:10px;font-size:10px;overflow:scroll\">\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "id", "divBufferCanvas");
            __builder.AddAttribute(21, "style", "position:absolute;right:0px;top:15px;opacity:1");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 118 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
         if (BufferCanvases != null && BufferCanvases.Count > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
             foreach (var canvas in BufferCanvases)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                ");
            __builder.OpenComponent<Blazor.Extensions.Canvas.BECanvas>(24);
            __builder.AddAttribute(25, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 122 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                  canvas.Width

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 122 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                                         canvas.Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(27, (__value) => {
#nullable restore
#line 122 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                                                               canvas.CanvasRef = (Blazor.Extensions.Canvas.BECanvas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 123 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "id", "divBigBufferCanvas");
            __builder.AddAttribute(33, "style", "position:absolute;right:50px;top:15px;opacity:1");
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 127 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
         if (BigBufferCanvases != null && BigBufferCanvases.Count > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
             foreach (var canvas in BigBufferCanvases)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                ");
            __builder.OpenComponent<Blazor.Extensions.Canvas.BECanvas>(36);
            __builder.AddAttribute(37, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 131 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                  canvas.Width

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 131 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                                         canvas.Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(39, (__value) => {
#nullable restore
#line 131 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                                                               canvas.CanvasRef = (Blazor.Extensions.Canvas.BECanvas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 132 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "id", "divBiggerBufferCanvas");
            __builder.AddAttribute(45, "style", "position:absolute;right:150px;top:15px;opacity:1");
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 136 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
         if (BiggerBufferCanvases != null && BiggerBufferCanvases.Count > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
             foreach (var canvas in BiggerBufferCanvases)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "                ");
            __builder.OpenComponent<Blazor.Extensions.Canvas.BECanvas>(48);
            __builder.AddAttribute(49, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 140 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                  canvas.Width

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 140 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                                         canvas.Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(51, (__value) => {
#nullable restore
#line 140 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                                                               canvas.CanvasRef = (Blazor.Extensions.Canvas.BECanvas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 141 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\r\n");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "id", "theCanvas");
            __builder.AddAttribute(58, "style", "position: fixed; opacity: 1; background-color: black; width: 100%; height: 100%;");
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.OpenComponent<Blazor.Extensions.Canvas.BECanvas>(60);
            __builder.AddAttribute(61, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 147 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                     672

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 147 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                  944

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(63, (__value) => {
#nullable restore
#line 147 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                             DynamicCanvas1 = (Blazor.Extensions.Canvas.BECanvas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.OpenComponent<Blazor.Extensions.Canvas.BECanvas>(65);
            __builder.AddAttribute(66, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 148 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                     672

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 148 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                  944

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(68, (__value) => {
#nullable restore
#line 148 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                             StaticCanvas = (Blazor.Extensions.Canvas.BECanvas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n    <div class=\"twinkle\"></div>\r\n    ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", 
#nullable restore
#line 150 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                 BackGroundClass

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\r\n");
            __builder.OpenElement(74, "img");
            __builder.AddAttribute(75, "id", "imgSpriteSheet");
            __builder.AddAttribute(76, "style", "display:none");
            __builder.AddAttribute(77, "src", "Assets/spritesheet.png");
            __builder.AddElementReferenceCapture(78, (__value) => {
#nullable restore
#line 153 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                                    spriteSheet = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
            __builder.OpenElement(80, "img");
            __builder.AddAttribute(81, "id", "imgBlazor");
            __builder.AddAttribute(82, "style", "display:none");
            __builder.AddAttribute(83, "src", "Assets/blazor.png");
            __builder.AddElementReferenceCapture(84, (__value) => {
#nullable restore
#line 154 "C:\Users\bcollins\Desktop\BlazorGalaga\BlazorGalaga\Pages\Index.razor"
                                               blazorImage = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
            __builder.AddMarkupContent(86, "<div style=\"font-family: PressStart2P; height:0px\">.</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
