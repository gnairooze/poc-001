// See https://aka.ms/new-console-template for more information

using Export;

var orders = TestData.CreateOrders();
var inventory = TestData.CreateInventoryList();

await ExportUsingFreeDataExports.Export(orders, inventory, "Export-sample.xlsx");

Console.WriteLine("Export complete. Press any key to exit.");