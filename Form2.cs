﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ackountermann
{
    public partial class vendorInputForm : Form
    {
        public vendorInputForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Take the data in the fields here and make an entry to the Vendors table in the database
            string cmdString = "INSERT INTO dbo.Vendors (id, name, address, city, state, zipcode, phone) VALUES (@val1, @val2, @val3, @val4, @val5, @val6, @val7)";
            string connectionString = "Data Source=DESKTOP-U5O598U\\SQLEXPRESS;Initial Catalog=PrangerDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand(cmdString, connection))
                {
                    try
                    {
                        connection.Open();
                        comm.Connection = connection;
                        comm.CommandText = cmdString;
                        comm.Parameters.AddWithValue("@val1", txtVendorID.Text);
                        comm.Parameters.AddWithValue("@val2", txtVendorName.Text);
                        comm.Parameters.AddWithValue("@val3", txtVendorAddress.Text);
                        comm.Parameters.AddWithValue("@val4", txtCity.Text);
                        comm.Parameters.AddWithValue("@val5", txtState.Text);
                        comm.Parameters.AddWithValue("@val6", txtZipcode.Text);
                        comm.Parameters.AddWithValue("@val7", txtVendorPhone.Text);

                        comm.ExecuteNonQuery();
                        connection.Close();
                    } catch (Exception error)
                    {
                        Console.WriteLine(error.ToString());
                    }
                }
            }
            this.Close();
        }
    }
}
