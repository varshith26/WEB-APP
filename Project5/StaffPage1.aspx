<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StaffPage1.aspx.cs" Inherits="Project5.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>&nbsp;</h1>
<h1>&nbsp;</h1>
<h1>&nbsp;</h1>
<h1>WordCount Please Upload a file to get the word count occurence of a word</h1>\
    <br />
    <asp:FileUpload ID="FileUpload1" runat="server" Height="153px" Width="1186px" />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Height="121px" OnClick="Button1_Click1" Text="Submit file" Width="309px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
<br />
<br />
<asp:Label ID="Label1" runat="server" Height="100%" Text="Result" Width="1000px"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />


   

</asp:Content>
