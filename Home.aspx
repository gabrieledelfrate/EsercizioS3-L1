<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PraticaS3L1.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnShowCandidate" runat="server" Text="Mostra Candidato" OnClick="btnShowCandidate_Click" />
            <asp:Label ID="lblCandidateInfo" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
