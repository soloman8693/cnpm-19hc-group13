using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using BrightIdeasSoftware;

namespace Demo.Menu_UI
{
    public partial class frmAddMenu : Form
    {
        MENU menu;
        Menu.frmMenu frmMenu;
        Boolean addFlag = false;
        List<FOOD> demos = new List<FOOD>();
        List<FOOD> foodResources = BUSMenu.Instance.FoodMenu();
        public frmAddMenu()
        {
            
        }

        public frmAddMenu(Boolean addFlag, MENU menu, Menu.frmMenu frmMenu)
        {
            this.addFlag = addFlag;
            this.menu = menu;
            this.frmMenu = frmMenu;
            InitializeComponent(addFlag);
            createControlPart();
            if (!addFlag)
            {
                txtTen.Text = menu.NAME;
                rctMieuTa.Text = menu.MENU_DESCRIPTION;
                txtSoLuong.Text = menu.CAPACITY.ToString();
                txtGia.Text = menu.PRICE.ToString();
                if (menu.MENU_STATUS.Value)
                {
                    rbtSanSang.Checked = true;
                }
                else
                {
                    rdtKhongSanSang.Checked = true;
                }
                
            }
        }

        private Boolean Insert_Menu(List<FOOD> food)
        {
            MENU menu = new MENU();
            menu.NAME = txtTen.Text;
            menu.MENU_DESCRIPTION = rctMieuTa.Text;
            menu.PRICE = Double.Parse(txtGia.Text);
            menu.MENU_STATUS = rbtSanSang.Checked ? true : false;
            menu.CAPACITY = Int32.Parse(txtSoLuong.Text);
            return BUSMenu.Instance.Insert_Menu(menu, food);
        }

        private void frmAddMenu_Load(object sender, EventArgs e)
        {
            FOOD fOOD_ = new FOOD();
            fOOD_.FOOD_NAME = "";
            demos.Add(fOOD_);
            if (!addFlag)
            {
                demos = BUSMenu.Instance.Get_Food(menu.ID);
                demos.Add(fOOD_);
            }
            objectListViewMonAn.SetObjects(demos);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String infor = "Failed !!";
            if (Insert_Menu(demos))
            {
                infor = "Successfully Inserted";
            }
            MessageBox.Show(infor, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void createControlPart()
        {
            objectListViewMonAn.SmallImageList = imageListMenu;
            objectListViewMonAn.ShowImagesOnSubItems = true;
            olvCommand.IsEditable = true;
            olvName.IsEditable = true;
            //clCommand.AspectGetter = delegate
            //{
            //    return "Delete";
            //};
            olvCommand.ImageGetter = delegate (object x)
            {
                if (((FOOD)x).FOOD_NAME == String.Empty) return 1;
                return 0;
            };
            olvCommand.AspectToStringConverter = delegate
            {
                return String.Empty;
            };
            objectListViewMonAn.CellEditActivation = ObjectListView.CellEditActivateMode.SingleClick;
            objectListViewMonAn.CellEditStarting += ObjectListViewOnCellEditStarting;
            objectListViewMonAn.CellEditFinishing += ObjectListViewOnCellEditFinishing;
        }

        private void ObjectListViewOnCellEditStarting(object sender, CellEditEventArgs e)
        {
            if (e.Column == olvCommand)
            {
                e.Cancel = true;
                if (((FOOD)e.RowObject).FOOD_NAME == String.Empty)
                {
                    FOOD fOOD_ = new FOOD();
                    fOOD_.FOOD_NAME = "Chọn Tên Món";
                    demos.Insert(demos.Count - 1, fOOD_);
                    objectListViewMonAn.SetObjects(demos);
                }
                else
                {
                    objectListViewMonAn.RemoveObject(e.RowObject);
                    demos.Remove((FOOD)e.RowObject);
                }
            }
            else if (e.Column == olvName)
            {
                if (((FOOD)e.RowObject).FOOD_NAME == String.Empty)
                {
                    e.Cancel = true;
                }
                else
                {
                    Food_Name(sender, e);
                }
            }
        }
        private void Food_Name(object sender, CellEditEventArgs e)
        {
            ComboBox cmbName = new ComboBox();
            cmbName.DataSource = null;
            cmbName.DataSource = foodResources;
            cmbName.ValueMember = "FOOD_NAME";
            cmbName.Bounds = e.CellBounds;
            if (!e.Control.Text.Equals("Chọn Tên Món"))
            {
                foreach (FOOD com in foodResources)
                {
                    if (com.FOOD_NAME.Equals(e.Control.Text))
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
            if (e.Column == olvName)
            {
                if (((FOOD)e.RowObject).FOOD_NAME == String.Empty)
                {
                    e.Cancel = true;
                }
                else
                {
                    if (!e.Control.Text.Equals("Chọn Tên Món"))
                    {
                        foreach (FOOD com in foodResources)
                        {
                            if (com.FOOD_NAME.Equals(e.Control.Text))
                            {
                                ((FOOD)e.RowObject).ID = com.ID;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenu.reload();
        }
    }
}
