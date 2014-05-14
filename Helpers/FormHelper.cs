using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Reflection;

namespace FrbaCommerce.Helpers
{
    class FormHelper
    {
        public static void volverAPadre(Form ventanaPadre)
        {
            ventanaPadre.Visible = true;
            ventanaPadre.Activate();
            ventanaPadre.Select();
        }
        public static void mostrarNuevaVentana(Form ventanaNueva, Form ventanaPadre)
        {
            ventanaNueva.Visible = true;
            ventanaNueva.Activate();
            ventanaNueva.Select();
            ventanaPadre.Hide();
        }

        public static DataGridView cargarGrid(DataGridView grid, System.Data.DataTable dataTable)
        {
            grid.DataSource = dataTable;
            grid.AutoResizeColumns();
            grid.AutoResizeRows();

            return grid;
        }

        public static DataTable Convert<TItemType>(List<TItemType> list)
        {
            DataTable convertedData = new DataTable();

            // Get List Item Properties info
            Type itemType = typeof(TItemType);
            PropertyInfo[] publicProperties =
                // Only public non inherited properties
                itemType.GetProperties(BindingFlags.Instance | BindingFlags.Public);

            // Create Table Columns
            foreach (PropertyInfo property in publicProperties)
            {
                // DataSet does not support System.Nullable<>
                if (property.PropertyType.IsGenericType &&
                    property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    // Set the column datatype as the nullable value type
                    convertedData.Columns.Add(property.Name, property.PropertyType.GetGenericArguments()[0]);
                }
                else
                {
                    convertedData.Columns.Add(property.Name, property.PropertyType);
                }
            }

            // Convert the Data
            foreach (TItemType item in list)
            {
                object[] rowData = new object[convertedData.Columns.Count];
                int rowDataIndex = 0;
                // Iterate through Item Properties
                foreach (PropertyInfo property in publicProperties)
                {
                    // Add a single cell data
                    rowData[rowDataIndex] = property.GetValue(item, null);
                    rowDataIndex++;
                }
                convertedData.Rows.Add(rowData);
            }

            return convertedData;
        }

    }
}
