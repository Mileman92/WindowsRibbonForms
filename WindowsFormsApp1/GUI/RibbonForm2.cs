using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RibbonForm2 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm2()
        {
            InitializeComponent();


            Cursor.Current = Cursors.WaitCursor;
            //Tree
            

            Cursor.Current = Cursors.Default;
        }

        private void RibbonForm2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pruefPlanDataSet.qListAppStatus' table. You can move, or remove it, as needed.
            //this.qListAppStatusTableAdapter.Fill(this.pruefPlanDataSet.qListAppStatus);

        }

        private void barButton2Schließen_ItemClick(object sender, ItemClickEventArgs e)
        {
            //close
            string title = "Schließen";
            string message = "Wollen Sie die Ausstehende änderungen speichern?";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Save
                Close();
            }
            else
            {
                Close();
            }
        }


        private void ScheduledTasksTreeList_RowCellClick(object sender, DevExpress.XtraTreeList.RowCellClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenuPrufplanung.ShowPopup(Control.MousePosition);

            }
        }
        Boolean changed1 = false;
        private void barButtonItemListeDerApparate_ItemClick(object sender, ItemClickEventArgs e)
        {
            //dockpanel ListeApp  
            if (!changed1)
            {
                changed1 = true;
                changed2 = false;
                dockPanelPrufvorlagen.Visibility = DockVisibility.Hidden;
                dockPanelApparatenliste.Visibility = DockVisibility.Visible;
            }
            else
            {
              
                changed1 = false;
                dockPanelApparatenliste.Visibility = DockVisibility.Hidden;
             
            }
           
        }
        Boolean changed2 = false;
        private void barButton2VorlagenBaum_ItemClick(object sender, ItemClickEventArgs e)
        {
            //dockpanel VorlagenBaum
            if (!changed2)
            {
                changed2 = true;
                changed1 = false;
                dockPanelApparatenliste.Visibility = DockVisibility.Hidden;
                dockPanelPrufvorlagen.Visibility = DockVisibility.Visible;
            }
            else
            {
            
                changed2 = false;
                dockPanelPrufvorlagen.Visibility = DockVisibility.Hidden;
               
            }
           
        }

        private void barButton2Speichern_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Save button
            string title = "Bestätigen";
            string message= "Sind Sie sicher, dass Sie die änderungen speichern wollen ?";
            DialogResult result =  MessageBox.Show( message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information );

            
            {
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        try
                        {
                            //pruefPlanDataSet.AcceptChanges();
                          
                          
                            // ScheduledTasksTreeList   treelist view
                            //qCommonStructTree      datatable 
                            // pruefPlanDataSet      dataset
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }
                }
                else
                {


                }
            }
        }

        private void barButton2ExportExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            //using(var saveFileDialog = new SaveFileDialog { Filter="XLSX file|*.xlsx|XLS file|*.xls", Title ="Save an Excel File"})
            // {
            //     saveFileDialog.ShowDialog();
            //     if(saveFileDialog.FileName != string.Empty)
            //     {
            //         var fileStream = (System.IO.FileStream)saveFileDialog.OpenFile();
            //         ScheduledTasksTreeList.ExportToXlsx(fileStream);
            //         fileStream.Close();



            //     }
            // }

            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "*.xlsx|*.xlsx";
            if (s.ShowDialog() == DialogResult.OK)
            {
                //ScheduledTasksTreeList.ExportToXlsx(s.FileName);
                
            }
        }

        private void gridView5_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //Apparate mouse click
            if (e.Button == MouseButtons.Right)
            {
                popupMenuApparate.ShowPopup(Control.MousePosition);

            }
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //Anweisungen mouse click
            if (e.Button == MouseButtons.Right)
            {

                popupMenuAnweisungen.ShowPopup(Control.MousePosition);

            }
        }

        private void treeListPrufvorlagen_RowClick(object sender, DevExpress.XtraTreeList.RowClickEventArgs e)
        {
            //Prufvorlagen mouse click
            if (e.Button == MouseButtons.Right)
            {
                popupMenuPrufvorlagen.ShowPopup(Control.MousePosition);
            }
            
        }

        Boolean changed3 = false;
        private void ButtonKnotenAufklappen_ItemClick(object sender, ItemClickEventArgs e)
        {   
            //Prufvorlagen  Expand tree
            if (!changed3)
            {
                changed3 = true;
                changed4 = false;
                treeListPrufvorlagen.ExpandAll();
                ButtonKnotenAufklappen.Visibility = BarItemVisibility.Never;
                barButtonItem1.Visibility = BarItemVisibility.Always;

            }
            else
            {
                changed3 = false;

            }
        }

        Boolean changed4 = false;
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Prufvorlagen  Collapse tree
            if (!changed4)
            {
                changed4 = true;
                changed3 = false;
                treeListPrufvorlagen.CollapseAll();
                ButtonKnotenAufklappen.Visibility = BarItemVisibility.Always;
                barButtonItem1.Visibility = BarItemVisibility.Never;
            }
            else
            {
                changed4 = false;

            }
        }
    }
}