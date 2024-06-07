using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Web.Mvc;

namespace MIS2019
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
    public class Anamnesis
    {
        public int ID { get; set; }
        public int type { get; set; }
        [DisplayName("Анамнез")]
        [DataType(DataType.MultilineText)]
        public String Anamnes { get; set; }
        [DisplayName("Примечание")]
        [DataType(DataType.MultilineText)]
        public String comments { get; set; }
    }
    public class DiagnosisType
    {
        public int ID { get; set; }
        [DisplayName("Диагноз")]

        public String name { get; set; }
        [DisplayName("Описание")]
        [DataType(DataType.MultilineText)]
        public String description { get; set; }
    }
    public class Diagnosis
    {
        public int ID { get; set; }
        [DisplayName("Диагноз")]
        public DiagnosisType type { get; set; }
        [DisplayName("Комментарий")]
        [DataType(DataType.MultilineText)]
        public String comments { get; set; }

    }
    public class VisitDate
    {

        public int ID { get; set; }
        public int doctorID { get; set; }
        [DisplayName("Дата приема")]
        public DateTime date { get; set; }
        public List<Anamnesis> anamnesis { get; set; }

    }
    public enum Sex
    {
        [Display(Name = "Женский")]
        F,
        [Display(Name = "Мужской")]
        M

    }
    public class Pacient
    {
        public int ID { get; set; }

        [DisplayName("ФИО")]
        public String name { get; set; }
        [DisplayName("Номер карты")]
        public String cart { get; set; }
        [DisplayName("Телефон")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public String phone { get; set; }
        [DisplayName("Дата регистрации в системе")]
        [DataType(DataType.Date)]
        public DateTime dateOfregistration { get; set; }
        [DisplayName("Пол")]

        public Sex sex { get; set; }
        [DisplayName("Дата рождения")]

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime birthday { get; set; }
        [DisplayName("Мать")]
        public String mother { get; set; }
        [DisplayName("Отец")]
        public String father { get; set; }
        [DisplayName("Адрес проживания")]

        public String adress { get; set; }
        [DisplayName("Коментарии")]
        [DataType(DataType.Html)]
        [AllowHtml]

        public String comments { get; set; }
        public List<VisitDate> visits { get; set; }
    }
}