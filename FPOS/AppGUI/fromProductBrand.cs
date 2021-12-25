using FPOS.AppModels;
using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace FPOS.AppGUI
{
    public partial class fromProductBrand : Form
    {
        public fromProductBrand()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (AioControls.TextBoxIsNullOrWhiteSpace(this, "txtName"))
            {
                AioMsgBox.Required("Name", this.Text);
                return;
            }
            SetDataInGridView(txtName.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PRODUCT_BRANDS obj = new PRODUCT_BRANDS();
            obj.BRAND_NAME = AioControls.TxtFilter(txtName);
            obj.BRAND_ORIGIN = AioControls.TxtFilter(txtOrigin);
            obj.IS_ACTIVE = chkAct.Checked;

            try
            {
                if (ModelState.IsValid<PRODUCT_BRANDS>(obj))
                {
                    using (fposDbContext db = new fposDbContext())
                    {
                        if (btnSave.Text == "Save")
                        {
                            obj.IS_ACTIVE = true;
                            db.PRODUCT_BRANDS.Add(obj);
                        }
                        else
                        {
                            int Id = Convert.ToInt32(txtId.Text);
                            PRODUCT_BRANDS obj_udt = db.PRODUCT_BRANDS.Where(x => x.ID == Id).FirstOrDefault();
                            if (obj_udt == null)
                            {
                                AioMsgBox.Failed("Record not found", this.Text);
                                return;
                            }
                            obj_udt.BRAND_NAME = obj.BRAND_NAME;
                            obj_udt.BRAND_ORIGIN = obj.BRAND_ORIGIN;
                            obj_udt.IS_ACTIVE = obj.IS_ACTIVE;
                            obj_udt.UPDATE_USER = obj.UPDATE_USER;
                            obj_udt.UPDATE_DATE = obj.UPDATE_DATE;
                            obj_udt.UPDATE_DEVICE = obj.UPDATE_DEVICE;
                            db.Entry(obj_udt).State = EntityState.Modified;
                        }
                        db.SaveChanges();
                    }
                    txtId.Text = obj.ID.ToString();
                    SetDataInGridView(obj.BRAND_NAME);
                    AioControls.ClearControls(this, "txtName,txtOrigin");
                    AioMsgBox.Success(this.Text);
                }
                else
                {
                    foreach (string err in ModelState.ErrorMessages)
                    {
                        AioMsgBox.Failed(err, this.Text);
                    }
                }
            }
            catch (Exception x)
            {
                if (x.GetBaseException().GetType() == typeof(SqlException))
                {
                    AioMsgBox.Failed("Cannot insert duplicate Name.", this.Text);
                }
                else
                {
                    AioMsgBox.Failed(x.Message, this.Text);
                }
            }
        }
        public void SetDataInGridView(string brandName)
        {
            btnSave.Text = "Save";
            dgvDetails.AutoGenerateColumns = false;
            using (fposDbContext db = new fposDbContext())
            {
                dgvDetails.DataSource = db.PRODUCT_BRANDS.Where(w => w.BRAND_NAME.ToLower().Contains(brandName)).OrderBy(x => x.BRAND_NAME).ToList();
            }
        }

        private void dgvDetails_DoubleClick(object sender, EventArgs e)
        {
            {
                //DataGridView.SelectedRows[0].Cells[0].Value
                int Id = Convert.ToInt32(dgvDetails.CurrentRow.Cells[0].Value);
                using (fposDbContext db = new fposDbContext())
                {
                    PRODUCT_BRANDS obj = db.PRODUCT_BRANDS.Where(x => x.ID == Id).FirstOrDefault();
                    txtId.Text = obj.ID.ToString();
                    txtName.Text = obj.BRAND_NAME;
                    txtOrigin.Text = obj.BRAND_ORIGIN;
                    if (obj.IS_ACTIVE)
                    {
                        chkAct.Checked = true;
                    }
                    else
                    {
                        chkAct.Checked = false;
                    }
                }
            }
            btnSave.Text = "Update";
            //btnDelete.Enabled = true;
        }


    }

}
