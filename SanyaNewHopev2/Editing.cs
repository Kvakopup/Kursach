using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanyaNewHopev2
{
    [Serializable]
    public partial class Editing : Form
    {
        public Editing()
        {
            InitializeComponent();

        }



        Spec currentSpec = new Spec();
        University currentUniver = new University();
        DataBase pData = new DataBase();

        private void Editing_Load(object sender, EventArgs e)
        {
            UpdateUn();

        }

        private void RemoveUniver_Click(object sender, EventArgs e)
        {
            if (UniversForRemove.Text.Length > 0 && FacForRemove.Text.Length == 0 && SPECforRemove.Text.Length == 0)
            {
                for (int indx = 0; indx < pData.UniverList.Count; indx++)
                {
                    if (pData.UniverList[indx].Name == UniversForRemove.Text)
                    {
                        pData.UniverList.Remove(pData.UniverList[indx]);


                        UniversForRemove.Items.Clear();
                        foreach (var univer in pData.UniverList)
                        {

                            UniversForRemove.Items.Add(univer.Name);
                        }

                    }
                }

                MessageBox.Show("Університет успішно видалений.");
            }

            if (UniversForRemove.Text.Length > 0 && FacForRemove.Text.Length > 0 && SPECforRemove.Text.Length == 0)
            {
                for (int i = 0; i < pData.UniverList.Count; i++)
                {
                    if (pData.UniverList[i].Name == UniversForRemove.Text)
                    {
                        for (int j = 0; j < pData.UniverList[i].FacultetList.Count; j++)
                        {
                            if (pData.UniverList[i].FacultetList[j].NameOfFac == FacForRemove.Text)
                            {
                                pData.UniverList[i].FacultetList.Remove(pData.UniverList[i].FacultetList[j]);



                                FacForRemove.Items.Clear();
                                SPECforRemove.Items.Clear();

                            }

                        }
                    }

                }
                MessageBox.Show("Факультет успішно видалений.");
            }

            if (UniversForRemove.Text.Length > 0 && FacForRemove.Text.Length > 0 && SPECforRemove.Text.Length > 0)
            {
                for (int i = 0; i < pData.UniverList.Count; i++)
                {
                    if (pData.UniverList[i].Name == UniversForRemove.Text)
                    {
                        for (int j = 0; j < pData.UniverList[i].FacultetList.Count; j++)
                        {
                            if (pData.UniverList[i].FacultetList[j].NameOfFac == FacForRemove.Text)
                            {
                                for (int g = 0; g < pData.UniverList[i].FacultetList[j].SpecList.Count; g++)
                                {
                                    if (pData.UniverList[i].FacultetList[j].SpecList[g].Name == SPECforRemove.Text)
                                    {

                                        pData.UniverList[i].FacultetList[j].SpecList.Remove(pData.UniverList[i].FacultetList[j].SpecList[g]);

                                        FacForRemove.Items.Clear();
                                        SPECforRemove.Items.Clear();

                                    }
                                }

                            }

                        }
                    }

                }
                MessageBox.Show("Спеціальність успішно видалена.");
            }
        }


        private void UpdateUn()
        {
            UniversForRemove.Items.Clear();
            foreach (var univer in pData.UniverList)
            {

                UniversForRemove.Items.Add(univer.Name);
            }
        }
        private void UniversForRemove_SelectedIndexChanged(object sender, EventArgs e)
        {


            FacForRemove.Items.Clear();
            SPECforRemove.Items.Clear();

            foreach (var univer in pData.UniverList)
            {
                if (univer.Name == UniversForRemove.Text)
                {
                    currentUniver = univer;

                    foreach (var fac in univer.FacultetList)
                    {
                        FacForRemove.Items.Add(fac.NameOfFac);

                    }
                }
            }
        }

        private void FacForRemove_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPECforRemove.Items.Clear();
            foreach (var univer in pData.UniverList)
            {
                if (univer.Name == UniversForRemove.Text)
                {
                    foreach (var fac in univer.FacultetList)
                    {
                        if (fac.NameOfFac == FacForRemove.Text)
                        {
                            foreach (var spec in fac.SpecList)
                            {
                                SPECforRemove.Items.Add(spec.Name);
                            }
                        }
                    }
                }
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            CallBackMyList.callbackEventHandler(pData.UniverList);
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("DB.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, pData.UniverList);
            }
            CallBackMyList.callbackEventHandler(pData.UniverList);
            MessageBox.Show("Зміни успішно збережені");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Ви збереглись?", "Увага", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                editUniver.Items.Clear();
                restoreUniver.Clear();

                editFac.Items.Clear();
                RestoreFac.Clear();
                editNumericPay.Value = 0;

                editSpec.Items.Clear();
                restoreSpec.Clear();
                editNumericMin.Value = 100;
                editNumericPopular.Value = 0;

                restoreZNO1.Clear();
                restoreZNO2.Clear();
                RestoreZNO3.Clear();
                RestoreZno4.Clear();
                editZno1.Value = 0;
                editZno2.Value = 0;
                editZno3.Value = 0;
                editZno4.Value = 0;
                EditAtestat.Value = 0;
                

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Натисніть кнопку зберегтись");
            }




        }


        private void AddUniverInput_TextChanged(object sender, EventArgs e)
        {
            AddFacInput.Visible = true;
            ContractPayAddInput.Visible = true;
        }

        private void ContractPayAddInput_ValueChanged(object sender, EventArgs e)
        {
            if (AddFacInput.TextLength > 0 && ContractPayAddInput.Value > 0)
            {
                AddSpec.Visible = true;
            }
        }

        private void AddSpec_TextChanged(object sender, EventArgs e)
        {
            AddSpecPopInput.Visible = true;
        }

        private void AddSpecPopInput_ValueChanged(object sender, EventArgs e)
        {
            AddMinBalForSpecInput.Visible = true;
        }

        private void AddMinBalForSpecInput_ValueChanged(object sender, EventArgs e)
        {
            AddZno1NameInput.Visible = true;
            AddZno1BalInput.Visible = true;
            AddZno1BalInput.Increment = 0.05M;
        }

        private void AddZno1BalInput_ValueChanged(object sender, EventArgs e)
        {
            if (AddZno1NameInput.TextLength > 0 && AddZno1BalInput.Value > 0)
            {
                AddZno2NameInput.Visible = true;
                AddZno2BalInput.Visible = true;
                AddZno2BalInput.Increment = 0.05M;
            }
        }

        private void AddZno2BalInput_ValueChanged(object sender, EventArgs e)
        {
            if (AddZno2NameInput.TextLength > 0 && AddZno2BalInput.Value > 0)
            {
                AddZno3NameInput.Visible = true;
                AddZno3BalInput.Visible = true;
                AddZno3BalInput.Increment = 0.05M;
            }
        }

        private void AddZno3BalInput_ValueChanged(object sender, EventArgs e)
        {
            if (AddZno3NameInput.TextLength > 0 && AddZno3BalInput.Value > 0)
            {
                ZNO4.Visible = true;
                koefZNO4.Visible = true;
                koefZNO4.Increment = 0.05M;
            }
        }

        private void koefZNO4_ValueChanged(object sender, EventArgs e)
        {
            if (ZNO4.TextLength > 0 && koefZNO4.Value > 0)
            {
                label17.Visible = true;
                AddAtestatKoedInput.Visible = true;
                AddAtestatKoedInput.Increment = 0.05M;
            }
        }

        private void AddAtestatKoedInput_ValueChanged(object sender, EventArgs e)
        {
            AddNewUniver.Visible = true;
            AddAtestatKoedInput.Increment = 0.05M;
        }

        private void AddNewUniver_Click(object sender, EventArgs e)
        {
            bool specFinder = false;
            bool facFinder = false;
            bool unFinder = false;


            for (int univerIndex = 0; univerIndex < pData.UniverList.Count; univerIndex++)
            {


                if (pData.UniverList[univerIndex].Name == AddUniverInput.Text)
                {
                    unFinder = true;
                    for (int facIndex = 0; facIndex < pData.UniverList[univerIndex].FacultetList.Count; facIndex++)
                    {

                        if (pData.UniverList[univerIndex].FacultetList[facIndex].NameOfFac == AddFacInput.Text)
                        {
                            facFinder = true;
                            for (int specIndex = 0; specIndex < pData.UniverList[univerIndex].FacultetList[facIndex].SpecList.Count; specIndex++)
                            {

                                if (pData.UniverList[univerIndex].FacultetList[facIndex].SpecList[specIndex].Name == AddSpec.Text)
                                {
                                    specFinder = true;
                                    MessageBox.Show("Така спеціальність уже є.");
                                }
                            }
                            if (!specFinder)
                            {
                                if (AddSpec.Text == "")
                                {
                                    MessageBox.Show("Вкажіть Спеціальність.");

                                }
                                else

                                    pData.UniverList[univerIndex].FacultetList[facIndex].SpecList.Add(new Spec(AddSpec.Text, new List<ZNO> { new ZNO(Convert.ToDouble(AddZno1BalInput.Value), AddZno1NameInput.Text), new ZNO(Convert.ToDouble(AddZno2BalInput.Value), AddZno2NameInput.Text), new ZNO(Convert.ToDouble(AddZno3BalInput.Value), AddZno3NameInput.Text), new ZNO(Convert.ToDouble(AddAtestatKoedInput.Value), "Aтестат"), new ZNO(Convert.ToDouble(koefZNO4.Value), ZNO4.Text) }, Convert.ToInt32(AddSpecPopInput.Text), Convert.ToInt32(AddMinBalForSpecInput.Text)));


                            }
                        }


                    }
                    if (!facFinder)
                    {
                        if (AddFacInput.Text == "")
                        {
                            MessageBox.Show("Вкажіть Факультет.");

                        }
                        else

                            pData.UniverList[univerIndex].FacultetList.Add(new Facultet(AddFacInput.Text, Convert.ToInt32(ContractPayAddInput.Value), new List<Spec> { new Spec(AddSpec.Text, new List<ZNO> { new ZNO(Convert.ToDouble(AddZno1BalInput.Value), AddZno1NameInput.Text), new ZNO(Convert.ToDouble(AddZno2BalInput.Value), AddZno2NameInput.Text), new ZNO(Convert.ToDouble(AddZno3BalInput.Value), AddZno3NameInput.Text), new ZNO(Convert.ToDouble(AddAtestatKoedInput.Value), "Aтестат"), new ZNO(Convert.ToDouble(koefZNO4.Value), ZNO4.Text) }, Convert.ToInt32(AddSpecPopInput.Value), Convert.ToInt32(AddMinBalForSpecInput.Value)) }));


                    }
                }
            }
            if (!unFinder)
            {
                if (AddUniverInput.Text == "")
                {
                    MessageBox.Show("Вкажіть ВУЗ.");

                }
                else

                    pData.UniverList.Add(new University(AddUniverInput.Text, new List<Facultet> { new Facultet(AddFacInput.Text, Convert.ToInt32(ContractPayAddInput.Value), new List<Spec> { new Spec(AddSpec.Text, new List<ZNO> { new ZNO(Convert.ToDouble(AddZno1BalInput.Value), AddZno1NameInput.Text), new ZNO(Convert.ToDouble(AddZno2BalInput.Value), AddZno2NameInput.Text), new ZNO(Convert.ToDouble(AddZno3BalInput.Value), AddZno3NameInput.Text), new ZNO(Convert.ToDouble(AddAtestatKoedInput.Value), "Aтестат"), new ZNO(Convert.ToDouble(koefZNO4.Value), ZNO4.Text) }, Convert.ToInt32(AddSpecPopInput.Value), Convert.ToInt32(AddMinBalForSpecInput.Value)) }) }));


            }
            Delete();
            AddFacInput.Visible = false;
            ContractPayAddInput.Visible = false;
            AddSpec.Visible = false;
            AddSpecPopInput.Visible = false;
            AddMinBalForSpecInput.Visible = false;
            AddZno1NameInput.Visible = false;
            AddZno1BalInput.Visible = false;
            AddZno2NameInput.Visible = false;
            AddZno2BalInput.Visible = false;
            AddZno3NameInput.Visible = false;
            AddZno3BalInput.Visible = false;
            ZNO4.Visible = false;
            koefZNO4.Visible = false;
            label17.Visible = false;
            AddAtestatKoedInput.Visible = false;
            AddNewUniver.Visible = false;
        }

        private void Delete()
        {
            AddUniverInput.Clear();
            AddFacInput.Clear();
            AddSpec.Clear();
            AddAtestatKoedInput.Value = 0;
            AddMinBalForSpecInput.Value = 100;

            AddSpecPopInput.Value = 0;

            AddZno1NameInput.Clear();
            AddZno2NameInput.Clear();
            AddZno3NameInput.Clear();
            AddZno1BalInput.Value = 0;
            AddZno2BalInput.Value = 0;
            AddZno3BalInput.Value = 0;
            ZNO4.Clear();
            koefZNO4.Value = 0;
            AddAtestatKoedInput.Value = 0;
            ContractPayAddInput.Value = 0;
        }

        private void UniversForRemove_Click(object sender, EventArgs e)
        {
            UniversForRemove.Items.Clear();
            foreach (var univer in pData.UniverList)
            {

                UniversForRemove.Items.Add(univer.Name);
            }
        }

        private void editUniver_Click(object sender, EventArgs e)
        {
            editUniver.Items.Clear();
            foreach (var univer in pData.UniverList)
            {

                editUniver.Items.Add(univer.Name);

            }

        }

        private void editUniver_SelectedValueChanged(object sender, EventArgs e)
        {
            restoreUniver.Text = editUniver.Text;
        }

        private void editFac_Click(object sender, EventArgs e)
        {
            editFac.Items.Clear();
            editSpec.Items.Clear();
            foreach (var univer in pData.UniverList)
            {
                if (univer.Name == editUniver.Text)
                {
                    currentUniver = univer;

                    foreach (var fac in univer.FacultetList)
                    {
                        editFac.Items.Add(fac.NameOfFac);

                    }
                }
            }
        }

        private void editFac_SelectedValueChanged(object sender, EventArgs e)
        {
            RestoreFac.Text = editFac.Text;
            foreach (var univer in pData.UniverList)
            {
                if (univer.Name == editUniver.Text)
                {
                    currentUniver = univer;

                    foreach (var fac in univer.FacultetList)
                    {
                        editNumericPay.Value = fac.PayForContract;

                    }
                }
            }
        }

        private void editSpec_Click(object sender, EventArgs e)
        {
            editSpec.Items.Clear();
            foreach (var univer in pData.UniverList)
            {
                if (univer.Name == editUniver.Text)
                {
                    foreach (var fac in univer.FacultetList)
                    {
                        if (fac.NameOfFac == editFac.Text)
                        {
                            foreach (var spec in fac.SpecList)
                            {
                                editSpec.Items.Add(spec.Name);
                            }
                        }
                    }
                }
            }
        }

        private void editSpec_SelectedValueChanged(object sender, EventArgs e)
        {
            restoreSpec.Text = editSpec.Text;
            foreach (var univer in pData.UniverList)
            {
                if (univer.Name == editUniver.Text)
                {
                    foreach (var fac in univer.FacultetList)
                    {
                        if (fac.NameOfFac == editFac.Text)
                        {
                            foreach (var spec in fac.SpecList)
                            {
                                editNumericPopular.Value = spec.Popular;
                                editNumericMin.Value = spec.Minbal;

                                restoreZNO1.Text = spec.Lzno[0].NAME;
                                editZno1.Value = (decimal)spec.Lzno[0].KOOF;

                                restoreZNO2.Text = spec.Lzno[1].NAME;
                                editZno2.Value = (decimal)spec.Lzno[1].KOOF;

                                RestoreZNO3.Text = spec.Lzno[2].NAME;
                                editZno3.Value = (decimal)spec.Lzno[2].KOOF;

                                RestoreZno4.Text = spec.Lzno[4].NAME;
                                editZno4.Value = (decimal)spec.Lzno[4].KOOF;



                                EditAtestat.Value = (decimal)spec.Lzno[3].KOOF;
                            }
                        }
                    }
                }
            }
        }

        private void editZno1_ValueChanged(object sender, EventArgs e)
        {
            editZno1.Increment = 0.005M;
        }

        private void editZno2_ValueChanged(object sender, EventArgs e)
        {
            editZno2.Increment = 0.005M;
        }

        private void editZno3_ValueChanged(object sender, EventArgs e)
        {
            editZno3.Increment = 0.005M;
        }

        private void editZno4_ValueChanged(object sender, EventArgs e)
        {
            editZno4.Increment = 0.005M;
        }

        private void EditAtestat_ValueChanged(object sender, EventArgs e)
        {
            EditAtestat.Increment = 0.005M;
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            foreach (var univer in pData.UniverList)
            {
                if (univer.Name == editUniver.Text)
                {
                    if (editUniver.Text == restoreUniver.Text)
                    {
                        univer.Name = restoreUniver.Text;
                    }
                    else if (editUniver.Text != restoreUniver.Text && restoreUniver.TextLength != 0)
                    {
                        univer.Name = restoreUniver.Text;
                    }
                }
            }


            foreach (var univer in pData.UniverList)
            {
                if (univer.Name == editUniver.Text)
                {
                    foreach (var fac in univer.FacultetList)

                    {
                        if (fac.NameOfFac == editFac.Text)
                        {
                            if (editFac.Text == RestoreFac.Text)
                            {
                                fac.NameOfFac = RestoreFac.Text;
                                fac.PayForContract = (int)editNumericPay.Value;
                            }
                            else if (editFac.Text != RestoreFac.Text && RestoreFac.TextLength != 0)
                            {
                                fac.NameOfFac = RestoreFac.Text;
                                fac.PayForContract = (int)editNumericPay.Value;
                            }
                        }
                    }
                }
            }


            foreach (var univer in pData.UniverList)
            {
                if (univer.Name == editUniver.Text)
                {
                    foreach (var fac in univer.FacultetList)

                    {
                        if (fac.NameOfFac == editFac.Text)
                        {
                            foreach (var spec in fac.SpecList)
                            {
                                if (editSpec.Text == restoreSpec.Text)
                                {
                                    spec.Name = restoreSpec.Text;
                                    spec.Popular = (int)editNumericPopular.Value;
                                    spec.Minbal = (int)editNumericMin.Value;

                                    spec.Lzno[0].NAME = restoreZNO1.Text;
                                    spec.Lzno[0].KOOF = (double)editZno1.Value;

                                    spec.Lzno[1].NAME = restoreZNO2.Text;
                                    spec.Lzno[1].KOOF = (double)editZno2.Value;

                                    spec.Lzno[2].NAME = RestoreZNO3.Text;
                                    spec.Lzno[2].KOOF = (double)editZno3.Value;

                                    spec.Lzno[4].NAME = RestoreZno4.Text;
                                    spec.Lzno[4].KOOF = (double)editZno4.Value;

                                    spec.Lzno[3].KOOF = (double)EditAtestat.Value;
                                }
                                else if (editSpec.Text != restoreSpec.Text && restoreSpec.TextLength != 0)
                                {
                                    spec.Name = restoreSpec.Text;
                                    spec.Popular = (int)editNumericPopular.Value;
                                    spec.Minbal = (int)editNumericMin.Value;

                                    spec.Lzno[0].NAME = restoreZNO1.Text;
                                    spec.Lzno[0].KOOF = (double)editZno1.Value;

                                    spec.Lzno[1].NAME = restoreZNO2.Text;
                                    spec.Lzno[1].KOOF = (double)editZno2.Value;

                                    spec.Lzno[2].NAME = RestoreZNO3.Text;
                                    spec.Lzno[2].KOOF = (double)editZno3.Value;

                                    spec.Lzno[4].NAME = RestoreZno4.Text;
                                    spec.Lzno[4].KOOF = (double)editZno4.Value;

                                    spec.Lzno[3].KOOF = (double)EditAtestat.Value;
                                }
                            }
                        }
                    }
                }
            }
            MessageBox.Show("Зміни успішно внесені");
        }



       }
    }
                            

                        
    

