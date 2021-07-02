<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HesaplamaOdev.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 291px">
    <form id="form1" runat="server">
        <div>
           
        </div>    
        
        test
       
       Öğrenci Adı Soyadı  : Ercan Hamzaoğlu&nbsp;&nbsp;&nbsp; Öğr.No: 200510036&nbsp;&nbsp;&nbsp;(TC:23465511300)
        <p>
            <asp:Label ID="Label1" runat="server" Text="Sayı 1 :  "></asp:Label>
            <asp:TextBox ID="txtSayi1" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" Text="Sayı 2  :  "></asp:Label>
        <asp:TextBox ID="txtSayi2" runat="server"></asp:TextBox>
        <p>
            <b>&nbsp; 
            <asp:Button ID="BtnTopla" runat="server" OnClick="BtnTopla_Click" Text="Toplama" />
&nbsp; </b>
            <asp:Button ID="BtnCikart" runat="server" OnClick="BtnCikart_Click" Text="Çıkartma" /><b>&nbsp; </b>

            <asp:Button ID="BtnCarp" runat="server" OnClick="BtnCarp_Click" Text="Çarpma" /><b>&nbsp; </b>

            <asp:Button ID="BtnBol" runat="server" OnClick="BtnBol_Click" Text="Bölme" />
        </p>
        <p>
            &nbsp;<asp:Label ID="lblSonuc" runat="server" Text="   Sonuç  :"></asp:Label  >
        </p>
    </form>
</body>
</html>
