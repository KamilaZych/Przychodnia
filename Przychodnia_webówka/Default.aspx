<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Przychodnia_webówka._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
            <h2><span style="font-size: xx-large">Zaloguj</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h2>
            <p>
                Login (twój e-mail):&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox_email_login" runat="server" OnTextChanged="TextBox1_TextChanged" Width="263px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </p>
        <p>
                Hasło:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox_hasło" runat="server" Width="263px" OnTextChanged="TextBox_hasło_TextChanged"></asp:TextBox>
            &nbsp;</p>
        <p>
                <span style="font-size: medium">
                <asp:Label ID="Label1" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </p>
        <p>
                <asp:Button ID="Button1" runat="server" Height="40px" OnClick="Button1_Click" Text="Zaloguj" Width="208px" />
                <asp:Button ID="Button6" runat="server" Height="40px" OnClick="Button6_Click" Text="Wyloguj" Width="208px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="font-size: medium"> </span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
        <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
            <p style="font-size: xx-large">
                &nbsp;</p>
            <p style="font-size: xx-large">
                <asp:Label ID="Label6" runat="server" Text="Zaplanowane wizyty dla: " Visible="False"></asp:Label>
                &nbsp;<asp:Label ID="Label7" runat="server"></asp:Label>
                &nbsp;&nbsp;</p>
            <p style="font-size: xx-large">
                &nbsp;</p>
            <p>
                <asp:Label ID="Label3" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;
                </p>
            <p style="font-size: xx-large">
                <asp:Label ID="Label_Umów_się" runat="server" Text="Umów się na wizytę" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
        <p style="font-size: xx-large">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</p>
            <p style="font-size: medium">
                <asp:Label ID="Label_Czynność" runat="server" Text="Wybierz czynność medyczną:" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList2" runat="server" Height="30px" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged" Width="405px" style="font-size: medium" OnTextChanged="DropDownList2_TextChanged" Visible="False">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" Height="30px" OnClick="Button3_Click1" Text="Wybierz" Width="80px" Visible="False" />
                </p>
        <p style="font-size: medium">
                <asp:Label ID="Label_Lekarz" runat="server" Text="Wybierz lekarza:" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" Height="30px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="405px" style="font-size: medium" OnTextChanged="DropDownList1_TextChanged" Visible="False">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button4" runat="server" Height="30px" OnClick="Button4_Click" Text="Wybierz" Width="80px" Visible="False" />
                </p>
            <p>
                <span style="font-size: medium">
                <asp:Label ID="Label_Dzień" runat="server" Text="Wybierz dzień wizyty:" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; </span>
                <asp:DropDownList ID="DropDownList3" runat="server" Height="30px" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" Width="405px" style="font-size: medium" Visible="False">
                </asp:DropDownList>
                <span style="font-size: medium">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button5" runat="server" Height="30px" OnClick="Button5_Click" Text="Wybierz" Width="80px" Visible="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            </p>
            <p>
                <span style="font-size: medium">
                <asp:Label ID="Label_godzina" runat="server" Text="Wybierz godzinę wizyty:" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp; </span>
                <asp:DropDownList ID="DropDownList4" runat="server" Height="30px" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged" Width="405px" Visible="False">
                </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;
            </p>
        <p>
                &nbsp;</p>
        <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Umów się na wizytę" Width="263px" Height="40px" Visible="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server"></asp:Label>
                &nbsp;
            </p>
        <p>
                &nbsp;</p>
            <p>
                <br />
                &nbsp;&nbsp;</p>
    </div>

</asp:Content>
