//------------------------------------------------------------------------------
// <copyright file="ExcelControllerExtensions.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// <summary>The Export to Excel controller extension class.</summary>
namespace ExporToExcelSample.Controllers.Extensions
{
   using System.Linq;
   using System.Web.Mvc;
   using ExporToExcel.Controllers.Results;

   /// <summary>
   /// Excel controller extensions class.
   /// </summary>
   public static class ExcelControllerExtensions
   {
      /// <summary>
      /// Controller Extension: Returns an Excel result constructor for returning values from rows. 
      /// </summary>
      /// <param name="controller">This controller.</param>
      /// <param name="fileName">Excel file name.</param>
      /// <param name="excelWorkSheetName">Excel worksheet name: default: sheet1.</param>
      /// <param name="rows">Excel row values.</param>
      /// <returns>Action result.</returns>
      public static ActionResult Excel(this Controller controller, string fileName, string excelWorkSheetName, IQueryable rows)
      {
         return new ExcelResult(fileName, excelWorkSheetName, rows);
      }

      /// <summary>
      ///  Controller Extension: Excel result constructor for returning values from rows and headers. 
      /// </summary>
      /// <param name="controller">This controller.</param>
      /// <param name="fileName">Excel file name.</param>
      /// <param name="excelWorkSheetName">Excel worksheet name: default: sheet1.</param>
      /// <param name="rows">Excel row values.</param>
      /// <param name="headers">Excel header values.</param>
      /// <returns>Action result.</returns>
      public static ActionResult Excel(this Controller controller, string fileName, string excelWorkSheetName, IQueryable rows, string[] headers)
      {
         return new ExcelResult(fileName, excelWorkSheetName, rows, headers);
      }

      /// <summary>
      ///  Controller Extension: Excel result constructor for returning values from rows and headers and row keys. 
      /// </summary>
      /// <param name="controller">This controller.</param>
      /// <param name="fileName">Excel file name.</param>
      /// <param name="excelWorkSheetName">Excel worksheet name: default: sheet1.</param>
      /// <param name="rows">Excel row values.</param>
      /// <param name="headers">Excel header values.</param>
      /// <param name="rowKeys">Key values for the rows collection.</param>
      /// <returns>Action result.</returns>
      public static ActionResult Excel(this Controller controller, string fileName, string excelWorkSheetName, IQueryable rows, string[] headers, string[] rowKeys)
      {
         return new ExcelResult(fileName, excelWorkSheetName, rows, headers, rowKeys);
      }

      public static ActionResult Excel(this Controller controller, string fileName, string excelWorkSheetName, System.Data.DataTable rows, string[] headers, string[] rowKeys)
      {
          return new ExcelResult(fileName, excelWorkSheetName, rows, headers, rowKeys);
      }
   }
}