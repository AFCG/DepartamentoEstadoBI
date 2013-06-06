<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Charts.aspx.cs" Inherits="DepartamentoDeEstadoBI.Charts" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager runat="server" ID="tsmMain">
    </asp:ScriptManager>
    <div>
        
        <div>
        <act:BarChart runat="server" ID="bcCorpClassesByYear" CategoriesAxis="2008, 2009, 2010, 2011, 2012" ChartType="Column" 
        ChartTitle="Clases de Corporaciones" ChartWidth="600" Width="800"  ChartHeight="400" Height="800" ValueAxisLines="3"  >
        </act:BarChart>
        </div>
        
        <div>
        <act:BarChart runat="server" ID="bcCorpOrganizationTypes" CategoriesAxis="2008, 2009, 2010, 2011, 2012" ChartType="Column" 
        ChartTitle="Tipos de Organizaciones" ChartWidth="600" Width="800"  ChartHeight="400" Height="800" ValueAxisLines="3"  >
        </act:BarChart>
        </div>
        
        <div>
        <act:PieChart runat="server" id="pcCorpTypes" ChartTitle="Tipos de Corporaciones" 
        ChartWidth="600" Width="800" ChartHeight="400" Height="800"></act:PieChart>
        </div>
        
        <div>
        <act:PieChart runat="server" id="pcJurisdictionTypes" ChartTitle="Tipos de Jurisdiccion" 
        ChartWidth="600" Width="800" ChartHeight="400" Height="800"></act:PieChart>
        </div>
    </div>
    </form>
</body>
</html>
