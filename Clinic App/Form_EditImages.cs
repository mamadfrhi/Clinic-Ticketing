using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.IO;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Threading;

namespace Clinic_App
{
    public partial class Form_EditImages : MetroFramework.Forms.MetroForm
    {
        int input = 0;
        public Form_EditImages(int Main_input )
        {
            InitializeComponent();
            input = Main_input;
        }

        private static int Pb_CurrentImg_Index = -1;
        public static List<Image> list_img = new List<Image>();

        // input && Main_input --> 1  For Retrive Picture From TransClass
        Model.DB_ClinicEntities DB_Obj = new Model.DB_ClinicEntities();
        private void Form_EditImages_Load(object sender, EventArgs e)
        {
            Form_Showing();
            Checkbox1_OnChange(null, null);

            if (list_img.Count != 0)
            {
                form_showing_for_0list_flag = false;

                if (input == 1)  //Retrive Picture From TransClass
                {
                    //input = '\0';

                    Btn_SaveFromSql.Visible = false;
                    linkLabel1.Visible = true;

                    pictureBox1.Image = list_img[0];
                    Pb_CurrentImg_Index = 0;
                    Lbl_PicCount.Text = list_img.Count.ToString();

                    Btn_DelRecord.Visible = true;

                    //Lbl_ImgNum.Text = "1 / 1";
                    IncLbl(true, 'f');
                }
                if (input == 2) //Retrive Picture From Sql
                {
                    //input = '\0';

                    Btn_SaveFromSql.Visible = true;
                    linkLabel1.Visible = false;

                    pictureBox1.Image = list_img[0];
                    Pb_CurrentImg_Index = 0;
                    Lbl_PicCount.Text = list_img.Count.ToString();

                    Btn_DelRecord.Visible = true;
                    
                    IncLbl(true, 'f');

                }

            }
            else
            {
                form_showing_for_0list_flag = true;
                Btn_SaveFromSql.Visible = false;
                Btn_DelRecord.Visible = false;
                pictureBox1.Visible = false;
                Pb_NotFound.Visible = true;
                Lbl_NotFound.Visible = true;
                linkLabel1.Visible = false;
                LeftNum_Int = 0;
                RightNum_Int = 0;
                
            }

            //For Null Name

            if (Trans_Class.NameAndFam != null)
            {
                Txt_Name2.Text = Trans_Class.NameAndFam;
                Txt_Name2.ForeColor = Color.Black;
            }
            else
            {
                Txt_Name2.Text = "هنوز نامی وارد نشده است.";
                Txt_Name2.ForeColor = Color.DarkGray;
            }
            //Txt_Name2.SelectedText = "";

        }
        bool form_showing_for_0list_flag = false;
        private void Btn_AddImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Choose Image";
            openFileDialog1.Title = "تصویر را انتخاب کنید";
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF; *.PNG;*.JPEG)|*.BMP;*.JPG;*.GIF; *.PNG;*.JPEG";

