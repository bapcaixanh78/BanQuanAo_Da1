using DAL.Model;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using PRL.VIewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{
    public partial class Bill_Forms : Form
    {
        public List<Cart> _lstcartinbill;
        public Nhanvien _nhanvien = new Nhanvien();
        public string _Tenkhachhang;
        public string _SDTKhachhang;
        public decimal _Tienphaithanhtoan;
        public decimal _TienDagiam;
        public decimal _Tienkhachtra;
        public decimal _Tientralai;

        public Bill_Forms()
        {
            InitializeComponent();
            _lstcartinbill = Vending3._Lstgiohang;
            LoadDTGCart(_lstcartinbill);
            _Tenkhachhang = Vending3.TenKhachhang;
        }

        public void LoadDTGCart(List<Cart> lstcart)
        {
            int stt = 1;
            dtg_Bill.ColumnCount = 8;
            dtg_Bill.Columns[0].Name = "STT";
            dtg_Bill.Columns[1].Name = "ID";
            dtg_Bill.Columns[1].Visible = false;
            dtg_Bill.Columns[2].Name = "Tên sản phẩm";
            dtg_Bill.Columns[3].Name = "Số lượng mua";
            dtg_Bill.Columns[4].Name = "Màu sắc";
            dtg_Bill.Columns[5].Name = "Chất liệu";
            dtg_Bill.Columns[6].Name = "Size";
            dtg_Bill.Columns[7].Name = "Giá";
            dtg_Bill.Rows.Clear();
            dtg_Bill.AllowUserToAddRows = false;
            foreach (var sp in lstcart)
            {
                dtg_Bill.Rows.Add(stt++, sp.Id, sp.TenSp, sp.Soluongmua, sp.Mausac, sp.Chatlieu, sp.Size, sp.GiaTongSanPhamMua);
            }
        }

        private void btn_Out_Click(object sender, EventArgs e)
        {
            var tmp = MessageBox.Show("Are you sure close this form?", "Inform", MessageBoxButtons.YesNo);
            if (tmp == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void Bill_Forms_Load(object sender, EventArgs e)
        {
            _lstcartinbill = Vending3._Lstgiohang;
            _nhanvien = Main.account;
            lb_TienKhachTra.Text = Vending3.Tienkhachtra.ToString();
            lb_TienThua.Text = Vending3.Tientralai.ToString();
            lb_TongTienGiam.Text = Vending3.Tongtiendagiam.ToString();
            lb_TongTienPhaiTra.Text = Vending3.Tongtienphaithanhtoan.ToString();
            lb_NgayBan.Text = DateTime.Now.ToString();
            lb_NguoiBan.Text = _nhanvien.Ten.ToString();
            lb_nguoimua.Text = _Tenkhachhang;
        }

        private void ExportToPdf(string filename)
        {
            // Register the font resolver
            GlobalFontSettings.FontResolver = new FontResolver();

            // Create a new PDF document
            PdfDocument document = new PdfDocument();

            try
            {
                // Create a new PDF page
                PdfPage page = document.AddPage();

                // Set the page dimensions
                double pageWidth = XUnit.FromInch(8.5); // Adjust the width as desired
                double pageHeight = XUnit.FromInch(11); // Adjust the height as desired
                page.Width = pageWidth;
                page.Height = pageHeight;

                // Create a graphics object for the page
                XGraphics gfx = XGraphics.FromPdfPage(page);

                // Set the font and size for the text
                XFont font = new XFont("Arial", 12); // Use the desired font name here

                XFont titleFont = new XFont("Arial", 20);

                // Calculate the content size
                double contentWidth = 300; // Adjust the width based on your content
                double contentHeight = dtg_Bill.Rows.Count * 20 + 40; // Adjust the height based on your content

                // Calculate the starting position for the content
                double startPositionX = 50; // Adjust the X position as desired
                double startPositionY = 40; // Center the content vertically

                // Calculate the X position for the "Shirt Haven" line
                double linePositionX = (pageWidth - gfx.MeasureString("Hóa đơn bán hàng", titleFont).Width) / 2;
                double linePositionY = startPositionY - 20; // Adjust the Y position above the "Hóa đơn bán hàng" line
                double brandPositionX = (pageWidth - gfx.MeasureString("Shirt Haven", titleFont).Width) / 2;

                // Add the "Shirt Haven" line
                XPoint shirtHavenPosition = new XPoint(brandPositionX, linePositionY);
                gfx.DrawString("Shirt Haven", titleFont, XBrushes.Black, shirtHavenPosition);

                linePositionY += 40; // Increase the Y position for the gap

                // Add the "Hóa đơn bán hàng" line
                XPoint linePosition = new XPoint(linePositionX, linePositionY);
                gfx.DrawString("Hóa đơn bán hàng", titleFont, XBrushes.Black, linePosition);

                linePositionY += 40; // Increase the Y position for the gap

                // Add a line for "Ngày bán" with the current date and time
                XPoint datePosition = new XPoint(startPositionX, linePositionY);
                string ngayBan = "Ngày bán: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                gfx.DrawString(ngayBan, font, XBrushes.Black, datePosition);

                linePositionY += 20; // Increase the Y position for the gap

                // Add a line for "Người bán"
                XPoint nguoiBanPosition = new XPoint(startPositionX, linePositionY);
                string nguoiBan = "Người bán: " + lb_NguoiBan.Text;
                gfx.DrawString(nguoiBan, font, XBrushes.Black, nguoiBanPosition);

                linePositionY += 20; // Move to the next line

                // Add a line for "Tên khách hàng"
                XPoint tenKhachHangPosition = new XPoint(startPositionX, linePositionY);
                string tenKhachHang = "Tên khách hàng: " + lb_nguoimua.Text;
                gfx.DrawString(tenKhachHang, font, XBrushes.Black, tenKhachHangPosition);

                linePositionY += 40; // Increase the Y position for the gap

                // Calculate the Y position for the column headers
                double headerPositionY = linePositionY; // Use the updated linePositionY value

                // Export the column headers (Tên, Số lượng mua, Giá)
                XPoint position = new XPoint(startPositionX, headerPositionY);
                gfx.DrawString("Tên", font, XBrushes.Black, position);
                position.X += 100; // Adjust the X position based on the column width
                gfx.DrawString("Số lượng mua", font, XBrushes.Black, position);
                position.X += 100; // Adjust the X position based on the column width
                gfx.DrawString("Giá", font, XBrushes.Black, position);

                position.Y += 20; // Move to the next row

                // Export the data rows (Tên, Số lượng mua, Giá)
                for (int rowIndex = 0; rowIndex < dtg_Bill.Rows.Count; rowIndex++)
                {
                    position.X = startPositionX; // Reset the X position for each row

                    string name = dtg_Bill.Rows[rowIndex].Cells[2].Value.ToString();
                    gfx.DrawString(name, font, XBrushes.Black, position);
                    position.X += 100; // Adjust the X position based on the column width

                    string quantity = dtg_Bill.Rows[rowIndex].Cells[3].Value.ToString();
                    gfx.DrawString(quantity, font, XBrushes.Black, position);
                    position.X += 100; // Adjust the X position based on the column width

                    string price = dtg_Bill.Rows[rowIndex].Cells[7].Value.ToString();
                    gfx.DrawString(price, font, XBrushes.Black, position);

                    position.Y += 20; // Move to the next row
                }

                // Add space between the data rows and the lines
                position.Y += 40;

                // Add a line for "Tổng tiền phải thanh toán"
                XPoint tongTienPosition = new XPoint(startPositionX, position.Y);
                string tongTien = "Tổng tiền phải thanh toán: "+ lb_TongTienPhaiTra.Text;
                gfx.DrawString(tongTien, font, XBrushes.Black, tongTienPosition);

                position.Y += 20; // Move to the next line

                // Add a line for "Tổng tiền đã giảm"
                XPoint tongTienGiamPosition = new XPoint(startPositionX, position.Y);
                string tongTienGiam = "Tổng tiền đã giảm: "+ lb_TongTienGiam.Text;
                gfx.DrawString(tongTienGiam, font, XBrushes.Black, tongTienGiamPosition);

                position.Y += 20; // Move to the next line

                // Add a line for "Tiền khách phải trả"
                XPoint tienPhaiTraPosition = new XPoint(startPositionX, position.Y);
                string tienPhaiTra = "Tiền khách phải trả: " +lb_TienKhachTra.Text;
                gfx.DrawString(tienPhaiTra, font, XBrushes.Black, tienPhaiTraPosition);

                position.Y += 20; // Move to the next line

                // Add a line for "Tiền trả lại"
                XPoint tienTraLaiPosition = new XPoint(startPositionX, position.Y);
                string tienTraLai = "Tiền trả lại: "+ lb_TienThua.Text;
                gfx.DrawString(tienTraLai, font, XBrushes.Black, tienTraLaiPosition);

                // Calculate the X position for the "Cảm ơn quý khách và hẹn gặp lại" line
                double thankYouPositionX = (pageWidth - gfx.MeasureString("Cảm ơn quý khách và hẹn gặp lại", titleFont).Width) / 2;
                double thankYouPositionY = pageHeight - 60; // Adjust the Y position to leave some space at the bottom

                // Add the "Cảm ơn quý khách và hẹn gặp lại" line
                XPoint thankYouPosition = new XPoint(thankYouPositionX, thankYouPositionY);
                gfx.DrawString("Cảm ơn quý khách và hẹn gặp lại", titleFont, XBrushes.Black, thankYouPosition);

                // Calculate the X position for the "Hotline: 123456789" line
                double hotlinePositionX = (pageWidth - gfx.MeasureString("Hotline: 123456789", titleFont).Width) / 2;
                double hotlinePositionY = pageHeight - 40; // Adjust the Y position to leave some space below the previous line

                // Add the "Hotline: 123456789" line
                XPoint hotlinePosition = new XPoint(hotlinePositionX, hotlinePositionY);
                gfx.DrawString("Hotline: 123456789", titleFont, XBrushes.Black, hotlinePosition);

                // Save the document to the specified filename
                document.Save(filename);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                MessageBox.Show("Error exporting to PDF: " + ex.Message);
            }
            finally
            {
                // Close the PDF document
                document.Close();
            }
        }

        private class FontResolver : IFontResolver
        {
            public byte[] GetFont(string faceName)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    string fontFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), faceName + ".ttf");

                    if (File.Exists(fontFilePath))
                    {
                        using (FileStream fontFileStream = File.OpenRead(fontFilePath))
                        {
                            fontFileStream.CopyTo(stream);
                        }
                        return stream.ToArray();
                    }

                    return null;
                }
            }

            public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
            {
                // Map the font family and style to the actual font file
                string fontName = familyName.ToLower();
                if (isBold && isItalic)
                {
                    fontName += "-bolditalic";
                }
                else if (isBold)
                {
                    fontName += "-bold";
                }
                else if (isItalic)
                {
                    fontName += "-italic";
                }

                // Return the font information
                return new FontResolverInfo(fontName);
            }
        }

        private void btn_XuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Export to PDF";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                ExportToPdf(saveFileDialog.FileName);
                MessageBox.Show("Exported to PDF successfully!");
            }
        }
    }
}