<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reg.aspx.cs" Inherits="project1.reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style>
      body {
     font-family: Arial;
     background: #f2f5fa;
 }

 .main-panel {
     width: 800px;
     margin: 60px auto;
     display: flex;
     background: white;
     border-radius: 10px;
     overflow: hidden;
     box-shadow: 0 4px 15px #d5dce8;
     align-content:center;
 }

 .registration-panel {
     width: 55%;
     padding: 30px;
 }

 .welcome-panel {
     width: 45%;
     padding: 30px;
     background: #e3eafa;
     text-align: center;
     display: flex;
     flex-direction: column;
     justify-content: center;
 }

 .form-group {
     margin-bottom: 15px;
 }

 .form-control {
     width: 100%;
     padding: 10px;
     border: 1px solid #ccd4e0;
     border-radius: 5px;
     box-sizing: border-box;
 }

 .register-btn {
     width: 100%;
     padding: 12px;
     background: #6179c9;
     color: white;
     border: none;
     border-radius: 5px;
     cursor: pointer;
 }

 h2 {
     color: #34476b;
 }

 .welcome-panel p {
     color: #65748b;
     line-height: 1.7;
 }
     </style>
</head>
<body>
    <form id="form1" runat="server">
                        <div class="main-panel">

<asp:Panel ID="pnlCustomerRegistration"
    runat="server" CssClass="registration-panel">

    <h2>&nbsp;Create Account</h2>
    <p>Register as a new customer</p>

    <div class="form-group">
        <asp:Label runat="server" Text="Full Name" />
        <asp:TextBox ID="txtName" runat="server"
            CssClass="form-control" />
    </div>
    <div class="form-group">
    <asp:Label runat="server" Text="Phone Number" />
    <asp:TextBox ID="txtphone" runat="server"
        TextMode="Phone" CssClass="form-control" />
    <br />
</div>

    <div class="form-group">
        <asp:Label runat="server" Text="Email" />
        <asp:TextBox ID="txtEmail" runat="server"
            TextMode="Email" CssClass="form-control" />
        <br />
    </div>

    <div class="form-group">
        <asp:Label runat="server" Text="Password" />
        <asp:TextBox ID="txtPassword" runat="server"
            TextMode="Password" CssClass="form-control" />
    </div>

    <div class="form-group">
        <asp:Label runat="server" Text="Confirm Password" />
        <asp:TextBox ID="txtConfirmPassword" runat="server"
            TextMode="Password" CssClass="form-control" />
    </div>

    <asp:Button ID="btnRegister" runat="server"
        Text="Register" CssClass="register-btn"
        OnClick="btnRegister_Click" />

</asp:Panel>


    </div>
    </form>
</body>
</html>
