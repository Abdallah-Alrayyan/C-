<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="WebApplication2.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body{
        margin:30px

        }
    .form-group{
        margin:20px
    }
    .btn-primary{
        margin:20px

    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Form to edit selected book -->
            <h3>Search For A Book</h3>
            <div class="container-fluid">

                <asp:TextBox ID="search" runat="server" class="form-control me-2" type="search" placeholder="Search" aria-label="Search"></asp:TextBox>
                <asp:Button runat="server" class="btn btn-outline-success" type="submit" Text="Search" OnClick="Unnamed_Click"></asp:Button>

            </div>
            <div class="form-group" id="divBookId" >
                <label for="txtBookId">Book ID</label>
                <asp:TextBox ID="txtBookId" runat="server" CssClass="form-control" Enabled="false" />
            </div>
            <div class="form-group" id="divBookName" >
                <label for="txtBookName">Book Name</label>
                <asp:TextBox ID="txtBookName" runat="server" CssClass="form-control" Enabled="false" />
            </div>
            <div class="form-group" id="divBookKind" >
                <label for="txtBookKind">Book Kind</label>
                <asp:TextBox ID="txtBookKind" runat="server" CssClass="form-control" Enabled="false" />
            </div>
            <div class="form-group" id="divBookLevel" >
                <label for="txtBookLevel">Book Level</label>
                <asp:TextBox ID="txtBookLevel" runat="server" CssClass="form-control" Enabled="false" />
            </div>
            <asp:button runat="server" type="button" class="btn btn-primary"  Text="Edit" ID="btnEdit" OnClick="btnEdit_Click"  style="display:none"></asp:button>
            <asp:button runat="server" type="button" class="btn btn-primary"  Text="Save" ID="btnSave" OnClick="btnSave_Click" style="display:none"></asp:button>
            
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</body>
</html>
