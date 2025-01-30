<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditBook.aspx.cs" Inherits="WebApplication2.WebForm9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .hidden{
            display:none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <h2>Edit Book</h2>

            <!-- Table of books -->
            <h3>Books List</h3>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Book ID</th>
                        <th>Book Name</th>
                        <th>Book Kind</th>
                        <th>Book Level</th>

                    </tr>
                </thead>
                <tbody id="booksTableBody" runat="server">
                    <!-- Data will be populated from code-behind -->
                </tbody>
            </table>

            <!-- Form to edit selected book -->
            <h3>Select Book To Edit</h3>
            <div class="form-group">
                <label for="txtBooksearch">Search By ID:</label>
                <asp:TextBox ID="txtBooksearch" runat="server" CssClass="form-control"  />
            </div>
            <div class="form-group" cssclass="hidden">
                <label for="txtBookId">Book ID</label>
                <asp:TextBox ID="txtBookId" runat="server" CssClass="form-control" Enabled="false" />
            </div>
            <div class="form-group" cssclass="hidden">
                <label for="txtBookName">Book Name</label>
                <asp:TextBox ID="txtBookName" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group" cssclass="hidden">
                <label for="txtBookKind">Book Kind</label>
                <asp:TextBox ID="txtBookKind" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group" cssclass="hidden">
                <label for="txtBookLevel">Book Level</label>
                <asp:TextBox ID="txtBookLevel" runat="server" CssClass="form-control" />
            </div>


        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</body>
</html>
