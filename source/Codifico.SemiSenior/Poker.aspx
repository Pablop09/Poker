<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Poker.aspx.cs" Inherits="Codifico.SemiSenior.Poker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="shortcut icon" type="image/x-icon" href="Content/images/poker.ico"/> 
    <link rel="stylesheet" type="text/css" href="Content/styles/style.css" />
    <script type="text/javascript" src="Content/scripts/jquery-1.10.2.js"></script>
    <script>
        $(document).ready(function () {
        $("#<%=DealCards.ClientID %>").click(function()  {
            alert("pablito");
            var route = "/Content/cards/10_of_hearts.png";
            $('.Card1').attr("src", "/Content/cards/10_of_clubs.png");
            $('.Card3').attr("src", route);
            document.getElementById('<%=Card2.ClientID%>').setAttribute('src', '/Content/cards/10_of_clubs.png');

            $.ajax({
                url: 'Poker.aspx/InitGame',
                type: 'POST',
                dataType: 'json', 
                contentType: 'application/json',
                success: function (result) {
                    alert("Metodo ejecutandose!")
                }
            });
        })
        });
    </script>
    <title>Poker Game</title>
</head>
<body>
    <div id="container"><form id="form1" runat="server">
    <header><div id="image_title"><img style="float:left; height: 145px; width: 254px;" src="Content/images/poker_title.png"/></div><h1><span id="title">Poker Game</span></h1></header>
        <p>
            &nbsp;</p>
        <div id="cards">
            <asp:Image ID="Card1" CssClass="Card1" runat="server" Height="203px" Width="145px" />
            <asp:Image ID="Card2" CssClass="Card2" runat="server" Height="203px" Width="145px" />
            <asp:Image ID="Card3" CssClass="Card3" runat="server" Height="203px" Width="145px" />
            <asp:Image ID="Card4" CssClass="Card4" runat="server" Height="203px" Width="145px" />
            <asp:Image ID="Card5" CssClass="Card5" runat="server" Height="203px" Width="145px" /><br/><br/>
            <div id="dealsection"><asp:Button ID="DealCards" runat="server" Text="Deal cards" OnClientClick="return false"
            BorderColor="#CCFFCC" ForeColor="Black" Height="45px" Width="136px" Font-Bold="True" Font-Size="Medium" /></div>
        </div>
    </form>
    </div>
</body>
</html>
