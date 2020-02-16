using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using System.IO;

namespace Clinic_App
{
    class Trans_Class
    {

        public static bool Flag_Visit_Edit = false;

        public static bool Flag_Pat_Edit = false;

        public static bool Flag_Doc_Edit = false;
        public static bool Flag_Doc_Add = false;

        public static bool Flag_Edit_Sections = false;
        public static bool Flag_Edit_Services = false;

        public static bool Flag_Add_SeRR = false;
        public static bool Flag_Add_SeCC = false;

        //  public static bool Flag_Clinic_Edit = false;
        public static bool Flag_Back_from_srchingfrm = false;


        public static bool Settings_Btn_Click_Flag { set; get; }
        public static bool Reception_Btn_Click_Flag { set; get; }

        public static int ID_Pat_Trans { set; get; }
        public static int ID_Dr_Trans { set; get; }
        public static int ID_Visit_Trans { set; get; }
        public static int ID_SecSer_Trans { set; get; }
        //Time
        public static string Date_Visit_Trans { set; get; }
        public static string Time_Visit_Trans { set; get; }
        //Time
        public static string Pw { set; get; }
        public static string User { set; get; }
        public static int RoleID { set; get; }
        public static string NameAndFam { set; get; }
        public static string PhoneNo { set; get; }
        public static string Adrs { set; get; }
        public static string Email { set; get; }

        public static Form ParentFormTr { get; set; }

        public static byte[] Img { set; get; }

        //List<byte[]> list_img_Byte = new List<byte[]>();

        //List<Image> list_img = new List<Image>();
        //public void Func_AddToImgList(Image inp)
        //{
        //    list_img.Add(inp);
        //}
    }
}