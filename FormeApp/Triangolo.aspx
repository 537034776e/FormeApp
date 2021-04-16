<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Triangolo.aspx.cs" Inherits="FormeApp.Triangolo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div runat="server" style="padding-top:10px">
                <h2 style="text-align:center;font-size:20px">Scegliere il tipo di triangolo</h2>
    <table>
        <tr>

            <td><asp:Button runat="server" Width="150px" Style="margin-left:320px" ID="btnEquilatero" Text="Equilatero" OnClick="btnEquilatero_Click"/></td>
            <td><asp:Button runat="server" Width="150px" Style="margin-left:20px" ID="btnIsoscele" Text="Isoscele" OnClick="btnIsoscele_Click"/></td>
            <td><asp:Button runat="server" Width="150px" Style="margin-left:20px" ID="btnScaleno" Text="Scaleno" OnClick="btnScaleno_Click"/></td>
        </tr>
       
        </table>
        <br />
     <asp:Button runat="server" Width="150px" Style="margin-left:500px;" ID="btnIndietro" Text="Indietro" OnClick="btnIndietro_Click"/>
        </div>
</asp:Content>
