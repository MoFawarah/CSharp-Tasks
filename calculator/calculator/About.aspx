<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="calculator.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Your application description page.</h3>
        <p>Use this area to provide additional information.</p>


        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">



        <div>
            <asp:Label ID="Label1" runat="server" Text="Num1"> </asp:Label>


            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>

        <br />

        <div>
            <asp:Label ID="Label2" runat="server" Text="Num2">  </asp:Label>

            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>

        <br />

        <asp:Button ID="Button1" runat="server" Text="ADD" CssClass="btn btn-primary" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Substract" CssClass="btn btn-primary" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Multiply" CssClass="btn btn-primary" OnClick="Button3_Click" />

        <br />

        <asp:Label ID="Label4" runat="server" Text="Result: "></asp:Label>

        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>



    </main>
    </div>
</asp:Content>
