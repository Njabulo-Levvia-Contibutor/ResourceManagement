<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:TextBox ID="txtTableName" runat="server" />
    <asp:RequiredFieldValidator ErrorMessage="Required" ControlToValidate="txtTableName"
 Display ="Dynamic" runat="server" />
<asp:Button Text="Create Table" OnClick="CreateTable" runat="server" />

    </form>

</body>
</html>

