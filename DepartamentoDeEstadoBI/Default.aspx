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
<div style="width:1500px; height:800px;margin-left:auto; margin-right:auto; background-color:White;">
<!-- HEADER -->
    <div style="background-image:url(App_Themes/MasterTheme/images/TOPRepeater.jpg); background-repeat:repeat-x;" >
        <img src="App_Themes/MasterTheme/images/TOP.jpg" width="510px;" />
    </div>
    <!-- BODY -->
    <div style="height:700px;">

    </div>
        <!-- FOOTER -->
    <div>
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
</div>
</form>
</body>
</html>
