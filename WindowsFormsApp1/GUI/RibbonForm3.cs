using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RibbonForm3 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm3()                                                 //barEditItemAnlage  /*3 barEditItem3.EditValue  AnlageLookUpEdit */

        {
            InitializeComponent();

            //  AnlageLookUpEdit

            AnlageLookUpEdit.EditValue = 3;
            BetriebLookUpEdit.EditValue = -1;
            GebaudeLookUpEdit.EditValue = "ALLE";

            OffenCheckbox.Checked=true; //checkbox cheking



           


            //Prufobjekte
           

        }

        private void barEditItemAnlage_EditValueChanged(object sender, EventArgs e)
        {
            //selected in lookupedit Anlage

           
        }

        private void barButtonSchließen_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void ScheduledTasksGridControl_MouseClick(object sender, MouseEventArgs e)
        {
            //Right click popupmenu
            if (e.Button == MouseButtons.Right)
            {
                popupMenuPrufarbeiten.ShowPopup(Control.MousePosition);

            }
           
        }

        private void BetriebLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {   
            //selected in lookupedit Betrieb
            
        }

        private void GebaudeLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            //selected in lookupedit Gebaude
           
        }


        Boolean changed = false;
        private void OffenCheckbox_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            // int antlageIndex = Convert.ToInt32(AnlageLookUpEdit.EditValue.ToString());
            // int betriebIndex = Convert.ToInt32(BetriebLookUpEdit.EditValue.ToString());
            // string gebaude = GebaudeLookUpEdit.EditValue.ToString();
            Cursor.Current = Cursors.WaitCursor;

            if (!changed)
            {
                if (ErledigtCheckbox.Checked)
                {
                    changed = true;
                    ErledigtCheckbox.Checked = false;
                }
                if (ArbeitCheckbox.Checked)
                {
                    changed = true;
                    ArbeitCheckbox.Checked = false;
                }
                if (ÜberfälligCheckbox.Checked)
                {
                    changed = true;
                    ÜberfälligCheckbox.Checked = false;
                }
                if (AlleCheckbox.Checked)
                {
                    changed = true;
                    AlleCheckbox.Checked = false;
                }
                if (HistorieCheckbox.Checked)
                {
                    changed = true;
                    HistorieCheckbox.Checked = false;
                }
            }
            else
            {
                changed = false;
            }

           

            Cursor.Current = Cursors.Default;
        }

        private void ErledigtCheckbox_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //int antlageIndex = Convert.ToInt32(AnlageLookUpEdit.EditValue.ToString());
            //int betriebIndex = Convert.ToInt32(BetriebLookUpEdit.EditValue.ToString());
            //string gebaude = GebaudeLookUpEdit.EditValue.ToString();
            if (!changed)
            {
                if (OffenCheckbox.Checked)
                {
                    changed = true;
                    OffenCheckbox.Checked = false;
                }
                if (ArbeitCheckbox.Checked)
                {
                    changed = true;
                    ArbeitCheckbox.Checked = false;
                }
                if (ÜberfälligCheckbox.Checked)
                {
                    changed = true;
                    ÜberfälligCheckbox.Checked = false;
                }
                if (AlleCheckbox.Checked)
                {
                    changed = true;
                    AlleCheckbox.Checked = false;
                }
                if (HistorieCheckbox.Checked)
                {
                    changed = true;
                    HistorieCheckbox.Checked = false;
                }
            }
            else
            {
                changed = false;
            }


           

            Cursor.Current = Cursors.Default;
        }

        private void ArbeitCheckbox_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //int antlageIndex = Convert.ToInt32(AnlageLookUpEdit.EditValue.ToString());
            //int betriebIndex = Convert.ToInt32(BetriebLookUpEdit.EditValue.ToString());
            //string gebaude = GebaudeLookUpEdit.EditValue.ToString();
            if (!changed)
            {
                if (OffenCheckbox.Checked)
                {
                    changed = true;
                    OffenCheckbox.Checked = false;
                }
                if (ErledigtCheckbox.Checked)
                {
                    changed = true;
                    ErledigtCheckbox.Checked = false;
                }
                if (ÜberfälligCheckbox.Checked)
                {
                    changed = true;
                    ÜberfälligCheckbox.Checked = false;
                }
                if (AlleCheckbox.Checked)
                {
                    changed = true;
                    AlleCheckbox.Checked = false;
                }
                if (HistorieCheckbox.Checked)
                {
                    changed = true;
                    HistorieCheckbox.Checked = false;
                }
            }
            else
            {
                changed = false;
            }

        

            Cursor.Current = Cursors.Default;
        }

        private void ÜberfälligCheckbox_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //int antlageIndex = Convert.ToInt32(AnlageLookUpEdit.EditValue.ToString());
            //int betriebIndex = Convert.ToInt32(BetriebLookUpEdit.EditValue.ToString());
            //string gebaude = GebaudeLookUpEdit.EditValue.ToString();
            if (!changed)
            {
                if (OffenCheckbox.Checked)
                {
                    changed = true;
                    OffenCheckbox.Checked = false;
                }
                if (ErledigtCheckbox.Checked)
                {
                    changed = true;
                    ErledigtCheckbox.Checked = false;
                }
                if (ArbeitCheckbox.Checked)
                {
                    changed = true;
                    ArbeitCheckbox.Checked = false;
                }
                if (AlleCheckbox.Checked)
                {
                    changed = true;
                    AlleCheckbox.Checked = false;
                }
                if (HistorieCheckbox.Checked)
                {
                    changed = true;
                    HistorieCheckbox.Checked = false;
                }
            }
            else
            {
                changed = false;
            }

          

            Cursor.Current = Cursors.Default;
        }

        private void AlleCheckbox_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //int antlageIndex = Convert.ToInt32(AnlageLookUpEdit.EditValue.ToString());
            //int betriebIndex = Convert.ToInt32(BetriebLookUpEdit.EditValue.ToString());
            //string gebaude = GebaudeLookUpEdit.EditValue.ToString();
            if (!changed)
            {
                if (OffenCheckbox.Checked)
                {
                    changed = true;
                    OffenCheckbox.Checked = false;
                }
                if (ErledigtCheckbox.Checked)
                {
                    changed = true;
                    ErledigtCheckbox.Checked = false;
                }
                if (ArbeitCheckbox.Checked)
                {
                    changed = true;
                    ArbeitCheckbox.Checked = false;
                }
                if (ÜberfälligCheckbox.Checked)
                {
                    changed = true;
                    ÜberfälligCheckbox.Checked = false;
                }
                if (HistorieCheckbox.Checked)
                {
                    changed = true;
                    HistorieCheckbox.Checked = false;
                }
            }
            else
            {
                changed = false;
            }


          

            Cursor.Current = Cursors.Default;
        }

        private void HistorieCheckbox_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //int antlageIndex = Convert.ToInt32(AnlageLookUpEdit.EditValue.ToString());
            //int betriebIndex = Convert.ToInt32(BetriebLookUpEdit.EditValue.ToString());
            //string gebaude = GebaudeLookUpEdit.EditValue.ToString();
            if (!changed)
            {
                if (OffenCheckbox.Checked)
                {
                    changed = true;
                    OffenCheckbox.Checked = false;
                }
                if (ErledigtCheckbox.Checked)
                {
                    changed = true;
                    ErledigtCheckbox.Checked = false;
                }
                if (ArbeitCheckbox.Checked)
                {
                    changed = true;
                    ArbeitCheckbox.Checked = false;
                }
                if (ÜberfälligCheckbox.Checked)
                {
                    changed = true;
                    ÜberfälligCheckbox.Checked = false;
                }
                if (AlleCheckbox.Checked)
                {
                    changed = true;
                    AlleCheckbox.Checked = false;
                }
            }
            else
            {
                changed = false;
            }

         
            Cursor.Current = Cursors.Default;
        }

        int broj()
        {
            int odabir = -1;
            if (OffenCheckbox.Checked) //zuta
                odabir = 0;
            if (ErledigtCheckbox.Checked) //zelena
                odabir = 1;
            if (ArbeitCheckbox.Checked) //plava
                odabir = 2;
            if (ÜberfälligCheckbox.Checked) //crvena
                odabir = 4;
            if (AlleCheckbox.Checked) //siva
                odabir = -1;
            if (HistorieCheckbox.Checked) //bela
                odabir = 5;
            return odabir;

        }

        private void PrüfarbeitenVorschauButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Call button Vorschau, Vorschau button is hidden
            RibbonForm1 rb = new RibbonForm1();
            rb.navBarVorschau_LinkPressed(sender, null);
           // rb.Test();

            //rb.navBarVorschau_LinkPressed(sender, null);

            // rb.navBarVorschau_ItemChanged(sender, e);

        }

        private void AlleAuswählen_ItemClick(object sender, ItemClickEventArgs e)
        {
            //select all
            bandedGridView1.SelectAll();
        }

        private void AuswahlEntfernen_ItemClick(object sender, ItemClickEventArgs e)
        {   
            //clear selection
            bandedGridView1.ClearSelection();
        }

        private void AuswahlInvertieren_ItemClick(object sender, ItemClickEventArgs e)
        {
            //invert selection
            for (int rowHandle = 0; rowHandle < bandedGridView1.RowCount; rowHandle++)
                bandedGridView1.InvertRowSelection(rowHandle);
        }


        
        private void KompaktbarCheck_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            //TabellenAnsichtbarSub
            KompaktbarCheck.Checked = true;
            if (gridBand2.Visible)
            {
                gridBand2.Visible = false;
                gridBand2ExplSchutZone.Visible = false;
                StandardbarCheck.Checked = false;
                ErweitertbarCheck.Checked = false;


            }
            if (gridBand2Allgemein.Visible)
            {
                gridBand2Allgemein.Visible = false;
            }
             

        }

        private void StandardbarCheck_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            //StandardbarCheck
            if(gridBand2.Visible)
            {
                gridBand2.Visible = false;
                gridBand2ExplSchutZone.Visible = false;
            } 
            else
            {
                gridBand2.Visible = true;
                gridBand2ExplSchutZone.Visible = true;
            }

        }

        private void ErweitertbarCheck_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            // ErweitertbarCheck
            if (gridBand2Allgemein.Visible)
            {
                gridBand2Allgemein.Visible = false;
            }
            else
            {
                gridBand2Allgemein.Visible = true;
            }
        }

        private void AnzeigenbarCheck_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            //AnzeigenbarCheck
            if(AnzeigenbarCheck.Checked)
            {
                dockPanel1.Hide();
            }
            else
            {
                dockPanel1.Show();
            }    
        }


        Boolean changed1 = false;
        private void barButtonBaumVerankern_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (!changed1)
            {
                changed1 = true;
                dockPanelPrüfobjekte.Visibility = DockVisibility.Hidden;
            }
            else
            {
                changed1 = false;
                dockPanelPrüfobjekte.Visibility = DockVisibility.Visible;
            }
            

        }

        
        private void RückmeldungButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            //action RückmeldungButton
            if (bandedGridView1.SelectedRowsCount > 0)
            {
                dockPanel2Prüfarbeit.Visibility = DockVisibility.Hidden;
                dockPanel3Massrückmeldung.Visibility = DockVisibility.Visible;
            }
        }

        private void DetailAnzeigen_ItemClick(object sender, ItemClickEventArgs e)
        {
            //action Detail
            if (bandedGridView1.SelectedRowsCount == 1)
            {
                dockPanel3Massrückmeldung.Visibility = DockVisibility.Hidden;
                dockPanel2Prüfarbeit.Visibility = DockVisibility.Visible;
            }
            else
            {
                string title = "Informationen";
                string message = "Kein Detailansicht beim Mehrauswahl möglich.";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void simpleButtoAbbrechen_Click(object sender, EventArgs e)
        {
            //Prüfarbeit dock
            dockPanel2Prüfarbeit.Visibility = DockVisibility.Hidden;
        }

        private void simpleButton1Abbrechen_Click(object sender, EventArgs e)
        {
            //Massrückmeldung panel
            dockPanel3Massrückmeldung.Visibility = DockVisibility.Hidden;
        }

        private void ImBaumAnzeigen_ItemClick(object sender, ItemClickEventArgs e)
        {
            //action ImBaumAnzeigen
            if (bandedGridView1.SelectedRowsCount == 1)
            {

            }
            else
            {

            }
        }

        private void ExportExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Export to Excel
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "*.xlsx|*.xlsx";
            if(s.ShowDialog()==DialogResult.OK)
            {
                bandedGridView1.ExportToXlsx(s.FileName);
            }    
        }

        Boolean check5 = false;
        private void barButtonRules_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Regularien
            if (!check5)
            {
                check5 = true;
                dockPanelPrüfobjekte.Width = 950;
                ScheduledTasksTreeList.OptionsView.ShowColumns = true;
                ScheduledTasksTreeList.OptionsView.ShowHorzLines = true;
                ScheduledTasksTreeList.OptionsView.ShowVertLines = true;
                colPIV.Visible = true;
                colPIV.Width = 30;
                colPRIO.Visible = true;
                colPRIO.Width = 30;
                colBZ.Visible = true;
                colBZ.Width = 30;
                colSH.Visible = true;
                colSH.Width = 30;
                colPD.Visible = true;
                colPD.Width = 40;
                colGP.Visible = true;
                colGP.Width = 82;
                colMC.Visible = true;
                colMC.Width = 30;
                colMIN.Visible = true;
                colMIN.Width = 30;
                colSU.Visible = true;
                colSU.Width = 30;
                colPV.Visible = true;
                colPV.Width = 30;
                colDAO.Visible = true;
                colDAO.Width = 30;
                colEIE.Visible = true;
                colEIE.Width = 30;
                colAK.Visible = true;
                colAK.Width = 80;
                colDK.Visible = true;
                colDK.Width = 80;
                colIDA.Width = 70;
                colPIV.VisibleIndex = 1;
                colPRIO.VisibleIndex = 2;
                colBZ.VisibleIndex = 3;
                colSH.VisibleIndex = 4;
                colPD.VisibleIndex = 5;
                colGP.VisibleIndex =6;
                colMC.VisibleIndex = 7;
                colMIN.VisibleIndex = 8;
                colSU.VisibleIndex = 9;
                colPV.VisibleIndex = 10;
                colDAO.VisibleIndex = 11;
                colEIE.VisibleIndex = 12;
                colAK.VisibleIndex = 13;
                colDK.VisibleIndex = 14;
                colIDA.VisibleIndex = 15;
                    

            }
            else
            {
                ScheduledTasksTreeList.OptionsView.ShowColumns = false;
                ScheduledTasksTreeList.OptionsView.ShowHorzLines = false;
                ScheduledTasksTreeList.OptionsView.ShowVertLines = false;
                check5 = false;
                dockPanelPrüfobjekte.Width = 270;
                colPIV.Visible = false;
                colPRIO.Visible = false;
                colBZ.Visible = false;
                colSH.Visible = false;
                colPD.Visible = true;
                colGP.Visible = false;
                colMC.Visible = false;
                colMIN.Visible = false;
                colSU.Visible = false;
                colPV.Visible = false;
                colDAO.Visible = false;
                colEIE.Visible = false;
                colAK.Visible = false;
                colDK.Visible = false;
                colIDA.Visible = true;
                colPD.VisibleIndex = 1;
                colIDA.VisibleIndex = 2;
            }
        }
    }
}