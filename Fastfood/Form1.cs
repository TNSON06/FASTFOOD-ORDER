using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood
{
    
    public partial class Form1 : Form
    {
        private DataTable[] dt = new DataTable[7];
        private DataTable dttam;
        int index = 0;
        public Form1()
        {
            InitializeComponent();
            ShowDGV();

        }
       

        private void ShowDGV()
        {
            // tạo đối tượng datatable theo các bán 

            for (int i = 0; i <= 6; i++)
            {
                dt[i] = new DataTable();
                dt[i].Columns.AddRange(new DataColumn[]
                {
                 new DataColumn{ DataType =typeof(string), ColumnName= "Món ăn" } ,
                 new DataColumn{ DataType =typeof(int), ColumnName= "Số lượng" } ,
                });


            }
            //tạo đối tượng datatabble tam để lưu order từng bàn
             dttam = new DataTable();
             dttam.Columns.AddRange(new DataColumn[]
            {
                 new DataColumn{ DataType =typeof(string), ColumnName= "Món ăn" } ,
                 new DataColumn{ DataType =typeof(int), ColumnName= "Số lượng" } ,
            });


        }
        private void btn_cam_Click(object sender, EventArgs e)

        {
            if (index == 0)
            {
                MessageBox.Show("Vui long chon ban truoc khi chon mon!");
            }
            else
            {

                bool kt = true;

                Button b = (Button)sender;

                DataRow newRow = dttam.NewRow();
                if (dt[index].Rows.Count > 0)
                {
                    foreach (DataRow row in dt[index].Rows)
                    {
                        DataRow Row = dttam.NewRow();

                        Row.ItemArray = row.ItemArray;
                        dttam.Rows.Add(Row);
                    }
                    dt[index].Clear();


                }
                foreach (DataRow row in dttam.Rows)
                {
                    if (row[0].ToString() == b.Text)
                    {
                        kt = false;
                        row[1] = int.Parse(row[1].ToString()) + 1;
                        newRow = row;
                        break;
                    }

                }

                //gán giá trị cho dòng mới 
                if (kt)
                {
                    newRow[0] = b.Text;
                    newRow[1] = 1;
                    dttam.Rows.Add(newRow);
                }
                dataGridView1.DataSource = dttam;
            }
          



            

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lưu lại chỉ mục của các dòng được chọn
                List<int> selectedIndexes = new List<int>();
                foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                {
                    selectedIndexes.Add(selectedRow.Index);
                }

                // Xóa các dòng được chọn
                foreach (int index in selectedIndexes)
                {
                    dataGridView1.Rows.RemoveAt(index);
                }

               
             
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = Convert.ToInt32(comboBox1.SelectedItem.ToString());

            // dttam = null;
            dttam.Clear();
            dataGridView1.DataSource = dt[index];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_xoahet_Click(object sender, EventArgs e)
        {
            if (dt[index].Rows.Count > 0 || dttam.Rows.Count > 0)
            {
                dt[index].Clear();
                dttam.Clear();
            }
            else
            {
                MessageBox.Show("Co chi de xoa mo cu!!!");
            }
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {

            foreach (DataRow row in dttam.Rows)
            {
                DataRow newRow = dt[index].NewRow();
                newRow.ItemArray = row.ItemArray;
                dt[index].Rows.Add(newRow);
            }
        }
    }
}
