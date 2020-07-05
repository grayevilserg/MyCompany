﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        
        [Required(ErrorMessage = "Заполните название услуги")]
        [Display(Name = "Название услуги (заголовок)")]
        public override string Title { get; set; } 

        [Display(Name = "Краткое описание услуги")]
        public override string Subtitle { get; set; } 
        
        [Display(Name = "Полное описаник услуги")]
        public override string Text { get; set; } 
    }
}
