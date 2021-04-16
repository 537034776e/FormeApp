<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Quadrato.aspx.cs" Inherits="FormeApp.Quadrato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div runat="server" style="padding-top:10px">
                        <h2 style="text-align:center;font-size:20px">Calcolo dell'area e del perimetro del quadrato</h2>
    <table><tr style="line-height:3"><td style="font-size:20px;">Inserire il lato del quadrato: </td>
        <td>
    <asp:TextBox Height="23px" runat="server" ID="txtLatoQuadrato"></asp:TextBox></td></tr>
    
        <tr><td>    <asp:Button runat="server" Width="150px" Style="margin-left:20px" ID="btnCalcola" Text="Calcola" OnClick="btnCalcola_Click"/>
</td>
         <td>    <asp:Button runat="server" Width="150px" Style="margin-left:350px" CausesValidation="false" ID="btnIndietro" Text="Indietro" OnClick="btnIndietro_Click"/>
</td></tr>
        </table>
          <br />
    <asp:Label ID="lblCalcolo" runat="server"></asp:Label>
                <br />
                <asp:Label runat="server" ID="lblDimensioni"></asp:Label>

        </div>
      <asp:RequiredFieldValidator ID="LatoValidator" runat="server"
            ControlToValidate="txtLatoQuadrato" ErrorMessage="Inserisci il lato" Display="None"
            ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:ValidationSummary runat="server" ShowMessageBox="true" ShowSummary="false" />
</asp:Content>
