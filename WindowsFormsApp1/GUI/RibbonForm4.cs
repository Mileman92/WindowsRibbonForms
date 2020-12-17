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
using DevExpress.XtraBars.Docking;

namespace WindowsFormsApp1
{
    public partial class RibbonForm4 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm4()
        {
            InitializeComponent();

            //appmaster
            queryDevicesListBindingSource.SuspendBinding();
            queryDevicesListTableAdapter.Fill(
                aPPDataSet.QueryDevicesList);
            queryDevicesListBindingSource.SuspendBinding();

            //qListRM
            qListRMBindingSource.SuspendBinding();
            qListRMTableAdapter.Fill(
                aPPDataSet.qListRM, 8);
            qListRMBindingSource.ResumeBinding();

            //qScheduledTasksCurrent
            qScheduledTasksCurrentDetailBindingSource.SuspendBinding();
            qScheduledTasksCurrentDetailTableAdapter.Fill(
                aPPDataSet.qScheduledTasksCurrentDetail, 1259703);
            qScheduledTasksCurrentDetailBindingSource.ResumeBinding();

        }

        private void simpleButton1Abbrechen_Click(object sender, EventArgs e)
        {
            //Massrückmeldung panel
           // dockPanelMassrückmeldung.Visibility = DockVisibility.Hidden;
        }

        private void simpleButton2Abbrechen_Click(object sender, EventArgs e)
        {
            //Prüfarbeit panel hide
           // dockPanelPrüfarbeit.Visibility = DockVisibility.Hidden;
        }
    }
}