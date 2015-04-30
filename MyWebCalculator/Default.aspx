<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:TextBox ID="txtResult" runat="server" Width="276px" style="float:left; clear:right; margin-top:40px;"></asp:TextBox>
    <asp:Button ID="btn1" runat="server" Text="1" Width="30px"  OnClick="btn1_Click" style="clear:left; float:left; margin-top:20px; margin-left:30px;" />
    <asp:Button ID="btn2" runat="server" Text="2" Width="30px" OnClick="btn2_Click" style="float:left; margin-top:20px; margin-left:30px;" />
    <asp:Button ID="btn3" runat="server" Text="3" Width="30px" OnClick="btn3_Click" style="float:left; margin-top:20px; margin-left:30px;" />
    <asp:Button ID="txtClear" runat="server" Text="C" Width="30px" OnClick="txtClear_Click" style="clear:right; float:left; margin-top:20px; margin-left:30px;" />

    <asp:Button ID="btn4" runat="server" Text="4" Width="30px" OnClick="btn4_Click" style="clear:left; float:left; margin-top:20px; margin-left:30px;" />
    <asp:Button ID="btn5" runat="server" Text="5" Width="30px" OnClick="btn5_Click" style="float:left; margin-top:20px; margin-left:30px;" />
    <asp:Button ID="btn6" runat="server" Text="6" Width="30px" OnClick="btn6_Click" style="float:left; margin-top:20px; margin-left:30px;" />
    <asp:Button ID="btnAdd" runat="server" Text="+" Width="30px" OnClick="btnAdd_Click" style="clear:right; float:left; margin-top:20px; margin-left:30px;" />

    <asp:Button ID="btn7" runat="server" Text="7" Width="30px" OnClick="btn7_Click" style="clear:left; float:left; margin-top:20px; margin-left:30px;" />
    <asp:Button ID="btn8" runat="server" Text="8" Width="30px" OnClick="btn8_Click" style="float:left; margin-top:20px; margin-left:30px;" />
    <asp:Button ID="btn9" runat="server" Text="9" Width="30px" OnClick="btn9_Click" style="float:left; margin-top:20px; margin-left:30px;" />
    <asp:Button ID="btnSub" runat="server" Text="-" Width="30px" OnClick="btnSub_Click" style="clear:right; float:left; margin-top:20px; margin-left:30px;" />

    <asp:Button ID="btnDecimalPoint" runat="server" Width="30px" Text="." OnClick="btnDecimalPoint_Click" style="clear:left; float:left; margin-top:20px; margin-left:30px;" />
    <asp:Button ID="btn0" runat="server" Text="0" Width="30px" OnClick="btn0_Click" style="float:left; margin-top:20px; margin-left:30px;" />
    <asp:Button ID="btnEquals" runat="server" Text="=" Width="30px" OnClick="btnEquals_Click" style="float:left; margin-top:20px; margin-left:30px;" />
    <asp:Button ID="btnMultiply" runat="server" Text="x" Width="30px" OnClick="btnMultiply_Click" style="clear:right; float:left; margin-top:20px; margin-left:30px;" />
    <asp:Button ID="btnDivide" runat="server" Text="/" Width="30px" OnClick="btnDivide_Click" style="clear:left; float:left; margin-top:20px; margin-left:30px;" />
</asp:Content>
