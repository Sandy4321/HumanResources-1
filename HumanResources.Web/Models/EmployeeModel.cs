﻿using System;
using System.ComponentModel.DataAnnotations;

namespace HumanResources.Web.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Город")]
        public int CityId { get; set; }

        public string CityName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [MaxLength(50)]
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [MaxLength(200)]
        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Дата старта")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? EndDate { get; set; }

        public string MobilePhone { get; set; }
        public string Phone { get; set; }
        public int? ManagerId { get; set; }

        public string ManagerName { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        public string Position { get; set; }


        public static string GetDisplayName(string surname, string name, string patronymic)
        {
            string result = surname + " " + name[0] + ".";

            if (!string.IsNullOrEmpty(patronymic))
                result += patronymic[0] + ".";

            return result;
        }
    }
}