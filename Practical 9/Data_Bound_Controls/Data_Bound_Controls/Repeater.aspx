<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Repeater.aspx.cs" Inherits="Data_Bound_Controls.Repeater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                <HeaderTemplate>
                    <table class="tblcolor">
                        <tr>
                            <td>Id</td>
                            <td>Student Name</td>
                            <td>Gender</td>
                            <td>Total Marks</td>
                        </tr>
                </HeaderTemplate>

                <ItemTemplate>
                    <tr class="tblrowcolor">
                        <td><%#DataBinder.Eval(Container,"DataItem.Id") %></td>
                        <td><%#DataBinder.Eval(Container,"DataItem.Name") %></td>
                        <td><%#DataBinder.Eval(Container,"DataItem.Gender") %></td>
                        <td><%#DataBinder.Eval(Container,"DataItem.TotalMarks") %></td>
                    </tr>
                </ItemTemplate>

                <SeparatorTemplate>
                    <tr>
                        <td><hr /></td>
                        <td><hr /></td>
                        <td><hr /></td>
                        <td><hr /></td>
                    </tr>
                </SeparatorTemplate>

                <AlternatingItemTemplate>
                    <tr>
                        <td><%#DataBinder.Eval(Container,"DataItem.Id") %></td>
                        <td><%#DataBinder.Eval(Container,"DataItem.Name") %></td>
                        <td><%#DataBinder.Eval(Container,"DataItem.Gender") %></td>
                        <td><%#DataBinder.Eval(Container,"DataItem.TotalMarks") %></td>
                    </tr>
                </AlternatingItemTemplate>

                <SeparatorTemplate>
                    <tr>
                        <td><hr /></td>
                        <td><hr /></td>
                        <td><hr /></td>
                        <td><hr /></td>
                    </tr>
                </SeparatorTemplate>

                <FooterTemplate>
                    <tr>
                        <td>Data Stored</td>
                    </tr>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
