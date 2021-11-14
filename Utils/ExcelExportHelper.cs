using QuanLyMu.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyMu.Utils
{
    class ExcelExportHelper
    {
        private static int TITLE_ROW = 1;
        private static int NAME_ROW = 3;
        private static int HEADER_ROW = 4;
        private static int COL_NUM = 9;
        public static void ExportThongKeThang(List<ThongKeChuVuonTheoThang> listData)
        {
            Cursor.Current = Cursors.WaitCursor;
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWorkBook = excelApp.Workbooks.Add();

            foreach (var thongKe in listData)
            {
                Excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
                excelWorkSheet.Name = thongKe.ChuVuon.Ten;
                excelWorkSheet.Cells[TITLE_ROW, 1] = 
                    "HÓA ĐƠN THU MUA MỦ THÁNG " + thongKe.ThoiGian.ToString("MM/yyyy");
                Excel.Range rangeTitle = excelWorkSheet.Range[
                        excelWorkSheet.Cells[TITLE_ROW, 1],
                        excelWorkSheet.Cells[TITLE_ROW, COL_NUM]
                    ];
                rangeTitle.Merge();
                rangeTitle.Font.Size = 14;
                rangeTitle.Font.Bold = true;
                rangeTitle.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                Excel.Range rangeName = excelWorkSheet.Range[
                        excelWorkSheet.Cells[NAME_ROW, 1],
                        excelWorkSheet.Cells[NAME_ROW, COL_NUM]
                    ];
                rangeName.Merge();
                excelWorkSheet.Cells[NAME_ROW, 1] = thongKe.ChuVuon.Ten;

                Excel.Range rangeHeader = excelWorkSheet.Range[
                        excelWorkSheet.Cells[HEADER_ROW, 1],
                        excelWorkSheet.Cells[HEADER_ROW, COL_NUM]
                    ];
                rangeHeader.Font.Size = 12;
                rangeHeader.Font.Bold = true;
                rangeHeader.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                Excel.Range bodyRange = excelWorkSheet.Range[
                        excelWorkSheet.Cells[HEADER_ROW + 1, 1],
                        excelWorkSheet.Cells[HEADER_ROW + thongKe.Data.Count, COL_NUM]
                    ];
                bodyRange.Font.Size = 12;
                bodyRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                excelWorkSheet.Cells[HEADER_ROW, 1] = "Ngày";
                excelWorkSheet.Cells[HEADER_ROW, 2] = "Mủ nước";
                excelWorkSheet.Cells[HEADER_ROW, 3] = "Độ";
                excelWorkSheet.Cells[HEADER_ROW, 4] = "Đơn giá";
                excelWorkSheet.Cells[HEADER_ROW, 5] = "Thành tiền";
                excelWorkSheet.Cells[HEADER_ROW, 6] = "Mủ chén";
                excelWorkSheet.Cells[HEADER_ROW, 7] = "Đơn giá";
                excelWorkSheet.Cells[HEADER_ROW, 8] = "Thành tiền";
                excelWorkSheet.Cells[HEADER_ROW, 9] = "Tổng tiền";

                for (int i = 1; i <= thongKe.Data.Count; i++)
                {
                    excelWorkSheet.Cells[i + HEADER_ROW, 1] = thongKe.Data[i - 1].Ngay;
                    excelWorkSheet.Cells[i + HEADER_ROW, 2] = thongKe.Data[i - 1].SLMuNuoc;
                    excelWorkSheet.Cells[i + HEADER_ROW, 3] = thongKe.Data[i - 1].HLMuNuoc;
                    excelWorkSheet.Cells[i + HEADER_ROW, 4] = thongKe.Data[i - 1].DGMuNuoc;
                    excelWorkSheet.Cells[i + HEADER_ROW, 5] = thongKe.Data[i - 1].TienMuNuoc;
                    excelWorkSheet.Cells[i + HEADER_ROW, 6] = thongKe.Data[i - 1].SLMuChen;
                    excelWorkSheet.Cells[i + HEADER_ROW, 7] = thongKe.Data[i - 1].DGMuChen;
                    excelWorkSheet.Cells[i + HEADER_ROW, 8] = thongKe.Data[i - 1].TienMuChen;
                    excelWorkSheet.Cells[i + HEADER_ROW, 9] = thongKe.Data[i - 1].TongTien;
                }
                excelWorkSheet.Cells[thongKe.Data.Count + HEADER_ROW + 1, COL_NUM - 1] = "Tổng";
                excelWorkSheet.Cells[thongKe.Data.Count + HEADER_ROW + 1, COL_NUM] = thongKe.Tong;

                excelWorkSheet.Columns.AutoFit();
            }

            excelWorkBook.SaveAs(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm"));
            excelWorkBook.Close();
            excelApp.Quit();
            Cursor.Current = Cursors.Default;
        }
    }
}
