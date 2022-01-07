<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmWebPantalla.aspx.cs" Inherits="clienteWeb.frmWebPantalla" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Nombre del artículo"></asp:Label>
        <br />
        <asp:TextBox ID="txtArticulo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Cantidad de artículos"></asp:Label>
        <br />
        <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnVentasArticulo" runat="server" OnClick="btnVentasArticulo_Click" Text="Ventas por artículo" Width="198px" />
        <br />
        <asp:Button ID="btnVGlobales" runat="server" OnClick="btnVGlobales_Click" Text="Ventas Globales" Width="193px" />
        <br />
        <asp:Button ID="btnMasVendidos" runat="server" Text="Artículos más vendidos" Width="198px" OnClick="btnMasVendidos_Click" />
        <br />
        <asp:Button ID="btnExistentes" runat="server" Text="Productos existentes" Width="200px" OnClick="btnExistentes_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Label ID="lblAlerta" runat="server" BackColor="White" ForeColor="Red" Text="Quedan menos de 100 productos en inventario, realiza un pedido al proveedor."></asp:Label>
        <br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
