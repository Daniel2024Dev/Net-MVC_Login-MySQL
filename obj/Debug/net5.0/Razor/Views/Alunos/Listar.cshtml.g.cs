#pragma checksum "/home/daniel/Área de Trabalho/code examples/codigos/exemplos de codigos no mvc/Ex data base com seção/Views/Alunos/Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d442a83e6fccc57b6afdc51d330cd2bdc5cc2719"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alunos_Listar), @"mvc.1.0.view", @"/Views/Alunos/Listar.cshtml")]
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
#line 1 "/home/daniel/Área de Trabalho/code examples/codigos/exemplos de codigos no mvc/Ex data base com seção/Views/_ViewImports.cshtml"
using Ex_data_base_com_seção;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/daniel/Área de Trabalho/code examples/codigos/exemplos de codigos no mvc/Ex data base com seção/Views/_ViewImports.cshtml"
using Ex_data_base_com_seção.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d442a83e6fccc57b6afdc51d330cd2bdc5cc2719", @"/Views/Alunos/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0e3719b2c6f3ee048486450cd35be53b983f619", @"/Views/_ViewImports.cshtml")]
    public class Views_Alunos_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Alunos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h3>Lista de aluno</h3>\n\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>Nome</th>\n            <th>Usuário</th>\n            <th>Senha</th>\n            <th>Data nacimento</th>\n            <th>Manutenção</th>\n\n        </tr>\n    </thead>\n");
#nullable restore
#line 17 "/home/daniel/Área de Trabalho/code examples/codigos/exemplos de codigos no mvc/Ex data base com seção/Views/Alunos/Listar.cshtml"
     foreach (Alunos a in Model)//PUXANDO A LIST DE MODEL
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 20 "/home/daniel/Área de Trabalho/code examples/codigos/exemplos de codigos no mvc/Ex data base com seção/Views/Alunos/Listar.cshtml"
           Write(a.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 21 "/home/daniel/Área de Trabalho/code examples/codigos/exemplos de codigos no mvc/Ex data base com seção/Views/Alunos/Listar.cshtml"
           Write(a.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 22 "/home/daniel/Área de Trabalho/code examples/codigos/exemplos de codigos no mvc/Ex data base com seção/Views/Alunos/Listar.cshtml"
           Write(a.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 23 "/home/daniel/Área de Trabalho/code examples/codigos/exemplos de codigos no mvc/Ex data base com seção/Views/Alunos/Listar.cshtml"
           Write(a.DataNasc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <!-- PASSANDO A INFORMAÇÃO IdAlunos VIA PARAMETRO GET -->\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 561, "\"", 596, 2);
            WriteAttributeValue("", 568, "/Alunos/Editar?Id=", 568, 18, true);
#nullable restore
#line 25 "/home/daniel/Área de Trabalho/code examples/codigos/exemplos de codigos no mvc/Ex data base com seção/Views/Alunos/Listar.cshtml"
WriteAttributeValue("", 586, a.IdAluno, 586, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td> <!-- BOTÃO QUE EXECUTA A FUNÇÃO Editar EM IActionResult -->\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 692, "\"", 728, 2);
            WriteAttributeValue("", 699, "/Alunos/Excluir?Id=", 699, 19, true);
#nullable restore
#line 26 "/home/daniel/Área de Trabalho/code examples/codigos/exemplos de codigos no mvc/Ex data base com seção/Views/Alunos/Listar.cshtml"
WriteAttributeValue("", 718, a.IdAluno, 718, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></td> <!-- BOTÃO QUE EXECUTA A FUNÇÃO Excluir EM IActionResult -->\n        </tr>\n");
#nullable restore
#line 28 "/home/daniel/Área de Trabalho/code examples/codigos/exemplos de codigos no mvc/Ex data base com seção/Views/Alunos/Listar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Alunos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
