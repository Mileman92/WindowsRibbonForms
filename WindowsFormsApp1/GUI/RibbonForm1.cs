using DevExpress.XtraBars.Ribbon;
using System;
using System.Windows.Forms;
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();

         
        }


        private void RibbonForm1_Load(object sender, EventArgs e)
        {
            //tabbedView1.AddDocument(new XtraUserControl2());
            this.ribbon.MdiMergeStyle = RibbonMdiMergeStyle.OnlyWhenMaximized;

         

        }


        private void navBarItem1_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //tabbedView1.AddDocument(new XtraUserControl1());

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(RibbonForm2))
                {
                    form.Activate();
                    return;
                }
            }


            var f = new RibbonForm2();
            f.MdiParent = this;
            f.Show();


        }

        private void navBarItem2_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //tabbedView1.AddDocument(new XtraUserControl2());

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(RibbonForm3))
                {
                    form.Activate();
                    return;
                }
            }


            var f = new RibbonForm3();
            f.MdiParent = this;
            f.Show();
        }

       

        private void navBarItem2Apparaten_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(RibbonForm4))
                {
                    form.Activate();
                    return;
                }
            }


            var f = new RibbonForm4();
            f.MdiParent = this;
            f.Show();
        }

      

        

        public void navBarVorschau_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(RibbonForm5))
                {
                    form.Activate();
                    return;
                }
            }


            var f = new RibbonForm5();
            f.MdiParent = this;
            f.Show();
        }

        //public void Test()
        //{
        //    foreach (Form form in Application.OpenForms)
        //    {
        //        if (form.GetType() == typeof(RibbonForm5))
        //        {
        //            form.Activate();
        //            return;
        //        }
        //    }


        //    var f = new RibbonForm5();
        //    f.MdiParent = this;
        //    f.Show();

        //}
    }
}