            if (input == 1)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK /*&& CountOfSelectedImages_Ofsh < 10*/)
                {
                    for (int z = 0; z < openFileDialog1.FileNames.Length; z++)
                    {
                        Image img = Image.FromFile(openFileDialog1.FileNames[z]);
                        list_img.Add(img);
                        IncLbl(true, '\0');
                    }

                    Lbl_PicCount.Text = list_img.Count.ToString();
                    Lbl_NotFound.Visible = false;
                    Pb_NotFound.Visible = false;
                }
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK /*&& CountOfSelectedImages_Ofsh < 10*/)
                {
                    DialogResult DS = MetroMessageBox.Show(this, "آیا برای اضافه شدن عکس اطمینان دارید ؟", "Add New Image ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (/*Form_EditImages.list_img.Count > 0 &&*/ DS == DialogResult.Yes && openFileDialog1.FileNames.Count() > 0)
                    {
                        
                        try
                        {
                            Btn_SaveFromSql.Visible = true;
                            Btn_DelRecord.Visible = true;

                            for (int z = 0; z < openFileDialog1.FileNames.Length; z++)
                            {
                                Image img = Image.FromFile(openFileDialog1.FileNames[z]);
                                list_img.Add(img);
                            }

                            IncLbl(true, 'e');

                            MemoryStream ms = new MemoryStream();
                            for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                            {
                                //Image a = Image.FromFile(openFileDialog1.FileNames[i]);
                                ImageConverter imgCon = new ImageConverter();
                                var dadadadada = (byte[])imgCon.ConvertTo(Image.FromFile(openFileDialog1.FileNames[i]), typeof(byte[]));

                                Model.Tbl_Pat_Images Obj_Tbl_PatImages = new Model.Tbl_Pat_Images();
                                Model.Tbl_Patient Obj_Tbl_Pat = new Model.Tbl_Patient();
                                Obj_Tbl_PatImages.Image = dadadadada;
                                Obj_Tbl_PatImages.PatientID = Trans_Class.ID_Pat_Trans;
                                DB_Obj.Tbl_Pat_Images.Add(Obj_Tbl_PatImages);

                                DB_Obj.SaveChanges();
                            }
                            DB_Obj.SP_Update_TblPatient_ColImgCoutn(Trans_Class.ID_Pat_Trans);
                            DB_Obj.SaveChanges();
                        }
                        catch (Exception)
                        {
                            MetroMessageBox.Show(this, "ذخیره عکس در سرور موفقیا آمیز نبود", "Can't Save Images!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        

                        Lbl_PicCount.Text = list_img.Count.ToString();
                        form_showing_for_0list_flag = false;
                        pictureBox1.Visible = true;
                        Lbl_NotFound.Visible = false;
                        Pb_NotFound.Visible = false;
                    }
                }
            }
        }
        int LeftNum_Int = 0;
        int RightNum_Int = 0;
        private void IncLbl(bool inp , char Side)
        {
            RightNum_Int =list_img.Count;

            if (inp)
            {
                if (Side == 'f')
                {
                    LeftNum_Int = 1;
                }
                if (Side == 'e')
                {
                    LeftNum_Int = list_img.Count ;  //          -1         is         important
                    Pb_CurrentImg_Index = LeftNum_Int - 1; 
                    pictureBox1.Image = null;
                    pictureBox1.Image = list_img[Pb_CurrentImg_Index];
                    pictureBox1.Show();
                }
            }
            else
            {
                if  (Side == 'r' && (RightNum_Int != LeftNum_Int))
                {
                    ++LeftNum_Int;
                    ++Pb_CurrentImg_Index;
                    pictureBox1.Image = null;
                    pictureBox1.Image = list_img[Pb_CurrentImg_Index];
                    pictureBox1.Show();
                }
                if (Side == 'L' && (LeftNum_Int != 1) && (LeftNum_Int != 0))
                {
                    --LeftNum_Int;
                    --Pb_CurrentImg_Index;
                    pictureBox1.Image = null;
                    pictureBox1.Image = list_img[Pb_CurrentImg_Index];
                    pictureBox1.Show();
                }
            }


            Lbl_DigitLeft.Text = LeftNum_Int.ToString();
            Lbl_DigitRight.Text = RightNum_Int.ToString();
            

            //StringBuilder Sb = new StringBuilder(Lbl_ImgNum.Text);

            //if (inp)
            //{
            //    ++Sb[4];
            //    if (Side == 'f')
            //    {
            //        Sb[0] = '1';
            //    }
            //}
            //else
            //{
            //    if (Sb[0] != Sb[4] && Side == 'r')
            //    {
            //        ++Sb[0];
            //        ++Pb_CurrentImg_Index;
            //        pictureBox1.Image = null;
            //        pictureBox1.Image = list_img[Pb_CurrentImg_Index];
            //        pictureBox1.Show();
            //    }
            //    if (Sb[0] != '1' && Side == 'L')
            //    {
            //        --Sb[0];
            //        --Pb_CurrentImg_Index;
            //        pictureBox1.Image = null;
            //        pictureBox1.Image = list_img[Pb_CurrentImg_Index];
            //        pictureBox1.Show();
            //    }
            //}

            ////char Sb0Char = Convert.ToChar(Sb0int);
            ////char Sb4Char = Convert.ToChar(Sb4int);
            ////Sb[0] = Sb0Char;
            ////Sb[4] = Sb4Char;

            //string s = string.Format("{0} / {1}", Sb[0], Sb[4]);
            //Lbl_ImgNum.Text = s;


        }

        private void Btn_NextImg_Click(object sender, EventArgs e)
        {
            IncLbl(false, 'r');
        }
        private void Btn_PrevImg_Click(object sender, EventArgs e)
        {
            IncLbl(false, 'L');
        }
        private void Btn_SaveFromSql_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.Title = "کجا ذخیره شود ؟";
            //saveFileDialog1.FileName = "Image.png";
            //saveFileDialog1.ShowDialog();
            

            saveFileDialog1.Filter = "Images|*.png;*.bmp;*.jpg";
            saveFileDialog1.FileName = Trans_Class.NameAndFam;

            ImageFormat format = ImageFormat.Png;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                string Full_Adrs = System.IO.Path.GetFullPath(saveFileDialog1.FileName);

                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                        //case ".png":
                        //    format = ImageFormat.Png;
                        //    break;
                }
                for (int i = 0; i < list_img.Count; i++)
                {
                    //char[] res = Full_Adrs.ToCharArray();
                    //res[res.Length - 6] = Convert.ToChar(i);
                    //string Final = new string(res);

                    //StringBuilder SB = new StringBuilder(Full_Adrs);
                    //string final = SB.ToString();
                    //SB.Insert(SB.Length - 4, Convert.ToChar(i));

                    string Final =    Full_Adrs.Insert(Full_Adrs.Length - 4, i.ToString());
                    
                    list_img[i].Save(Final, format);
                }
                MetroMessageBox.Show(this, "عکس(ها) با موفقیت در حافظه ذخیره شد.", "Done!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_MaximizeImg_Click(object sender, EventArgs e)
        {
            list_img[Pb_CurrentImg_Index].Save(list_img[Pb_CurrentImg_Index].ToString(), System.Drawing.Imaging.ImageFormat.Png);
            Process photoViewer = new Process();
            photoViewer.StartInfo.FileName = list_img[Pb_CurrentImg_Index].ToString();
            photoViewer.Start();
            //System.Diagnostics.Process.Start(list_img[Pb_CurrentImg_Index].ToString());
        }

        private void Checkbox1_OnChange(object sender, EventArgs e)
        {
            if (Checkbox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Size = new Size(537, 379);
                pictureBox1.Dock = DockStyle.Fill;
                pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
            else
            {
                panel1.AutoScroll = true;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox1.Dock = DockStyle.None;
                pictureBox1.Size = new Size(520, 362);
                pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            SetDesktopLocation(CenterX, CenterY);
            ExitY = -(Screen.PrimaryScreen.WorkingArea.Height - 20);
            timer_GoOut.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //(Checkbox1.Checked==true) ? Checkbox1.Checked = false : Checkbox1.Checked = true;
            if (Checkbox1.Checked)
            {
                Checkbox1.Checked = false;
            }
            else
            {
                Checkbox1.Checked = true;
            }

            Checkbox1_OnChange(null, null);
        }

        int CenterX;
        int CenterY;
        int StartY;
        int ExitY;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartY -= 10;
            if (StartY <= CenterY)
            {
                timer1.Stop();
                if (form_showing_for_0list_flag == true)
                {
                    MetroMessageBox.Show(this, "عکسی برای کاربر مورد نظر اضافه نشده است", "No Picture!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
                SetDesktopLocation(CenterX, StartY);
        }
        private void Form_EditImages_FormClosing(object sender, FormClosingEventArgs e)
        {
            Btn_Save_Click(null, null);
        }
        private void Form_Showing()
        {
            StartY = Screen.PrimaryScreen.Bounds.Height;

            CenterY = ((Screen.PrimaryScreen.WorkingArea.Height) - (this.Height)) / 2;
            CenterX = Screen.PrimaryScreen.Bounds.Location.Y + (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            SetDesktopLocation(CenterX, StartY);
            timer1.Enabled = true;
            timer1.Start();
        }
        private void timer_GoOut_Tick(object sender, EventArgs e)
        {
            StartY -= 10;
            if (StartY <= ExitY)
            {
                timer1.Stop();
                this.Close();
            }
            else
            {
                SetDesktopLocation(CenterX, StartY);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            list_img.Clear();
            pictureBox1.Image = null;
            Lbl_DigitLeft.Text = "0";
            Lbl_DigitRight.Text = "0";
            Lbl_PicCount.Text = "0";
            DialogResult ds = MetroMessageBox.Show(this, "تمامی عکس های انتخاب شده با موفقیت پاک شدند.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
            if (ds == DialogResult.OK)
            {
                Btn_Save_Click(null, null);
                
            }
            
            
        }

        private void Txt_Name2_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = Btn_AddImg;
        }

        private void Btn_DelRecord_Click(object sender, EventArgs e)
        {
            if (input == 1)
            {
                list_img.RemoveAt(Pb_CurrentImg_Index);

                if (list_img.Count == 0)
                {
                    linkLabel1_LinkClicked(null, null);
                }
                else
                {
                    if (LeftNum_Int == 1)
                    {
                        IncLbl(true, 'f');
                        pictureBox1.Image = list_img[0];
                    }
                    else
                    {
                        IncLbl(false, 'L');
                    }
                }
            }
            else
            {
                DialogResult DS = MetroMessageBox.Show(this, "آیا برای حذف عکس اطمینان دارید ؟", "Really Remove ?!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (DS == DialogResult.Yes)
                {
                    list_img.RemoveAt(Pb_CurrentImg_Index);

                    Model.DB_ClinicEntities DB_Obj = new Model.DB_ClinicEntities();

                    var query_Select_Images = DB_Obj.SP_SelectAndCount_Pat_Images(Trans_Class.ID_Pat_Trans).ToList();

                    if (query_Select_Images.Count == 1)
                    {
                        var qq = query_Select_Images[0].Value; //  q[0].Value --> ID e khode image dar Tbl_PatImages
                        DB_Obj.SP_Del_One_OF_PatImage(qq);
                    }
                    else
                    {
                        var qq = query_Select_Images[Pb_CurrentImg_Index/* + 1*/].Value;
                        DB_Obj.SP_Del_One_OF_PatImage(qq);
                    }

                    //var q_Pat_ImgCount= DB_Obj.Tbl_Patient.ToList().Find(s => s.ID == Trans_Class.ID_Pat_Trans);
                    //q_Pat_ImgCount.CountOfPictures = list_img.Count;
                    DB_Obj.SP_Update_TblPatient_ColImgCoutn(Trans_Class.ID_Pat_Trans);
                    DB_Obj.SaveChanges();



                    if (list_img.Count == 0)
                    {
                        linkLabel1_LinkClicked(null, null);
                    }
                    else
                    {
                        if (LeftNum_Int == 1)
                        {
                            IncLbl(true, 'f');
                            pictureBox1.Image = list_img[0];
                        }
                        else
                        {
                            IncLbl(false, 'L');
                        }
                    }
                }
                else
                {

                }
                
            }
            Lbl_PicCount.Text = list_img.Count.ToString();

        }
    }
}
