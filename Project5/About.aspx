<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Project5.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
     
<h1>Varshith Poonati - Project 5, Assignment 6 - Service Directory</h1>
<p style="font-size: smaller;">CSE445 - June 2023</p>


<table style="border-collapse:inherit; width:inherit;">
  <tr>
    <td colspan="5">This page is deployed by Varshith Poonati: <a href="http://webstrar55.fulton.asu.edu/index.html">http://webstrar55.fulton.asu.edu/index.html</a></td>
  </tr>
  <tr>
    <th>Provider Name</th>
    <th>Service Name</th>
    <th>TryIt Link</th>
    <th>Service Description</th>
    <th>Planned Resources</th>
  </tr>
  <tr>
    <td>Varshith Poonati</td>
    <td>LocateNearStore</td>
    <td><a href="http://webstrar55.fulton.asu.edu/page1/about">TryIt Link</a></td>
    <td>It gives the nearby stores for a given ZipCode.</td>
    <td>Google Places API</td>
  </tr>
  <tr>
    <td></td>
    <td>Input: string (zipcode) string (Storename)</td>
    <td></td>
    <td></td>
    <td> This Service consists of 3 services it uses DistanceMatriX API to find the Distance, Geocode API to find the coordinates, Finally it uses Places API to get ratings and other information</td>
  </tr>
  <tr>
    <td></td>
    <td>Output: string</td>
    <td></td>
    <td></td>
    <td></td>
  </tr>
  <tr>
    <td>Varshith Poonati</td>
    <td>WordFilter</td>
    <td><a href="http://webstrar55.fulton.asu.edu/page3/">TryIt Link</a></td>
    <td>WORD FILTER(Removes Default Stop words and basic XML Tags/attributes.</td>
    <td></td>
  </tr>
  <tr>
    <td></td>
    <td>Input: string (with XML Attributes)</td>
    <td></td>
    <td></td>
    <td> The Input has different XML Tags and attributes which gets cleared and a filtered string is returned to the user.</td>
  </tr>
  <tr>
    <td></td>
    <td>Output: String with filtered stop words.</td>
    <td></td>
    <td></td>
    <td></td>
  </tr>
  <tr>
    <td>Varshith Poonati</td>
    <td>WordCount</td>
    <td><a href="http://webstrar55.fulton.asu.edu/page6">TryIt Link</a></td>
    <td>Searched the whole large text file document to return how many times each word occured in the Document.</td>
    <td>It uses the dictionary to find and group words.</td>
  </tr>
  <tr>
    <td></td>
    <td>Input: a large text file </td>
    <td></td>
    <td></td>
    <td>Uses the DIsctionary attribute of C#</td>
  </tr>
  <tr>
    <td></td>
    <td>Output: JSON Text </td>
    <td></td>
    <td></td>
    <td></td>
  </tr>
    </table>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; This is the Hash Testing Feature<br />
    <br />
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Height="64px" Width="397px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Height="64px" OnClick="Button2_Click" Text="Encrypt" Width="271px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Encrypted Value"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:TextBox ID="TextBox2" runat="server" Height="64px" Width="397px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" Height="64px" OnClick="Button3_Click" Text="Decrypt" Width="271px" />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Decrypted Value"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
