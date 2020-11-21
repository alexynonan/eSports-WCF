<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="WebHeroeComplejidad.aspx.cs" Inherits="WebWCF_eSports.Heroe.WebHeroeComplejidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Web Test Heroe Complejidad</p>
<table class="auto-style1">
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Complejidad"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="dplComplejidad" runat="server">
                <asp:ListItem>Baja</asp:ListItem>
                <asp:ListItem>Moderado</asp:ListItem>
                <asp:ListItem>Alta</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="btnSiguiente" runat="server" OnClick="btnSiguiente_Click" Text="Siguiente" />
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:GridView ID="grvDatos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="Vertical" Width="783px" BorderStyle="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </td>
    </tr>
</table>
</asp:Content>
