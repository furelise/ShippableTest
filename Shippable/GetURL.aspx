<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetURL.aspx.cs" Inherits="Shippable.GetURL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 573px;
        }
        #geturl {
            margin-left: 267px;
            margin-top: 99px;
        }
        #results {
            margin-left: 302px;
            margin-top: 69px;
        }
        #button {
            margin-left: 243px;
            margin-top: 53px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
   
       <div id="geturl">
    Get URL:   <asp:TextBox ID="urlText" runat="server" CausesValidation="True" Width="579px"></asp:TextBox> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="urlText" Display="Dynamic" ErrorMessage="Dont leave empty" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Not proper Github URL" ControlToValidate="urlText" Display="Dynamic" ValidationExpression="^(https://github.com/).*" ForeColor="Red"></asp:RegularExpressionValidator>
       <br />
           <div id="button">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Issue Details" />
               </div>
       <br />
       <br />
       <asp:Label ID="Label9" runat="server" Visible="False"></asp:Label>
    
       </div>
        <div id="results" runat="server" visible="false">

            

       

        <table  class="auto-style1"  id="displayTable">
            <tr>
                <td class="auto-style2">

            <asp:Label ID="Label1" runat="server" Text="Total Open Issues: "></asp:Label>
                </td>
                <td>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
            <asp:Label ID="Label3" runat="server" Text="Number of open issues that were opened in the last 24 hours: "></asp:Label>
                </td>
                <td>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
            <asp:Label ID="Label5" runat="server" Text="Number of open issues that were opened more than 24 hours ago but less than 7 days ago: "></asp:Label>
                </td>
                <td>
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
            <asp:Label ID="Label7" runat="server" Text="Number of open issues that were opened more than 7 days ago: "></asp:Label>
                </td>
                <td>
            <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>

                </td>
            </tr>
        </table>
         </div>
        <div id="table">
        </div>
    </form>
</body>
</html>
