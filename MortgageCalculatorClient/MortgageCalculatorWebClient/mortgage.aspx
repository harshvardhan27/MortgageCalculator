<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mortgage.aspx.cs" Inherits="MortgageCalculatorWebClient.mortgage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mortgage Calculator</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap-grid.css" rel="stylesheet" />
</head>
<body>
    <form id="frmMortgage" runat="server" autocomplete="off">
        <nav class="navbar navbar-light bg-secondary">
            <a class="navbar-brand" href="mortgage.aspx" style="color: #fff;">Mortgage Calculator</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav mr-auto">
                    <%--<li class="nav-item active">
                        <a class="nav-link" href="mortgage.aspx">Home <span class="sr-only">(current)</span></a>
                    </li>--%>
                </ul>
            </div>
        </nav>
        <div class="container">
            <div class="clearfix">&nbsp;</div>
            <div class="row">
                <div class="col-lg-6">
                    <div class="form-group row">
                        <asp:Label ID="lblPurchasePrice" runat="server" Text="Purchase Price" class="col-sm-4 col-form-label text-right" for="txtPurchasePrice"></asp:Label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtPurchasePrice" runat="server" class="form-control" placeholder="Purchase Price" required=""></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <asp:Label ID="lblInterestRate" runat="server" Text="Interest Rate" class="col-sm-4 col-form-label text-right" for="txtInterestRate"></asp:Label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtInterestRate" runat="server" class="form-control" placeholder="Interest Rate" required=""></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <asp:Label ID="lblAmortization" runat="server" Text="Amortization" class="col-sm-4 col-form-label text-right" for="ddlAmortization"></asp:Label>
                        <div class="col-sm-8">
                            <asp:DropDownList ID="ddlAmortization" runat="server" class="form-control" required="">
                                <asp:ListItem Text="10 Years" Value="10"></asp:ListItem>
                                <asp:ListItem Text="15 Years" Value="15"></asp:ListItem>
                                <asp:ListItem Text="25 Years" Value="25" Selected="True"></asp:ListItem>
                                <asp:ListItem Text="30 Years" Value="30"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="form-group row">
                        <asp:Label ID="lblPercentDown" runat="server" Text="Precent Down" class="col-sm-4 col-form-label text-right" for="ddlPercentDown"></asp:Label>
                        <div class="col-sm-8">
                            <asp:DropDownList ID="ddlPercentDown" runat="server" class="form-control" required="">
                                <asp:ListItem Text="5%" Value="5"></asp:ListItem>
                                <asp:ListItem Text="10%" Value="10"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="form-group row">
                        <asp:Label ID="lblTaxes" runat="server" Text="Taxes" class="col-sm-4 col-form-label text-right" for="txtTaxes"></asp:Label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtTaxes" runat="server" class="form-control" placeholder="Interest Rate" required=""></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-6">
                    <div class="form-group row">
                        <div class="col-sm-8 offset-sm-4">
                            <asp:Button ID="btnCalculateMortgage" runat="server" Text="Calculate Mortgage" CssClass="btn btn-success" OnClick="btnCalculateMortgage_Click" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">

                <div class="alert alert-secondary col-lg-12" role="alert">

                    <p class="text-center"><strong>Mortgage Details</strong></p>

                    <div class="row">
                        <div class="col-lg-6">
                            <div class="form-group row">
                                <asp:Label ID="lblDownPayment" runat="server" Text="Down Payment" class="col-sm-4 col-form-label text-right" for="txtDownPaymnet"></asp:Label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtDownPaymnet" runat="server" class="form-control" placeholder="Down Payment"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <asp:Label ID="lblRemainingMortgage" runat="server" Text="Remaining Mortgage" class="col-sm-4 col-form-label text-right" for="txtRemainingMortgage"></asp:Label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtRemainingMortgage" runat="server" class="form-control" placeholder="Remaining Mortgage"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <asp:Label ID="lblGePremium" runat="server" Text="GE Premium" class="col-sm-4 col-form-label text-right" for="txtGePremium"></asp:Label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtGePremium" runat="server" class="form-control" placeholder="GE Premium"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <asp:Label ID="lblTotalFinancing" runat="server" Text="Total Financing" class="col-sm-4 col-form-label text-right" for="txtTotalFinancing"></asp:Label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtTotalFinancing" runat="server" class="form-control" placeholder="Total Financing"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6">
                            <div class="form-group row">
                                <asp:Label ID="lblMonthlyMortgagePayment" runat="server" Text="Monthly Payment" class="col-sm-4 col-form-label text-right" for="txtMonthlyMortgagePayment"></asp:Label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtMonthlyMortgagePayment" runat="server" class="form-control" placeholder="Monthly Payment"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <asp:Label ID="lblFees" runat="server" Text="Taxes/Fees" class="col-sm-4 col-form-label text-right" for="txtFees"></asp:Label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtFees" runat="server" class="form-control" placeholder="Taxes/Fees"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <asp:Label ID="lblTotalPayment" runat="server" Text="Total Payment" class="col-sm-4 col-form-label text-right" for="txtTotalPayment"></asp:Label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtTotalPayment" runat="server" class="form-control" placeholder="Total Payment"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="clearfix">&nbsp;</div>
        </div>
    </form>
    <script src="scripts/jquery-3.0.0.js"></script>
    <script src="scripts/bootstrap.js"></script>
    <script src="scripts/popper.js"></script>
</body>
</html>
