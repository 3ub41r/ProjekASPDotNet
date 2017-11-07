<%@ Page Title="" Language="C#" MasterPageFile="~/Metronic.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="TrainingASPDotNet.PencapaianProgram.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!-- BEGIN: Subheader -->
    <div class="m-subheader ">
        <div class="d-flex align-items-center">
            <div class="mr-auto">
                <h3 class="m-subheader__title ">
                    Kemaskini Pencapaian Program
                </h3>
            </div>
        </div>
    </div>
    <!-- END: Subheader -->

    <div class="form-group">
        <label>Kod Program</label>
        <asp:TextBox ID="KodProgram" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    
    <div class="form-group">
        <label>Tarikh Program</label>
        <asp:TextBox ID="TarikhProgram" CssClass="form-control" runat="server"></asp:TextBox>
    </div>

    <div class="form-group">
        <label>Bilangan Hari</label>
        <asp:TextBox ID="BilanganHari" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    
    <div class="form-check">
        <label class="form-check-label">
            <asp:CheckBox ID="Lulus" CssClass="form-check-input" runat="server" />
            Lulus
        </label>
    </div>
    
    <asp:Button ID="SubmitBtn" CssClass="btn btn-primary" runat="server" Text="Simpan" OnClick="SubmitBtn_Click" />
</asp:Content>
