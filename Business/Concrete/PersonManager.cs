﻿using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager:IApplicantServie
    {
     public void ApplyFormMask(Person person)
     {


     }
        public List<Person> GetList() 
        {
            return null;
        }
        public bool CheckPerson(Person person)
        {
            return true;
        }
        
    }
}
