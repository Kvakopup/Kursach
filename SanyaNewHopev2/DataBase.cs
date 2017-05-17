using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SanyaNewHopev2
{
    [Serializable]
    public class DataBase
    {
        public DataBase()
        {
            //UniverList =
            //new List<University>
            //{
            //new University("ХНУРЕ",/*new List<string>{"Общежитие №1 – станция м. «Научная», ул. Бакулина, 10; тел. 70 - 20 - 818; на 210 мест",
            //                                        "Общежитие №2 - станция м. «Научная», ул. Бакулина, 12;  тел. 70-20-789; на 240 мест",
            //                                        "Общежитие №4 – станция м. «Алексеевская», ул. Целиноградская, 36; тел. 336-77-65; на 460 мест",
            //                                        "Общежитие №5 – станция м. «Алексеевская», ул. Целиноградская, 58; тел. 336-77-24; на 370 мест",
            //                                        "Общежитие №6 – станция м. «Ботанический сад», ул. Клочковская, 218; тел. 340-02-65; на 510 мест",
            //                                        "Общежитие №7 – станция м. «Алексеевская», пр. Л. Свободы, 51а; тел. 337-87-08; на 640 мест",
            //                                        "Общежитие №8 – станция м. «Алексеевская», пр. Л. Свободы 51б; тел. 337-87-09; на 640 мест"},*/
            //new List<Facultet> { new Facultet("Прикладної математики і менеджменту",7500 ,

            //new List<Spec> {
            //new Spec("Системний аналіз",
            //new List<ZNO> {

            //new ZNO(0.45, "ЗНО-МАТЕМ"),
            //new ZNO(0.2, "ЗНО-УКР"),
            //new ZNO(0.2, "ЗНО-ФИЗИКА"),
            //new ZNO(0.15,"Атестат"),
            //},172,160 ),

            //    new Spec("Прикладна математика",
            //    new List<ZNO> {
            //    new ZNO(0.45, "ЗНО-МАТЕМ"),
            //    new ZNO(0.2, "ЗНО-УКР"),
            //    new ZNO(0.2, "ЗНО-ФИЗИКА"),
            //    new ZNO(0.15, "Атестат")},160, 132),

            //    new Spec("Економіка",
            //    new List<ZNO>
            //    {
            //        new ZNO( 0.25,"ЗНО-ІНОЗЕМ"),
            //        new ZNO(0.2 , "ЗНО-УКР"),
            //        new ZNO(0.45, "ЗНО-ІСТОР"),
            //        new ZNO(0.1, "Атестат")
            //    },110,156),
            //}),

            //new Facultet("Радіотехнічний",8900,
            //new List<Spec>
            //{
            //    new Spec("Телекомунікації та радіотехніка",
            //    new List<ZNO>
            //    {
            //        new ZNO(0.2, "ЗНО-УКР"),
            //        new ZNO(0.45, "ЗНО-МАТЕМ"),
            //        new ZNO(0.2, "ЗНО-ФІЗИКА"),
            //        new ZNO(0.15, "Атестат")
            //    },133, 149),

            //    new Spec("Кібербезпека",
            //    new List<ZNO>
            //    {
            //       new ZNO(0.2, "ЗНО-УКР"),
            //        new ZNO(0.45, "ЗНО-МАТЕМ"),
            //        new ZNO(0.2, "ЗНО-ФІЗИКА"),
            //        new ZNO(0.15, "Атестат")
            //    }, 233,169),

            //    new Spec("Електроніка",
            //    new List<ZNO>
            //    {
            //         new ZNO(0.2, "ЗНО-УКР"),
            //        new ZNO(0.35, "ЗНО-МАТЕМ"),
            //        new ZNO(0.3, "ЗНО-ФІЗИКА"),
            //        new ZNO(0.15, "Атестат")
            //    },57,145) }


            //    ) }




            //    )
            //};

            //BinaryFormatter formatter = new BinaryFormatter();
            //using (FileStream fs = new FileStream("DB.dat", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, UniverList);
            //}

            UniverList = new List<University>();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("DB.dat", FileMode.OpenOrCreate))
            {
                try
                {
                    UniverList = (List<University>)formatter.Deserialize(fs);
                }
                catch
                {
                    Console.WriteLine("Is empty");
                }
            }

        }



        public List<University> UniverList { get; set; }

        public List<string> GetFullDistinctSpecList()//создает список специальностей
        {
            List<string> specList = new List<string>();
            foreach (var univ in UniverList)
            {
                foreach (var fac in univ.FacultetList)
                {
                    foreach (var spec in fac.SpecList)
                    {
                        specList.Add(spec.Name);
                    }
                }
            }
            specList = specList.Distinct().ToList(); //если два одинаковых , то убирает повторения
            return specList;
        }

        public List<string> GetFullDistinctFacList()
        {
            List<string> facList = new List<string>();
            foreach (var univ in UniverList)
            {
                foreach (var fac in univ.FacultetList)
                {
                   
                        facList.Add(fac.NameOfFac);
                    
                }
            }
            facList = facList.Distinct().ToList();
            return facList;
        }

    }
}
