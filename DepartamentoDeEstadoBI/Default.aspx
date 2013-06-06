<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DepartamentoDeEstadoBI._Default" Theme="MasterTheme" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#404040">
    <form id="form1" runat="server">
    <asp:ScriptManager runat="server" ID="tsmMain">
    </asp:ScriptManager>
<div style="width:1500px; margin-left:auto; margin-right:auto; background-color:White;">
<!-- HEADER -->
    <div style="background-image:url(App_Themes/MasterTheme/images/TOPRepeater.jpg); background-repeat:repeat-x;" >
        <img src="App_Themes/MasterTheme/images/TOP.jpg" width="510px;" />
    </div>
    <!-- BODY -->
    <div style="margin-left:auto; margin-right:auto;text-align:center;">
        <br /><br />
        <asp:Label ID="lblTitle" runat="server" Text="Datos Estadísticos de Creación de Organizaciones" style="font-size:18pt;font-weight:bold;"></asp:Label><br />
        <asp:Label ID="lblSubTitle" runat="server" Text="2008-2012" style="font-size:14pt;"></asp:Label><br /><br />
    </div>
    <div>
        <div style="float:left">
            <act:BarChart runat="server" ID="bcCorpClassesByYear" CategoriesAxis="2008, 2009, 2010, 2011, 2012" ChartType="Column" 
            ChartTitle="Clases de Corporaciones" ChartWidth="600" Width="730px"  ChartHeight="500" Height="600" ValueAxisLines="3"  >
            </act:BarChart>
        </div>
        <div style="float:right">
            <act:BarChart runat="server" ID="bcCorpOrganizationTypes" CategoriesAxis="2008, 2009, 2010, 2011, 2012" ChartType="Column" 
            ChartTitle="Tipos de Organizaciones" ChartWidth="600" Width="730px"  ChartHeight="500" Height="600" ValueAxisLines="3"  >
            </act:BarChart>
        </div> 
        <div style="clear:both;"></div>
        <div style="float:left">
            <act:PieChart runat="server" id="pcCorpTypes" ChartTitle="Tipos de Corporaciones" 
                ChartWidth="530px" Width="730px" ChartHeight="400" Height="500"></act:PieChart>
        </div>
        <div style="float:right">
            <act:PieChart runat="server" id="pcJurisdictionTypes" ChartTitle="Tipos de Jurisdiccion" 
                ChartWidth="530px" Width="730px" ChartHeight="400" Height="500"></act:PieChart>
        </div>
        <div style="clear:both;"></div>
        <br />
    </div>
</div>
<!-- FOOTER -->
<div style="width:1500px;margin-left:auto; margin-right:auto;margin-top:10px;">
    <div style="float:left; text-align:center;">
        <img src="App_Themes/MasterTheme/images/SomoMasGrande.jpg" width="100px" /><br />
        <asp:Label ID="lblFooter1" runat="server" Text="Somos Más Grandes" style="color:White; font-size:18pt;font-weight:bold;"></asp:Label><br />
        <asp:Label ID="lblFooter2" runat="server" Text="@SomosGrandesPR" style="color:White; font-size:12pt;"></asp:Label>
    </div>
    <div style="float:right">
        <img src="App_Themes/MasterTheme/images/AFCG Logo.png" width="200px" height="125px" />
    </div>
    <div style="clear:both;"></div>
</div>
</form>
</body>
</html>
