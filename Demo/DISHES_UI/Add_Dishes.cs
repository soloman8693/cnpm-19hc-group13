using BrightIdeasSoftware;
using BUS;
using DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.DISHES_UI
{
    public partial class wfAddDishes : Form
    {
        Dishes dishes;
        List<FOOD_RESOURCE> demos = new List<FOOD_RESOURCE>();
        List<FOOD_RESOURCE> foodResources = BUSDishes.Instance.FoodResource();
        public wfAddDishes()
        {
            
        }

        public wfAddDishes(Dishes dishes)
        {
            this.dishes = dishes;
            InitializeComponent();
            createControlPart();
        }
        private class demo
        {
            String name;

            public demo(string name)
            {
                this.name = name;
            }

            public string Name { get => name; set => name = value; }
        }
        private void Add_Dishes_Load(object sender, EventArgs e)
        {
            FOOD_RESOURCE fOOD_ = new FOOD_RESOURCE();
            fOOD_.RESOURCE_NAME = "";
            demos.Add(fOOD_);
            objectListView1.SetObjects(demos);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void createControlPart()
        {
            objectListView1.SmallImageList = imageListDelete;
            objectListView1.ShowImagesOnSubItems = true;
            clCommand.IsEditable = true;
            clName.IsEditable = true;
            //clCommand.AspectGetter = delegate
            //{
            //    return "Delete";
            //};
            clCommand.ImageGetter = delegate (object x)
            {
                if (((FOOD_RESOURCE)x).RESOURCE_NAME == String.Empty) return 1;
                return 0;
            };
            clCommand.AspectToStringConverter = delegate
            {
                return String.Empty;
            };
            objectListView1.CellEditActivation = ObjectListView.CellEditActivateMode.SingleClick;
            objectListView1.CellEditStarting += ObjectListViewOnCellEditStarting;
            objectListView1.CellEditFinishing += ObjectListViewOnCellEditFinishing;
        }
        private void ObjectListViewOnCellEditStarting(object sender, CellEditEventArgs e)
        {
            if (e.Column == clCommand)
            {
                e.Cancel = true;
                if (((FOOD_RESOURCE)e.RowObject).RESOURCE_NAME == String.Empty)
                {
                    FOOD_RESOURCE fOOD_ = new FOOD_RESOURCE();
                    fOOD_.RESOURCE_NAME = "Chọn Tên Món";
                    demos.Insert(demos.Count - 1, fOOD_);
                    objectListView1.SetObjects(demos);
                }
                else
                {
                    objectListView1.RemoveObject(e.RowObject);
                    demos.Remove((FOOD_RESOURCE)e.RowObject);
                }
            }
            else if (e.Column == clName)
            {
                if (((FOOD_RESOURCE)e.RowObject).RESOURCE_NAME == String.Empty)
                {
                    e.Cancel = true;
                } else
                {
                    Food_Name(sender, e);
                }
            }
        }

        private Boolean Insert_Food(List<FOOD_RESOURCE> fOODs)
        {
            FOOD food = new FOOD();
            food.FOOD_NAME = txtTenMon.Text;
            food.FOOD_DESCRIPTION = rctMieuTa.Text;
            food.PRICE = Double.Parse(txtGia.Text);
            food.AVAIABLE = radioButtonAvaiable.Checked ? true : false;
            return BUSDishes.Instance.Insert_Food(food, fOODs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String infor = "Failed !!";
            if(Insert_Food(demos))
            {
                infor = "Successfully Inserted";
            }
                MessageBox.Show(infor, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            dishes.reload();
        }

        private void Food_Name(object sender, CellEditEventArgs e)
        {
            ComboBox cmbName = new ComboBox();
            cmbName.DataSource = null;
            cmbName.DataSource = foodResources;
            cmbName.ValueMember = "RESOURCE_NAME";
            cmbName.Bounds = e.CellBounds;
            if (!e.Control.Text.Equals("Chọn Tên Món"))
            {
                foreach(FOOD_RESOURCE com in foodResources)
                {
                    if (com.RESOURCE_NAME.Equals(e.Control.Text))
                    {
                        cmbName.SelectedItem = com;
                        break;
                    }
                }
            }
            cmbName.Font = ((ObjectListView)sender).Font;
            cmbName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbName.SelectedValue = e.Value;
            e.Control = cmbName;
        }

        private void ObjectListViewOnCellEditFinishing(object sender, CellEditEventArgs e)
        {
            if (e.Column == clName)
            {
                if (((FOOD_RESOURCE)e.RowObject).RESOURCE_NAME == String.Empty)
                {
                    e.Cancel = true;
                }
                else
                {
                    if (!e.Control.Text.Equals("Chọn Tên Món"))
                    {
                        foreach (FOOD_RESOURCE com in foodResources)
                        {
                            if (com.RESOURCE_NAME.Equals(e.Control.Text))
                            {
                                ((FOOD_RESOURCE)e.RowObject).ID = com.ID;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
