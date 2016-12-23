namespace QuanLyDoanVien.TienIch
{
    partial class RptBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Dpi = 254F;
            this.Detail.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.StylePriority.UseFont = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TopMargin.HeightF = 200F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.StylePriority.UseFont = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.BottomMargin.HeightF = 200F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.StylePriority.UseFont = false;
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Dpi = 254F;
            this.ReportHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ReportHeader.HeightF = 0F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.StylePriority.UseFont = false;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Dpi = 254F;
            this.ReportFooter.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ReportFooter.HeightF = 0F;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.StylePriority.UseFont = false;
            // 
            // PageHeader
            // 
            this.PageHeader.Dpi = 254F;
            this.PageHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PageHeader.HeightF = 0F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseFont = false;
            // 
            // PageFooter
            // 
            this.PageFooter.Dpi = 254F;
            this.PageFooter.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PageFooter.HeightF = 0F;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.StylePriority.UseFont = false;
            // 
            // RptBase
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.ReportFooter,
            this.PageHeader,
            this.PageFooter});
            this.Dpi = 254F;
            this.Margins = new System.Drawing.Printing.Margins(300, 150, 200, 200);
            this.PageHeight = 2970;
            this.PageWidth = 2100;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 25F;
            this.Version = "16.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        protected DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        protected DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        protected DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        protected DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        protected DevExpress.XtraReports.UI.DetailBand Detail;
        protected DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        protected DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    }
}
