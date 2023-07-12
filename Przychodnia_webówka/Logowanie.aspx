<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Logowanie.aspx.cs" Inherits="Przychodnia_webówka._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Logowanie do przychodni</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>&nbsp;</h2>
            <h2>Zaloguj </h2>
            <p>
                &nbsp; Login (twój e-mail):</p>
            <p>
                &nbsp;<asp:TextBox ID="TextBox_email_login" runat="server" OnTextChanged="TextBox1_TextChanged" Width="263px"></asp:TextBox>
            </p>
            <p>
                &nbsp; Hasło:</p>
            <p>
                &nbsp;<asp:TextBox ID="TextBox_hasło" runat="server" Width="263px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Height="25px" Text="Button" OnClick="Button2_Click1" />
            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
            <p>
                &nbsp;<asp:Button ID="Button1" runat="server" Height="42px" OnClick="Button1_Click" Text="Zaloguj" Width="267px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <a href="https://localhost:44309/Umawianie_się_na_wizytę.aspx" class="btn btn-primary btn-lg" media="screen" visible="True">Umów się na wizytę</a></p>
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
            <br />
            <br />
            <br />
            <br />
        </div>
    </div>

</asp:Content>
