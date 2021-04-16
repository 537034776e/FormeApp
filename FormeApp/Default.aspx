<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FormeApp.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align:center;font-size:30px;">Scegliere la forma di cui si vuole calcolare il perimetro e l'area</h2>
    <br />
<asp:Button runat="server" Width="150px" Style="margin-left:250px" ID="btnTriangolo" Text="Triangolo" OnClick="btnTriangolo_Click"/>
    <asp:Button runat="server" Width="150px" Style="margin-left:20px" ID="btnRettangolo" Text="Rettangolo" OnClick="btnRettangolo_Click"/>
<asp:Button runat="server" Width="150px" Style="margin-left:20px" ID="btnCerchio" Text="Cerchio" OnClick="btnCerchio_Click"/>
    <asp:Button runat="server" Width="150px" Style="margin-left:20px" ID="btnQuadrato" Text="Quadrato" OnClick="btnQuadrato_Click"/>


</asp:Content>
