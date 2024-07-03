<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormPage.aspx.cs" Inherits="stuff.FormPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-group">
            <div class="form-group">
                <label for="name">Name</label>
                <asp:TextBox ID="name" runat="server" CssClass="form-control" Placeholder="Name"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="email">Email address</label>
                <asp:TextBox ID="email" runat="server" CssClass="form-control" Placeholder="Enter email"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="id">Id</label>
                <asp:TextBox ID="id" runat="server" CssClass="form-control" Placeholder="id"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="textarea">Example textarea</label>
                <asp:TextBox ID="textarea" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="3"></asp:TextBox>
            </div>
            <fieldset class="form-group">
                <legend class="col-form-label col-sm-2 pt-0">Radios</legend>
                <div class="col-sm-10">
                    <div class="form-check">
                        <asp:RadioButton ID="radioFemale" runat="server" GroupName="Gender" CssClass="form-check-input" />
                        <label class="form-check-label" for="radioFemale">Female</label>
                    </div>
                    <div class="form-check">
                        <asp:RadioButton ID="radioMale" runat="server" GroupName="Gender" CssClass="form-check-input" />
                        <label class="form-check-label" for="radioMale">Male</label>
                    </div>
                </div>
            </fieldset>
            <h3>Course</h3>
            <div class="form-check">
                <asp:CheckBox ID="courseC" runat="server" CssClass="form-check-input" />
                <label class="form-check-label" for="courseC">C</label>
            </div>
            <div class="form-check">
                <asp:CheckBox ID="courseCSharp" runat="server" CssClass="form-check-input" />
                <label class="form-check-label" for="courseCSharp">C#</label>
            </div>
            <div class="form-check">
                <asp:CheckBox ID="courseCPlusPlus" runat="server" CssClass="form-check-input" />
                <label class="form-check-label" for="courseCPlusPlus">C++</label>
            </div>
            <p>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" CssClass="btn btn-primary" />
            </p>
            <div id="output" runat="server" class="mt-3">
                <p>Name: <asp:Label ID="lblName" runat="server" Text=""></asp:Label></p>
                <p>Email: <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label></p>
                <p>Id: <asp:Label ID="lblId" runat="server" Text=""></asp:Label></p>
                <p>Textarea: <asp:Label ID="lblTextarea" runat="server" Text=""></asp:Label></p>
                <p>Gender: <asp:Label ID="lblGender" runat="server" Text=""></asp:Label></p>
                <p>Courses: <asp:Label ID="lblCourses" runat="server" Text=""></asp:Label></p>
            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
