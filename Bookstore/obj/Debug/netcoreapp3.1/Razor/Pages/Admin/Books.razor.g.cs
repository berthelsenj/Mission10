#pragma checksum "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c1c7baf173f2eb5877c90c88d7547b31778b2fe"
// <auto-generated/>
#pragma warning disable 1591
namespace Bookstore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Books : OwningComponentBase<IBookstoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered table-hover");
            __builder.AddMarkupContent(2, "\n\n    ");
            __builder.AddMarkupContent(3, @"<thead class=""thead-light"">
        <tr>
            <th>Book ID</th>
            <th>Title</th>
            <th>Author</th>
            <th>Publisher</th>
            <th>ISBN</th>
            <th>Classification</th>
            <th>Category</th>
            <th>Page Count</th>
            <th>Price</th>
        </tr>
    </thead>

    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\n\n");
#nullable restore
#line 26 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor"
         if (BookData?.Count() > 0)
        {
            //List the books
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor"
             foreach (Book b in BookData)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "                ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\n                    ");
            __builder.OpenElement(9, "td");
#nullable restore
#line 32 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor"
__builder.AddContent(10, b.BookId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n                    ");
            __builder.OpenElement(12, "td");
#nullable restore
#line 33 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor"
__builder.AddContent(13, b.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                    ");
            __builder.OpenElement(15, "td");
#nullable restore
#line 34 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor"
__builder.AddContent(16, b.Author);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                    ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 35 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor"
__builder.AddContent(19, b.Publisher);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                    ");
            __builder.OpenElement(21, "td");
#nullable restore
#line 36 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor"
__builder.AddContent(22, b.Isbn);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                    ");
            __builder.OpenElement(24, "td");
#nullable restore
#line 37 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor"
__builder.AddContent(25, b.Classification);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                    ");
            __builder.OpenElement(27, "td");
#nullable restore
#line 38 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor"
__builder.AddContent(28, b.Category);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n                    ");
            __builder.OpenElement(30, "td");
#nullable restore
#line 39 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor"
__builder.AddContent(31, b.PageCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n                    ");
            __builder.OpenElement(33, "td");
#nullable restore
#line 40 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor"
__builder.AddContent(34, b.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n\n                    ");
            __builder.OpenElement(36, "td");
            __builder.AddMarkupContent(37, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(38);
            __builder.AddAttribute(39, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(40, "href", 
#nullable restore
#line 43 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor"
                                                                    GetDetailsUrl(b.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(42, "Details");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n\n                    ");
            __builder.OpenElement(45, "td");
            __builder.AddMarkupContent(46, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(47);
            __builder.AddAttribute(48, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(49, "href", 
#nullable restore
#line 47 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor"
                                                                       GetEditUrl(b.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(51, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n\n                    ");
            __builder.OpenElement(54, "td");
            __builder.AddMarkupContent(55, "\n                        ");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor"
                                                                          x => RemoveBook(b)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(59, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n");
#nullable restore
#line 54 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "            ");
            __builder.AddMarkupContent(64, "<tr>\n                <td colspan=\"5\" class=\"text-center\">No Books</td>\n            </tr>\n");
#nullable restore
#line 61 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(65, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(68);
            __builder.AddAttribute(69, "class", "btn btn-primary");
            __builder.AddAttribute(70, "href", "/admin/books/create");
            __builder.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(72, "Create");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "/Users/johnberthelsen/Projects/Bookstore/Bookstore/Pages/Admin/Books.razor"
       

    public IBookstoreRepository repo => Service;

    public IEnumerable<Book> BookData { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        BookData = await repo.Books.ToListAsync();
    }

    public string GetDetailsUrl(long id) => $"/admin/books/details/{id}";
    public string GetEditUrl(long id) => $"/admin/books/edit/{id}";

    public async Task RemoveBook(Book b)
    {
        repo.DeleteBook(b);
        await UpdateData();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
