using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.Skins;

namespace WindowsFormsApp1.GUI
{
    public partial class RibbonForm5 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm5()
        {
            InitializeComponent();

            //Train Journal
            timeTrainJournalBindingSource.SuspendBinding();
            timeTrainJournalTableAdapter.Fill(
                pruefExecDataSet.TimeTrainJournal, 2090892);
            timeTrainJournalBindingSource.ResumeBinding();

            //Vorschau
            tfGetScheduledTasksListCurrentBindingSource.SuspendBinding();
            tf_GetScheduledTasksListCurrentTableAdapter.Fill(
                pruefExecDataSet.tf_GetScheduledTasksListCurrent, 3, -1, "ALLE", "ALLE", "ALLE", 0, 250000, "m.markovic"
            );
            tfGetScheduledTasksListCurrentBindingSource.ResumeBinding();
        }

        private void RibbonForm5_Load(object sender, EventArgs e)
        {
            SkinElement element = SkinManager.GetSkinElement(SkinProductId.Ribbon, DevExpress.LookAndFeel.UserLookAndFeel.Default, "PopupGalleryGroupCaption");
            element.Size.MinSize = new Size(element.Size.MinSize.Height, 8);
          
        }

        private void barButtonAlle_ItemClick(object sender, ItemClickEventArgs e)
        {
            //select all
            bandedGridView1.SelectAll();
        }

        private void barButtonEntfernen_ItemClick(object sender, ItemClickEventArgs e)
        {
            //clear selection
            bandedGridView1.ClearSelection();
        }

        private void barButtonAuswahl_ItemClick(object sender, ItemClickEventArgs e)
        {
            //invert selection
            for (int rowHandle = 0; rowHandle < bandedGridView1.RowCount; rowHandle++)
                bandedGridView1.InvertRowSelection(rowHandle);
        }

        private void barButtonSchließen_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Schlissen
            Close();
        }

        private void barCheckZukünftig_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (barCheckZukünftig.Checked)
            {
                barCheckOffen.Checked = false;
                barCheckInArbeit.Checked = false;
                barCheckÜberfällig.Checked = false;
            }
            //Vorschau
            tfGetScheduledTasksListCurrentBindingSource.SuspendBinding();
            tf_GetScheduledTasksListCurrentTableAdapter.Fill(
                pruefExecDataSet.tf_GetScheduledTasksListCurrent, 3, -1, "ALLE", "ALLE", "ALLE", -1, 250000, "m.markovic"
            );
            tfGetScheduledTasksListCurrentBindingSource.ResumeBinding();
        }

        private void barCheckOffen_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (barCheckOffen.Checked)
            {
                barCheckZukünftig.Checked = false;
                barCheckInArbeit.Checked = false;
                barCheckÜberfällig.Checked = false;
            }
            //Vorschau
            tfGetScheduledTasksListCurrentBindingSource.SuspendBinding();
            tf_GetScheduledTasksListCurrentTableAdapter.Fill(
                pruefExecDataSet.tf_GetScheduledTasksListCurrent, 3, -1, "ALLE", "ALLE", "ALLE", 0, 250000, "m.markovic"
            );
            tfGetScheduledTasksListCurrentBindingSource.ResumeBinding();

           
        }

        private void barCheckInArbeit_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (barCheckInArbeit.Checked)
            {
                barCheckZukünftig.Checked = false;
                barCheckOffen.Checked = false;
                barCheckÜberfällig.Checked = false;
            }
            //Vorschau
            tfGetScheduledTasksListCurrentBindingSource.SuspendBinding();
            tf_GetScheduledTasksListCurrentTableAdapter.Fill(
                pruefExecDataSet.tf_GetScheduledTasksListCurrent, 3, -1, "ALLE", "ALLE", "ALLE", 2, 250000, "m.markovic"
            );
            tfGetScheduledTasksListCurrentBindingSource.ResumeBinding();
        }

        private void barCheckÜberfällig_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (barCheckÜberfällig.Checked)
            {
                barCheckZukünftig.Checked = false;
                barCheckOffen.Checked = false;
                barCheckInArbeit.Checked = false;
            }
            //Vorschau
            tfGetScheduledTasksListCurrentBindingSource.SuspendBinding();
            tf_GetScheduledTasksListCurrentTableAdapter.Fill(
                pruefExecDataSet.tf_GetScheduledTasksListCurrent, 3, -1, "ALLE", "ALLE", "ALLE", 4, 250000, "m.markovic"
            );
            tfGetScheduledTasksListCurrentBindingSource.ResumeBinding();
        }

        private void barButtonExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "*.xlsx|*.xlsx";
            if (s.ShowDialog() == DialogResult.OK)
            {
                bandedGridView1.ExportToXlsx(s.FileName);
            }
        }
    }
}