// <copyright file="ExcelResult.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// <summary>The Export to Excel controller results class.</summary>
namespace ExporToExcel.Controllers.Results
{
   using System;
   using System.IO;
   using System.Linq;
   using System.Web;
   using System.Web.Mvc;
   using ExporToExcel.Controllers.ControllerExtensions;

   /// <summary>
   /// Excel result class
   /// </summary>
   public class ExcelResult : ActionResult
   {
      /// <summary>
      /// File Name. 
      /// </summary>
      private string excelFileName;

      /// <summary>
      /// Sheet Name. 
      /// </summary>
      private string excelWorkSheetName;

      /// <summary>
      /// Excel Row data.
      /// </summary>
      private IQueryable rowData;

      private System.Data.DataTable rowDataTable;

      /// <summary>
      /// Excel Header Data.
      /// </summary>
      private string[] headerData = null;

      /// <summary>
      /// Row Data Keys.
      /// </summary>
      private string[] rowPointers = null;

      /// <summary>
      /// Action Result: Excel result constructor for returning values from rows. 
      /// </summary>
      /// <param name="fileName">Excel file name.</param>
      /// <param name="workSheetName">Excel worksheet name: default: sheet1.</param>
      /// <param name="rows">Excel row values.</param>
      public ExcelResult(string fileName, string workSheetName, IQueryable rows)
         : this(fileName, workSheetName, rows, null, null)
      {
      }

      /// <summary>
      /// Action Result: Excel result constructor for returning values from rows and headers. 
      /// </summary>
      /// <param name="fileName">Excel file name.</param>
      /// <param name="workSheetName">Excel worksheet name: default: sheet1.</param>
      /// <param name="rows">Excel row values.</param>
      /// <param name="headers">Excel header values.</param>
      public ExcelResult(string fileName, string workSheetName, IQueryable rows, string[] headers)
         : this(fileName, workSheetName, rows, headers, null)
      {
      }

      /// <summary>
      /// Action Result: Excel result constructor for returning values from rows and headers and row keys. 
      /// </summary>
      /// <param name="fileName">Excel file name.</param>
      /// <param name="workSheetName">Excel worksheet name: default: sheet1.</param>
      /// <param name="rows">Excel row values.</param>
      /// <param name="headers">Excel header values.</param>
      /// <param name="rowKeys">Key values for the rows collection.</param>
      public ExcelResult(string fileName, string workSheetName, IQueryable rows, string[] headers, string[] rowKeys)
      {
         this.rowData = rows;
         this.excelFileName = fileName;
         this.excelWorkSheetName = workSheetName;
         this.headerData = headers;
         this.rowPointers = rowKeys;
      }


      public ExcelResult(string fileName, string workSheetName, System.Data.DataTable rows, string[] headers, string[] rowKeys)
      {
          this.rowDataTable = rows;
          this.excelFileName = fileName;
          this.excelWorkSheetName = workSheetName;
          this.headerData = headers;
          this.rowPointers = rowKeys;
      }

      /// <summary>
      ///  Gets a value for file name.
      /// </summary>
      public string ExcelFileName
      {
         get { return this.excelFileName; }
      }

      /// <summary>
      ///  Gets a value for file name.
      /// </summary>
      public string ExcelWorkSheetName
      {
         get { return this.excelWorkSheetName; }
      }

      /// <summary>
      /// Gets a value for rows.
      /// </summary>
      public IQueryable ExcelRowData
      {
         get { return this.rowData; }
      }

      public System.Data.DataTable ExcelRowDataTable
      {
          get { return this.rowDataTable; }
      }

      /// <summary>
      /// Execute the Excel Result. 
      /// </summary>
      /// <param name="context">Controller context.</param>
      public override void ExecuteResult(ControllerContext context)
      {
         MemoryStream stream = ExcelDocument.Create(this.excelFileName, this.excelWorkSheetName, this.rowDataTable, this.headerData, this.rowPointers);
         WriteStream(stream, this.excelFileName);
      }

      /// <summary>
      /// Writes the memory stream to the browser.
      /// </summary>
      /// <param name="memoryStream">Memory stream.</param>
      /// <param name="excelFileName">Excel file name.</param>
      private static void WriteStream(MemoryStream memoryStream, string excelFileName)
      {
         HttpContext context = HttpContext.Current;
         context.Response.Clear();
         context.Response.AddHeader("content-type", "application/vnd.ms-excel");
         //context.Response.Cache.SetCacheability(HttpCacheability.NoCache);
         context.Response.AddHeader("content-disposition", String.Format("attachment;filename={0}", excelFileName));
         memoryStream.WriteTo(context.Response.OutputStream);

         memoryStream.Close();
         context.Response.End();
      }
   }
}