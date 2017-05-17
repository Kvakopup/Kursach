using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanyaNewHopev2
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CallBackMyList.callbackEventHandler = new CallBackMyList.callbackEvent(this.GetUpdatedList);
            
        }
        
        DataBase pData = new DataBase();
        Spec currentSpec = new Spec();
        University currentUniver = new University();
        Form f2 = new Editing();

        
        private void Form1_Load(object sender, EventArgs e)
        {
            koef1.Controls[0].Visible = false;
            koef2.Controls[0].Visible = false;
            koef3.Controls[0].Visible = false;
            AtestatKoef.Controls[0].Visible = false;

            UpdateUnivers();
            UpdateSpecSearch();
            UpdateFacSearch();
        
        }

        private void GetUpdatedList(List<University> param)
        {
            pData.UniverList = param;
            UpdateFac();
            UpdateSpec();
            UpdateUnivers();
        }

       public void UpdateSpecSearch()
        {
            SPECforsearch.Items.Clear();
            foreach (var spec in pData.GetFullDistinctSpecList())
            {
                SPECforsearch.Items.Add(spec);
            }
        }

        public void UpdateFacSearch()
        {
            FACforsearch.Items.Clear();
            foreach (var fac in pData.GetFullDistinctFacList())
            {
                FACforsearch.Items.Add(fac);
            }
        }

        public void UpdateUnivers()
        {
            ChooseUniver.Items.Clear();
          
            foreach (var univer in pData.UniverList)
            {
                ChooseUniver.Items.Add(univer.Name);
              
            }


        }

        private void RemoveAllspreadsheets()
        {
            ZNO1Name.Clear();
            ZNO3Name.Clear();
            ZNO2Name.Items.Clear();
            ZNO1Mark.Value = 100;
            ZNO2Mark.Value = 100;
            ZNO3Mark.Value = 100;
            ZNO4Mark.Value = 100;
            koef1.Value = 0;
            koef2.Value = 0;
            koef3.Value = 0;
            AtestatKoef.Value = 0;
            Verdict.BackColor = Color.DarkSeaGreen;
            Verdict.Text = null;
            rezultbox.Clear();
        }
        private void ChooseUniver_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            UpdateFac();
            ChooseSpec.Items.Clear();
            RemoveAllspreadsheets();

        }

        private void UpdateFac()
        {
            ChooseFac.Items.Clear();
            ChooseSpec.Items.Clear();
            foreach (var univer in pData.UniverList)
            {
                if (univer.Name == ChooseUniver.Text)
                {
                    currentUniver = univer;
                    ShowInfo();
                    foreach (var fac in univer.FacultetList)
                    {
                        ChooseFac.Items.Add(fac.NameOfFac);

                    }
                }
            }
        }

        private void ChooseFac_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            UpdateSpec();
            RemoveAllspreadsheets();
        }

        private void UpdateSpec()
        {
            ChooseSpec.Items.Clear();
            foreach (var univer in pData.UniverList)
            {
                if (univer.Name == ChooseUniver.Text)
                {
                    foreach (var fac in univer.FacultetList)
                    {
                        if (fac.NameOfFac == ChooseFac.Text)
                        {
                            foreach (var spec in fac.SpecList)
                            {
                                ChooseSpec.Items.Add(spec.Name);
                            }
                        }
                    }
                }
            }
        }

        private void ChooseSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            foreach (var univer in pData.UniverList)
            {
                if (univer.Name == ChooseUniver.Text)
                {
                    foreach (var fac in univer.FacultetList)
                    {
                        if (fac.NameOfFac == ChooseFac.Text)
                        {
                            foreach (var spec in fac.SpecList)
                            {
                                if (spec.Name == ChooseSpec.Text)
                                {
                                    ZNO2Name.Items.Clear();
                                    currentSpec = spec;
                                    FillTextBoxesForCalc();


                                }
                            }
                        }
                    }
                }
            }
        }

        private void FillTextBoxesForCalc()
        {
            ZNO1Name.Text = currentSpec.Lzno[0].NAME;
            koef1.Value = (decimal)currentSpec.Lzno[0].KOOF;

            ZNO2Name.Items.Add(currentSpec.Lzno[4].NAME);
            ZNO2Name.Items.Add(currentSpec.Lzno[2].NAME);
            koef2.Value = (decimal)currentSpec.Lzno[1].KOOF;

            ZNO3Name.Text = currentSpec.Lzno[1].NAME;
            koef3.Value = (decimal)currentSpec.Lzno[2].KOOF;

            AtestatInput.Text = currentSpec.Lzno[3].NAME;
            AtestatKoef.Value = (decimal)currentSpec.Lzno[3].KOOF;

        }

        private void ClearALL()
        {
            ZNO1Name.Clear();
            ZNO2Name.Items.Clear();
            ZNO3Name.Clear();
            AtestatInput.Clear();
            ZNO1Mark.Value = 100;
            ZNO2Mark.Value = 100;
            ZNO3Mark.Value = 100;
            ZNO4Mark.Value = 100;

        }
        int i = 1;
        private void getRezult_Click(object sender, EventArgs e)
        {


            

            decimal rezult = (ZNO1Mark.Value * koef1.Value) + (ZNO2Mark.Value * koef2.Value) + (ZNO3Mark.Value * koef3.Value) + (ZNO4Mark.Value * AtestatKoef.Value);
            rezultbox.Text = Math.Round(rezult, 0).ToString();

            if (rezult < currentSpec.Minbal)
            {
                Verdict.Text = "Ви не пройшли на цю спеціальність";
                Verdict.BackColor = Color.Red;
            }
            else if (rezult == currentSpec.Minbal)
            {
                Verdict.Text = "Ви на границі Держзамовленя";
                Verdict.BackColor = Color.Yellow;
            }
            else if (rezult > currentSpec.Minbal)
            {
                Verdict.Text = "Ви стопроцентно пройшли на цю спеціальність";
                Verdict.BackColor = Color.Green;
               
                foreach (var univer in pData.UniverList)
                {
                    if (univer.Name == ChooseUniver.Text )
                    {
                        
                        foreach (var fac in univer.FacultetList)
                        {
                            if (fac.NameOfFac == ChooseFac.Text)
                            {
                                
                                foreach (var spec in fac.SpecList)
                                {
                                    if (spec.Name == ChooseSpec.Text)
                                    {

                                     
                                            ShowPanel.AppendText(i + ":" 
                                                + "Університет:  "
                                                + univer.Name + "\n\n"
                                                + "Факультет :"
                                                + fac.NameOfFac + "\n\n"
                                                + "Спеціальність:  "
                                                + spec.Name + "\n\n"
                                                + "Ваш бал : "
                                                + Math.Round(rezult, 0) 
                                                + "\n\nМінімальний бал :  "
                                                + currentSpec.Minbal + "\n\n\n\n");



                                            i++;
                                        
                                       
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ShowInfo()
        {
            MainDisplay.Clear();
            FinalVUZ.Text = null;
            FinalVUZ.Text = currentUniver.Name;

            int facCounter = 1;
            int specCounter = 1;
            foreach (var fac in currentUniver.FacultetList)
            {

                MainDisplay.AppendText($"{facCounter}. Факультет {fac.NameOfFac}  :  {Environment.NewLine} {Environment.NewLine} Ціна за контракт: {fac.PayForContract} {Environment.NewLine}{Environment.NewLine} Спеціальності: {Environment.NewLine}");
                facCounter++;
                specCounter = 1;
                foreach (var spec in fac.SpecList)
                {
                    MainDisplay.AppendText($"  {specCounter}. {spec.Name}; {Environment.NewLine}    Мінімальный прохідний бал: {spec.Minbal} {Environment.NewLine}    Популярність: {spec.Popular} заяв {Environment.NewLine} {Environment.NewLine}");
                    specCounter++;
                }
            }
        }



        private void SPECforsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpecSearchResult.Clear();
            foreach (var univer in pData.UniverList)
            {
                foreach (var fac in univer.FacultetList)
                {
                    foreach (var spec in fac.SpecList)
                    {
                        if (spec.Name == SPECforsearch.Text)
                        {
                            SpecSearchResult.AppendText($"{Environment.NewLine}{univer.Name} {Environment.NewLine} Факультет :{fac.NameOfFac}{Environment.NewLine}  Популярність: {spec.Popular} {Environment.NewLine}  Мін. Бал: {spec.Minbal} { Environment.NewLine} ");
                        }
                    }
                }
            }
        }

        private void FACforsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            FacSearchResult.Clear();
            foreach (var univer in pData.UniverList)
            {
                foreach (var fac in univer.FacultetList)
                {
                    if (fac.NameOfFac == FACforsearch.Text)
                    {
                        foreach (var spec in fac.SpecList)
                        {
                            FacSearchResult.AppendText($"{Environment.NewLine}{Environment.NewLine}{univer.Name} {Environment.NewLine}  Цена: {fac.PayForContract} {Environment.NewLine} Спеціальності: {spec.Name} {Environment.NewLine} Мін. Бал: {spec.Minbal}{Environment.NewLine} Популярність: {spec.Popular} ");
                        }

                    }
                }
            }
        }

        private void BalSearch_Click(object sender, EventArgs e)
        {
            bool c = false;
            BalSearchResult.Clear();
            foreach (var univer in pData.UniverList)
            {
                foreach (var fac in univer.FacultetList)
                {
                    foreach (var spec in fac.SpecList)
                    {
                        if (spec.Minbal <= BalInput.Value)
                        {
                            c = true;
                            BalSearchResult.AppendText($"{univer.Name}{Environment.NewLine}  Факультет: {fac.NameOfFac} {Environment.NewLine}  Cпеціальнісь: {spec.Name} { Environment.NewLine}{ Environment.NewLine} ");
                        }
                    }
                }
            }
            if (c == false)
            {
                VedictBal.Text = "Ваш бал занизький(.";
                VedictBal.BackColor = Color.Red;
            }
            else
            {
                VedictBal.Text = "Для вас знайдені спеціальності";
                VedictBal.BackColor = Color.DarkSeaGreen;
            }
        }

        private void ContractPriceSearch_Click(object sender, EventArgs e)
        {
            bool c = false;
            ContractPriceSearchResult.Clear();
            foreach (var univer in pData.UniverList)
            {
                foreach (var fac in univer.FacultetList)
                {

                    if (fac.PayForContract <= ContractPriceInput.Value)
                    {
                        c = true;
                        ContractPriceSearchResult.AppendText($"{univer.Name}{Environment.NewLine}  Факультет: {fac.NameOfFac} {Environment.NewLine}  Ціна: {fac.PayForContract} { Environment.NewLine}{ Environment.NewLine} ");
                    }



                }
            }
            if (c == false)
            {
                VerdictPay.Text = "Такої плати за контрактне навчання не знайдено.";
                VerdictPay.BackColor = Color.Red;
            }
            else
            {
                VerdictPay.Text = "Для вас знайдені Університети.";
                VerdictPay.BackColor = Color.DarkSeaGreen;
            }
        }

       

        private void ResetPay_Click(object sender, EventArgs e)
        {
            ContractPriceSearchResult.Clear();
            ContractPriceInput.Value = 0;
            VerdictPay.BackColor = Color.DarkGray;
            VerdictPay.Text = null;
        }

        private void Resetmark_Click(object sender, EventArgs e)
        {
            BalInput.Value = 100;
            BalSearchResult.Clear();
            VedictBal.Text = null;
            VedictBal.BackColor = Color.DarkGray;
        }

        private void ResetFac_Click(object sender, EventArgs e)
        {
            FacSearchResult.Clear();
            FACforsearch.Text = null;
        }

        private void ResetSpec_Click(object sender, EventArgs e)
        {
            SpecSearchResult.Clear();
            SPECforsearch.Text = null;
        }
              

        private void SaveRichtextBox_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();          
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";       
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {              
                ShowPanel.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void ClearShowPanel_Click(object sender, EventArgs e)
        {
            ShowPanel.Clear();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
                ShowPanel.Visible = true;
                ClearShowPanel.Visible = true;
                SaveRichtextBox.Visible = true;
            }
            else
            {
                panel2.Visible = false;
                ShowPanel.Visible = false;
                ClearShowPanel.Visible = false;
                SaveRichtextBox.Visible = false;
            }
        }
        
        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            try
            {
                Form admin = new Admin();
                admin.Show();
                
            }
            catch
            {
                MessageBox.Show("Доступ заборонено.");
            }
                
                 
                                 
        }
    }
}


