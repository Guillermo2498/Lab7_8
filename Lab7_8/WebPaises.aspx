<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebPaises.aspx.cs" Inherits="Lab7_8.WebPaises" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:ScriptManager runat="server"></asp:ScriptManager>
            <asp:UpdatePanel runat="server" ID="upd1">
                <ContentTemplate>
                    <table> 
                        <tr>
                            <td><asp:Label runat="server" Text="Pais"></asp:Label></td>
                            <td><asp:DropDownList runat="server" ID="cmbcodPais">
                                   
                           </asp:DropDownList></td> 
                        </tr>
                        <tr>
                            <td><asp:Label runat="server" Text="Habitantes"></asp:Label></td>
                            <td><asp:TextBox runat="server" ID="txtHabitantes"></asp:TextBox> </td>                   
                        </tr>
                        <tr>
                            <td><asp:Label runat="server" Text="Idioma"></asp:Label></td>
                            <td><asp:DropDownList runat="server" ID="cmbcodIdioma">
                                   
                           </asp:DropDownList></td> 
                        </tr>
                         <tr>
                            <td><asp:Label runat="server" Text="PIB"></asp:Label></td>
                            <td><asp:TextBox runat="server" ID="txtPIB"></asp:TextBox> </td>                   
                        </tr>
                         <tr>
                            <td><asp:Label runat="server" Text="Superficie"></asp:Label></td>
                            <td><asp:TextBox runat="server" ID="txtSuperficie"></asp:TextBox> </td>                   
                        </tr>
                         <tr>
                            <td><asp:Label runat="server" Text="Riesgo"></asp:Label></td>
                            <td><asp:TextBox runat="server" ID="txtRiesgo"></asp:TextBox> </td>                   
                        </tr>
                         <tr>
                            <td><asp:Label runat="server" Text="Prestamo"></asp:Label></td>
                            <td><asp:TextBox runat="server" ID="txtPrestamo"></asp:TextBox>  </td>                   
                        </tr>

                    </table>
                    <asp:Button runat="server" ID="btnRegistrar" Text="Registrar" onclick="btnRegistrar_Click" />
                    <br />
                    <br />
                    <asp:Button runat="server" ID="btnActualiza" Text="Actualizar" OnClick="btnActualiza_Click"/>
                    <br />
                    <br />
                    <asp:Button runat="server" ID="btnElimina" Text="Eliminar" OnClick="btnElimina_Click"/>

                    <br />
                    <br />
                     <div>
                        <asp:GridView ID="gridPais" runat="server" 
                                AutoGenerateColumns="false"  
                                DataKeyNames="CodigoPais" 
                                BackColor="White" 
                                BorderColor="#999999" 
                                BorderStyle="None" 
                                BorderWidth="1px" 
                                CellPadding="3" 
                                GridLines="Vertical"                                                                             
                                >
                                <Columns>
                                    <asp:BoundField DataField="DescripcionPais" HeaderText="Pais" />
                                    <asp:BoundField DataField="Habitantes" HeaderText="Habitantes" />
                                    <asp:BoundField DataField="DescripcionIdioma" HeaderText="Idioma" />
                                    <asp:BoundField DataField="PIB" HeaderText="PIB" />
                                    <asp:BoundField DataField="Superficie" HeaderText="Superficie" />
                                     <asp:BoundField DataField="Riesgo" HeaderText="Riesgo" />
                                     <asp:BoundField DataField="SujetoP" HeaderText="Prestamo" />
                                </Columns>
                                <AlternatingRowStyle BackColor="#DCDCDC" />
                                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#000065" />
                            </asp:GridView>
                    </div>
                </ContentTemplate>

            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
