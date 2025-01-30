<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="WebApplication2.profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.1.3/css/bootstrap.min.css" rel="stylesheet">
     <style>
        body {
            font-family: Arial, sans-serif;
        }
        .profile-container {
            margin: 50px auto;
            width: 60%;
            padding: 30px;
            border: 1px solid #ddd;
            border-radius: 8px;
            background-color: #f9f9f9;
        }
        .profile-header {
            text-align: center;
        }
        .profile-header h2 {
            margin-bottom: 20px;
        }
        .profile-header .btn {
            background-color: #007bff;
            color: white;
        }
        .profile-header .btn:hover {
            background-color: #0056b3;
        }
        .form-control {
            margin-bottom: 10px;
        }
        .form-group {
            margin-bottom: 20px;
        }
    </style>
</head>
<body>
    <div class="container profile-container">
        <div class="profile-header">
            <h2>User Profile</h2>
        </div>
        <form id="profileForm" runat="server">
            <div class="form-group">
                <label for="name">Full Name:</label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" Text="John Doe" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="email">Email Address:</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Text="johndoe@example.com" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="phone">Phone Number:</label>
                <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control" Text="123-456-7890" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="address">Address:</label>
                <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control" Text="1234 Main St" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="text-center">
                <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="btn btn-primary" OnClick="btnEdit_Click" />
                <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-success" OnClick="btnSave_Click" Visible="false" />
            </div>
        </form>
    </div>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.1.3/js/bootstrap.bundle.min.js"></script>
</body>
</html>
