<%@ Page Title="" Language="C#" MasterPageFile="~/kpt.master" AutoEventWireup="true" CodeBehind="courselogin.aspx.cs" Inherits="kpt.courselogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMain" runat="server">

    <div class="article">
        <div class="textfield-left">
            <div class="leaf-login"><img src="images/leaf.png" /></div>
            <div class="center"><h2>Hej</h2></div>
            <p><b>Välkommen till din sida</b></p>
            <p>Från den här sidan kan du starta ditt test. 
                Om det är första gången så kommer du att få besvara 25 frågor. 
                Om du ska genomföra din årliga kunskapsuppdatering besvarar du 15 frågor.</p>
            <p>För att klara testet så måste du svara rätt på minst 70% av frågorna
                och minst 60% på varje delmoment.</p>
            <p>Testet består av 3 delar som är:</p>
                <ul>
                    <li>Produkter och hantering av kundens affärer</li>
                    <li>Ekonomi – nationalekonomi, finansiell ekonomi och privatekonomi</li>
                    <li>Etik och regelverk</li>
                </ul>                               
        </div>
        <div class="vr"></div>
        <div class="textfield-right textfield-responsive">
            <p>Du lämnar normalt ett svar per fråga men det kan finnas frågor som
                kräver flera svar. Detta står då på respektive fråga.</p>
            <p>Du har 30 minuter på dig att slutföra testet.</p>
            <p><i>Lycka till!!</i></p>
            <form runat="server">                                                               
                <asp:Button ID="btnLastExam" CssClass="login-button" runat="server" Text="Se föregående test" OnClick="btnLastExam_Click"  />&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnStartExam" CssClass="login-button" runat="server" Text="Starta test" OnClick="btnStartExam_Click" />
            </form>
        </div>
	</div>

</asp:Content>
