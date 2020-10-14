#pragma checksum "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b6af2c580f4a5ea03b896629de6f6d8e227f9e9"
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
#line 1 "/Users/bcollins/BlazorGalaga/BlazorGalaga/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/bcollins/BlazorGalaga/BlazorGalaga/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/bcollins/BlazorGalaga/BlazorGalaga/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/bcollins/BlazorGalaga/BlazorGalaga/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/bcollins/BlazorGalaga/BlazorGalaga/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/bcollins/BlazorGalaga/BlazorGalaga/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/bcollins/BlazorGalaga/BlazorGalaga/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/bcollins/BlazorGalaga/BlazorGalaga/_Imports.razor"
using BlazorGalaga;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/bcollins/BlazorGalaga/BlazorGalaga/_Imports.razor"
using BlazorGalaga.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/bcollins/BlazorGalaga/BlazorGalaga/_Imports.razor"
using Blazor.Extensions.Canvas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/bcollins/BlazorGalaga/BlazorGalaga/_Imports.razor"
using Blazor.Extensions.Canvas.Canvas2D;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/bcollins/BlazorGalaga/BlazorGalaga/_Imports.razor"
using Blazor.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/bcollins/BlazorGalaga/BlazorGalaga/_Imports.razor"
using Blazor.Extensions.Canvas.WebGL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/bcollins/BlazorGalaga/BlazorGalaga/_Imports.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/bcollins/BlazorGalaga/BlazorGalaga/_Imports.razor"
using BlazorGalaga.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/bcollins/BlazorGalaga/BlazorGalaga/_Imports.razor"
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
            __builder.AddMarkupContent(0, "<style>\r\n\r\n        html {\r\n            background: url(Assets/bezel.png) no-repeat center center fixed;\r\n            -webkit-background-size: cover;\r\n            -moz-background-size: cover;\r\n            -o-background-size: cover;\r\n            background-size: cover;\r\n        }\r\n        body {\r\n            background-color: black;\r\n        }\r\n\r\n        #divDebug{\r\n            visibility:hidden;\r\n        }\r\n\r\n        .content {\r\n            padding: 0px !important;\r\n        }\r\n\r\n        div.context.px-4 {\r\n            padding: 0px !important;\r\n        }\r\n\r\n        .main > div {\r\n            padding: 0px !important;\r\n        }\r\n\r\n        #theCanvas canvas {\r\n            display: block;\r\n            width: 100%;\r\n            height: 100%;\r\n            position: absolute;\r\n            cursor: none;\r\n        }\r\n\r\n            #theCanvas canvas:first-child {\r\n                z-index: 1;\r\n                cursor: none;\r\n            }\r\n\r\n            #theCanvas canvas:last-child {\r\n                z-index: 1000;\r\n                cursor: none;\r\n            }\r\n\r\n        .twinkle {\r\n            background: transparent url(\'Assets/twinkling.png\') repeat top center;\r\n            display: block;\r\n            width: 100%;\r\n            height: 100%;\r\n            position: absolute;\r\n            z-index: -50;\r\n            -webkit-animation: move-twink-back 90s linear infinite;\r\n            -moz-animation: move-twink-back 90s linear infinite;\r\n            -o-animation: move-twink-back 90s linear infinite;\r\n            animation: move-twink-back 90s linear infinite;\r\n        }\r\n\r\n        .background {\r\n            display: block;\r\n            width: 100%;\r\n            height: 100%;\r\n            position: absolute;\r\n            background-image: url(\'Assets/Background.png\');\r\n            z-index: -100;\r\n        }\r\n\r\n        .backgroundmoving {\r\n            -webkit-animation: animatedBackground 5s linear infinite;\r\n            -moz-animation: animatedBackground 5s linear infinite;\r\n            -o-animation: animatedBackground 5s linear infinite;\r\n            animation: animatedBackground 5s linear infinite;\r\n        }\r\n\r\n        #divBufferCanvas canvas {\r\n            background-color: black;\r\n            display: block;\r\n        }\r\n\r\n        #divBigBufferCanvas canvas {\r\n            background-color: black;\r\n            display: block;\r\n        }\r\n\r\n        #divBiggerBufferCanvas canvas {\r\n            background-color: black;\r\n            display: block;\r\n        }\r\n\r\n        body {\r\n            overflow-y: hidden; /* Hide vertical scrollbar */\r\n            overflow-x: hidden; /* Hide horizontal scrollbar */\r\n        }\r\n    </style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "divDebug");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, @"<div id=""divDebugDash"" style=""position:absolute;left:15px;top:15px;width:300px;height:250px;background-color:lightgray;padding:5px;font-size:10px;font-size:10px"">
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
            __builder.AddMarkupContent(5, "<div id=\"divDiagnostics\" style=\"position:absolute;left:15px;top:290px;width:300px;height:400px;background-color:lightgray;padding:5px;font-size:10px;font-size:10px;overflow:scroll\">\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "id", "divBufferCanvas");
            __builder.AddAttribute(8, "style", "position:absolute;right:0px;top:15px;opacity:1");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 122 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
         if (BufferCanvases != null && BufferCanvases.Count > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
             foreach (var canvas in BufferCanvases)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenComponent<Blazor.Extensions.Canvas.BECanvas>(11);
            __builder.AddAttribute(12, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 126 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                                  canvas.Width

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 126 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                                                         canvas.Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(14, (__value) => {
#nullable restore
#line 126 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                                                                               canvas.CanvasRef = (Blazor.Extensions.Canvas.BECanvas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 127 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "id", "divBigBufferCanvas");
            __builder.AddAttribute(20, "style", "position:absolute;right:50px;top:15px;opacity:1");
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 131 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
         if (BigBufferCanvases != null && BigBufferCanvases.Count > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
             foreach (var canvas in BigBufferCanvases)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "                ");
            __builder.OpenComponent<Blazor.Extensions.Canvas.BECanvas>(23);
            __builder.AddAttribute(24, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 135 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                                  canvas.Width

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 135 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                                                         canvas.Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(26, (__value) => {
#nullable restore
#line 135 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                                                                               canvas.CanvasRef = (Blazor.Extensions.Canvas.BECanvas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 136 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "id", "divBiggerBufferCanvas");
            __builder.AddAttribute(32, "style", "position:absolute;right:150px;top:15px;opacity:1");
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 140 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
         if (BiggerBufferCanvases != null && BiggerBufferCanvases.Count > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
             foreach (var canvas in BiggerBufferCanvases)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "                ");
            __builder.OpenComponent<Blazor.Extensions.Canvas.BECanvas>(35);
            __builder.AddAttribute(36, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 144 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                                  canvas.Width

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 144 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                                                         canvas.Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(38, (__value) => {
#nullable restore
#line 144 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                                                                               canvas.CanvasRef = (Blazor.Extensions.Canvas.BECanvas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 145 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "id", "theCanvas");
            __builder.AddAttribute(45, "style", "position: fixed; opacity: 1; background-color: black; width: 100%; height: 100%;");
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenComponent<Blazor.Extensions.Canvas.BECanvas>(47);
            __builder.AddAttribute(48, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 151 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                     672

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 151 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                                  944

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(50, (__value) => {
#nullable restore
#line 151 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                                             DynamicCanvas1 = (Blazor.Extensions.Canvas.BECanvas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.OpenComponent<Blazor.Extensions.Canvas.BECanvas>(52);
            __builder.AddAttribute(53, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 152 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                     672

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 152 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                                  944

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(55, (__value) => {
#nullable restore
#line 152 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                                             StaticCanvas = (Blazor.Extensions.Canvas.BECanvas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n    <div class=\"twinkle\"></div>\r\n    ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", 
#nullable restore
#line 154 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                 BackGroundClass

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n");
            __builder.OpenElement(61, "img");
            __builder.AddAttribute(62, "id", "imgSpriteSheet");
            __builder.AddAttribute(63, "style", "display:none");
            __builder.AddAttribute(64, "src", "Assets/spritesheet.png");
            __builder.AddElementReferenceCapture(65, (__value) => {
#nullable restore
#line 157 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                                                    spriteSheet = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
            __builder.OpenElement(67, "img");
            __builder.AddAttribute(68, "id", "imgBlazor");
            __builder.AddAttribute(69, "style", "display:none");
            __builder.AddAttribute(70, "src", "Assets/blazor.png");
            __builder.AddElementReferenceCapture(71, (__value) => {
#nullable restore
#line 158 "/Users/bcollins/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                                               blazorImage = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
            __builder.AddMarkupContent(73, "<div style=\"font-family: PressStart2P; height:0px\">.</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
