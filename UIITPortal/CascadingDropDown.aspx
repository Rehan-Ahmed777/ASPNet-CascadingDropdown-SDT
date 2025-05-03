<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CascadingDropDown.aspx.cs" Inherits="CascadingDropDown" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Cascading DropDown Demo</title>
    <style>
        body {
            background-color: lightgray;
            font-family: Arial, sans-serif;
        }

        .form-container {
            background-color: white;
            padding: 30px;
            margin: 60px auto;
            width: 600px;
            border: 1px solid gray;
            border-radius: 8px;
            font-size: 16px;
        }

        h2 {
            text-align: center;
            font-size: 22px;
        }

        table {
            width: 100%;
        }

        td {
            padding: 10px;
        }

        select {
            width: 100%;
            padding: 8px;
            font-size: 16px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h2>Cascading Dropdown List Demos</h2>
            <table>
                <tr>
                    <td>Select Country</td>
                    <td>
                        <asp:DropDownList ID="ddCountry" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddCountry_SelectedIndexChanged" />
                    </td>
                </tr>
                <tr>
                    <td>Select State</td>
                    <td>
                        <asp:DropDownList ID="ddState" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddState_SelectedIndexChanged" />
                    </td>
                </tr>
                <tr>
                    <td>Select City</td>
                    <td>
                        <asp:DropDownList ID="ddCity" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
