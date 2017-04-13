<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Calendar of Events</h1>
        <div class="cal">
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" CssClass="myCalendar">
            <WeekendDayStyle BackColor="#FFFFCC" />
        </asp:Calendar>
            </div>
        <div class="one">
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </div>
    </form>
</body>
</html>
