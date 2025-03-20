using FreeDataExports;
using System.IO;

namespace Export
{
    internal class ExportUsingFreeDataExports
    {
        public static async Task Export(List<Order> ordersInput, List<Inventory> inventoryInput, string path)
        {
            // Create a new workbook
            var workbook = new DataExport().CreateXLSX2019();

            // Optional - Add some metadata
            workbook.CreatedBy = "Jane Doe";

            // Optional - Change the font size
            workbook.FontSize = 11;

            // Create worksheets
            var orders = workbook.AddWorksheet("Orders");
            var inventory = workbook.AddWorksheet("Inventory");

            // Add column titles
            orders.AddRow()
                .AddCell("OrderId", DataType.String)
                .AddCell("Item", DataType.String)
                .AddCell("Units", DataType.String)
                .AddCell("Price", DataType.String)
                .AddCell("OrderDate", DataType.String)
                .AddCell("SalesAssoc", DataType.String)
                .AddCell("Delivered", DataType.String);

            // Add data
            foreach (var o in ordersInput)
            {
                orders.AddRow()
                    .AddCell(o.OrderId, DataType.Number)
                    .AddCell(o.Item, DataType.String)
                    .AddCell(o.Units, DataType.Number)
                    .AddCell(o.Price, DataType.Currency)
                    .AddCell(o.OrderDate, DataType.LongDate)
                    .AddCell(o.SalesAssociate, DataType.String)
                    .AddCell(o.Delivered, DataType.Boolean);
            }

            // Add column titles
            inventory.AddRow()
                .AddCell("ItemId", DataType.String)
                .AddCell("Item", DataType.String)
                .AddCell("Number", DataType.String)
                .AddCell("Price", DataType.String);

            // Add data
            foreach (var i in inventoryInput)
            {
                inventory.AddRow()
                    .AddCell(i.ItemId, DataType.Number)
                    .AddCell(i.Item, DataType.String)
                    .AddCell(i.Number, DataType.Number)
                    .AddCell(i.Price, DataType.Currency);
            }

            // Optional - Add a tab color in RGB
            orders.TabColor = "0000FF00"; // Green
            inventory.TabColor = "000000FF"; // Blue

            // Optional - Add column widths, based on character widths
            orders.ColumnWidths("10", "10", "5", "10", "28.5", "15", "10");
            inventory.ColumnWidths("10", "10", "10", "10");

            // Optional - Reformat a data type
            workbook.Format(DataType.DateTime24, @"m/d/yy\ h:mm;@");

            // Optional - Add a worksheet to display data type conversion errors, only if they occur
            workbook.AddErrorsWorksheet();

            // Optional - Get the error manually
            workbook.GetErrors();

            // Synchronous GetBytes method
            workbook.GetBytes();

            // Asynchronous GetBytes method
            await workbook.GetBytesAsync();

            // Synchronous save method
            workbook.Save(path);

            // Asynchronous save method
            await workbook.SaveAsync(path);

        }
    }
}
